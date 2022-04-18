using System;
using pizza_project_menu_selection_update.Kiosk.Checkout;

namespace pizza_project_menu_selection_update.Kiosk
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