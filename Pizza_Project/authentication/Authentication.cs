using System;
using System.Collections.Generic;
using Pizza_Project.database.controllers.data_controllers.person_controllers;
using Pizza_Project.database.Models.person_info;
using Pizza_Project.database.Models.user_info;
// using Pizza_Project.services.interfaces;

namespace Pizza_Project.authentication
{
    public class Authentication
    {
        private readonly UserController _userController = new UserController();

        /// <summary>
        /// Logs a user into the application
        /// </summary>
        /// <param name="email">user's email</param>
        /// <param name="password">users password</param>
        /// <returns>true if a user can be logged in, false if user could not be logged in</returns>
        public bool Login(string email, string password)
        {
            try
            {
                var user = _userController.GetByEmail(email);
                if (user.Password == password)
                {
                    Console.WriteLine("User logged in");
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Email or password is incorrect.");
                return false;
            }
            
        }

        /// <summary>
        /// Logs a user out of the application
        /// </summary>
        /// <returns>false</returns>
        public bool Logout() {
            return false;
        }

        /// <summary>
        /// Creates a user
        /// </summary>
        /// <param name="name">user name</param>
        /// <param name="email">user email</param>
        /// <param name="phoneNumber">user phone</param>
        /// <param name="role">user's role</param>
        /// <param name="password">user's password</param>
        /// <param name="address">user's address</param>
        /// <param name="city">user's city</param>
        /// <param name="state">user's state</param>
        /// <param name="zipCode">user's zipcode</param>
        /// <param name="extraInformation">user's extra info</param>
        public void CreateUser(string name,
            string email,
            string phoneNumber,
            string role,
            string password,
            string address,
            string city,
            string state,
            string zipCode,
            string extraInformation) {
                _userController.Create(new User
                {
                    Id = Identifier.CreateIdentifier(),
                    Name = name,
                    Email = email,
                    Password = password,
                    Role = role,
                    PhoneNumber = phoneNumber,
                    UserAddresses =  new PersonAddress
                        {
                            Address = address,
                            City = city,
                            State = state,
                            ZipCode = zipCode,
                            ExtraInformation = extraInformation
                        }
                    
                });
        }
    }
}