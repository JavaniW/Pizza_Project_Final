using System;
using System.Collections.Generic;
using System.Linq;
using Pizza_Project.database.controllers.data_controllers.person_controllers;
using Pizza_Project.database.Models.order_info;

namespace Pizza_Project.database.controllers.data_controllers.order_controllers
{
    public class OrderController
    {
        private readonly CustomerController _customerController = new CustomerController();

        /// <summary>
        /// Creates a customer's order
        /// </summary>
        /// <param name="order">Customer's order</param>
        /// <param name="customerPhone">Customer's phone number</param>
        public void CreateOrder(Order order, string customerId)
        {
            order.OrderNumber = GetOrderCount() + 1;
            var customer = _customerController.GetById(customerId);
            customer.Orders.Add(order);
           _customerController.UpdateById(customer.Id, customer);
        }

        /// <summary>
        /// Updates an order
        /// </summary>
        /// <param name="orderNumber">Order number</param>
        /// <param name="updatedOrder">An updated order object</param>
        public void UpdateOrder(int orderNumber, Order updatedOrder)
        {
            var customers = _customerController.Read();

            var order = GetOrderByNumber(orderNumber);
            var customer = customers
                .Select(singleCustomer =>
                {
                    singleCustomer.Orders = singleCustomer.Orders
                        .Select(singleOrder =>
                        {
                            if (singleOrder.OrderNumber == order.OrderNumber)
                            {
                                singleOrder = updatedOrder;
                            }

                            return singleOrder;
                        }).ToList();
                    return singleCustomer;
                }).ToList()[0];

            _customerController.UpdateById(customer.Id, customer);
        }

        /// <summary>
        /// Get the total count of orders
        /// </summary>
        /// <returns>Total number of orders</returns>
        private int GetOrderCount()
        {
            var (orders, count) = GetCountAndOrders();
            return count;
        }

        /// <summary>
        /// Gets all orders
        /// </summary>
        /// <returns>List of all orders</returns>
        public List<Order> GetAllOrders()
        {
            var (orders, count) = GetCountAndOrders();
            return orders;
        }

        /// <summary>
        /// Gets all orders from a specific customer
        /// </summary>
        /// <param name="customerPhone">Customer phone number</param>
        /// <returns>List of customer's orders</returns>
        public List<Order> GetCustomerOrders(string customerPhone)
        {
            var customer = _customerController.GetByPhone(customerPhone);
            return new List<Order>(customer.Orders);
        }
        
        /// <summary>
        /// Gets order by order number
        /// </summary>
        /// <param name="orderNumber">Order to be found</param>
        /// <returns>Order found by number</returns>
        public Order GetOrderByNumber(int orderNumber)
        {
            var (orders, orderCount) = GetCountAndOrders();
            return orders.Find(order => order.OrderNumber == orderNumber);
        }
        
        /// <summary>
        /// Gets all orders and the total count of orders
        /// </summary>
        /// <returns>List of orders and total order count</returns>
        private (List<Order>, int) GetCountAndOrders()
        {
            var customers = _customerController.Read();
            var orders = customers
                .SelectMany(customer => customer.Orders)
                .Where(order => order != null).ToList();
            return (orders, orders.Count);
        }
    }
}