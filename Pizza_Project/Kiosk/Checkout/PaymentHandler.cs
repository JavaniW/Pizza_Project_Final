using Pizza_Project.database.controllers.data_controllers.person_controllers;
using Pizza_Project.database.Models.customer_info.payment;

namespace Pizza_Project.kiosk.Checkout
{
    public class PaymentHandler
    {
        private readonly CustomerController _customerController;
        

        public PaymentHandler()
        {
            this._customerController = new CustomerController();
        }
        
        /// <summary>
        /// Processes credit card payments.
        /// </summary>
        /// <param name="cardNumber">credit card number</param>
        /// <param name="exp">credit card expiration</param>
        /// <param name="cvc">credit card CVC number</param>
        /// <param name="nameOnCard">credit card name</param>
        /// <returns>true if payment was successful, false if not</returns>
        public bool PayWithCard(string custId, string cardNumber, string exp, string cvc, string nameOnCard)
        {
            var customer = _customerController.GetById(custId);
            
            if (customer.PaymentInfo == null)
            {
                var cardDetails = this.CreateCard(cardNumber, exp, cvc, nameOnCard);
                if (cardDetails == null) return false;

                customer.PaymentInfo = cardDetails;
                _customerController.UpdateById(custId, customer);
                
                return true;
            }

            return true;
        }

        /// <summary>
        /// Creates a credit card
        /// </summary>
        /// <param name="cardNumber">credit card number</param>
        /// <param name="exp">credit card expiration</param>
        /// <param name="cvc">credit card CVC number</param>
        /// <param name="nameOnCard">credit card name</param>
        /// <returns>Credit card info object or null</returns>
        private CreditCardInfo CreateCard(string cardNumber, string exp, string cvc, string nameOnCard)
        {
            if (cardNumber.Length == 16 && exp.Length == 5 && cvc.Length == 3)
            {
                return new CreditCardInfo
                {
                    NameOnCard = nameOnCard,
                    CardNumber = cardNumber,
                    ExpDate = exp,
                    CVC = cvc
                };
            }
            return default;
        }
        
        /// <summary>
        /// Handles cash payment
        /// </summary>
        /// <param name="cashReceived">Cash given to user at register</param>
        /// <returns>returns status bool and change due</returns>
        public (bool, double) PayWithCash(double cashReceived, double orderTotal)
        {
            var change = cashReceived - orderTotal;
            if (change < 0) return (false, 0);

            return (true, change);
        }
    }
}