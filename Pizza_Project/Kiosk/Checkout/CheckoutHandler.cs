using System.Collections.Generic;

using Pizza_Project.database.controllers.data_controllers.order_controllers;
using Pizza_Project.database.Models.order_info;
using Pizza_Project.database.Models.customer_info.payment;

namespace Pizza_Project.kiosk.Checkout
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

        /// <summary>
        /// Handles checkouts 
        /// </summary>
        /// <param name="custId">id of customer</param>
        /// <param name="cartItems">list of cart items</param>
        /// <param name="cartPrice">total price of cart</param>
        /// <param name="paymentType">payment method</param>
        /// <param name="cashIn">cash given by customer</param>
        /// <returns>Created order, and change due</returns>
        public (Order, double) Checkout(string custId, List<OrderItems> cartItems, double cartPrice, string paymentType, double cashIn, CreditCardInfo cardInfo = null)
        {
            var change = 0.0;
            if (paymentType.Equals("cash"))
            {
                var (handled, changeDue) = _paymentHandler.PayWithCash(cashIn, cartPrice);
                change = changeDue;
            }else
            {
                if (cardInfo != null)
                {
                    _paymentHandler.PayWithCard(custId, cardInfo);
                }
            }

            return (this.AddOrderToCustomer(custId, cartItems, cartPrice), change);
        }

        /// <summary>
        /// Adds order to a customer in the database
        /// </summary>
        /// <param name="custId">id of customer</param>
        /// <param name="orderItems">list of order items</param>
        /// <param name="orderTotal">total price of order</param>
        /// <returns></returns>
        private Order AddOrderToCustomer(string custId, List<OrderItems> orderItems, double orderTotal)
        {
            var order = new Order
            {
                Items = orderItems,
                OrderName = "",
                OrderTotal = orderTotal
            };
            
            _orderController.CreateOrder(order, custId);

            return order;
        }
    }
}