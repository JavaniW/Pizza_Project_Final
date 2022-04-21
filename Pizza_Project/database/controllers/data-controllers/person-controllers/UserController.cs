using System;
using System.Collections.Generic;
using Pizza_Project.database.controllers.data_controllers.abstract_classes;
using Pizza_Project.database.controllers.file_handler;
using Pizza_Project.database.Models.person_info;
using Pizza_Project.database.Models.user_info;

namespace Pizza_Project.database.controllers.data_controllers.person_controllers
{
    public class UserController : AbstractPerson<User>
    {

        public override List<User> Read()
        {
            var data = GetAllData();
            return new List<User>(data.People.Users);
        }
        

        public override void Update(List<User> list)
        {
            var data = GetAllData();
            data.People.Users = list;
            DatabaseHandler.Write(data);
        }

        /// <summary>
        /// Gets a user by email
        /// </summary>
        /// <param name="email">user's email</param>
        /// <returns>User</returns>
        public User GetByEmail(string email)
        {
            var users = Read();
            return FindItemByProperty(users, email, "Email");
        }
    }
}