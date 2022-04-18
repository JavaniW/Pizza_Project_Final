using System;
using System.Collections.Generic;
using Pizza_Project.database.controllers.data_controllers.abstract_classes;
using Pizza_Project.database.controllers.file_handler;
using Pizza_Project.database.Models.customer_info;
using Pizza_Project.database.Models.person_info;

namespace Pizza_Project.database.controllers.data_controllers.person_controllers
{
    public class CustomerController : AbstractCRUD<Customer>
    {
        public override  List<Customer> Read() {
            var data =  GetAllData().People.Customers;
            if (data.Count == 0) return new List<Customer>();
            return new List<Customer>(data);
        }

        public override void Update(List<Customer> updatedList)
        {
            var data = GetAllData();
            data.People.Customers = updatedList;
            DatabaseHandler.Write(data);
        }
    }

}