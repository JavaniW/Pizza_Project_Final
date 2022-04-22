using System;

using Pizza_Project.kiosk.Checkout;
using Pizza_Project.database.Models.customer_info.payment;
using Pizza_Project.database.Models.order_info;

namespace Pizza_Project.kiosk
{
    public class Kiosk
    {
        private readonly Cart _cart;
        private readonly CheckoutHandler _checkoutHandler;

        private readonly string custId;

        public Kiosk(string custId)
        {
            this._cart = new Cart();
            this._checkoutHandler = new CheckoutHandler();
            this.custId = custId;
        }

        /// <summary>
        /// Gets a customers id
        /// </summary>
        /// <returns>current customer's id</returns>
        public string GetCustomerId()
        {
            return this.custId;
        }

        /// <summary>
        /// Handles checkout
        /// </summary>
        /// <param name="paymentType">payment method</param>
        /// <param name="cashIn">cash given by customer</param>
        /// <param name="cardInfo">customer's card info</param>
        public (Order, double) Checkout(string paymentType, double cashIn, CreditCardInfo cardInfo = null)
        {
            var (cartItems, orderPrice) = _cart.GetCartDetails();
            return this._checkoutHandler.Checkout(custId, cartItems, orderPrice, paymentType, cashIn, cardInfo);
        }

        /// <summary>
        /// Gets the cart object
        /// </summary>
        /// <returns>Cart object</returns>
        public Cart GetCart()
        {
            return this._cart;
        }
    }
}