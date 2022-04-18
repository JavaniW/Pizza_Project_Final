using System.Collections.Generic;

using Pizza_Project.database.controllers.data_controllers.order_controllers;
using Pizza_Project.database.controllers.data_controllers.person_controllers;
using Pizza_Project.database.Models.order_info;

namespace Pizza_Project.Kiosk.Checkout
{
    public class CheckoutHandler
    {
        private readonly OrderController _orderController;
        private readonly PaymentHandler _paymentHandler;

        public CheckoutHandler()
        {
            this._orderController = new OrderController();
            this._paymentHandler = new PaymentHandler();
        }

        public void Checkout(string custId, List<OrderItems> cartItems, double cartPrice, string paymentType)
        {
            
            this.AddOrderToCustomer(custId, cartItems, cartPrice);
        }

        private void AddOrderToCustomer(string custId, List<OrderItems> orderItems, double orderTotal)
        {
            var order = new Order
            {
                Items = orderItems,
                OrderName = "",
                OrderTotal = orderTotal
            };
            
            _orderController.CreateOrder(order, custId);
        }
    }
}