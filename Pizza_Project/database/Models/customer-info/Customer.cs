using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pizza_Project.database.Models.customer_info.payment;
using Pizza_Project.database.Models.order_info;
using Pizza_Project.database.Models.person_info;

namespace Pizza_Project.database.Models.customer_info
{
    public class Customer : Person
    {
        [JsonPropertyName("orders")]
        public IList<Order> Orders {get; set;}
        
        [JsonPropertyName("paymentInfo")]
        public IList<CreditCardInfo> PaymentInfo { get; set; }
    }
}