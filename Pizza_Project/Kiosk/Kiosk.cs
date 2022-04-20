using System;
using Pizza_Project.kiosk.Checkout;

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

        public void Checkout(string paymentType)
        {
            var (cartItems, orderPrice) = _cart.GetCartDetails();
            this._checkoutHandler.Checkout(custId, cartItems, orderPrice, paymentType);
        }

        public Cart GetCart()
        {
            return this._cart;
        }
    }
}