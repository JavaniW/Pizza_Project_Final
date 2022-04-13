using System;
using System.Collections.Generic;
using Pizza_Project.database.controllers.data_controllers.person_controllers;
using Pizza_Project.database.Models.person_info;
using Pizza_Project.database.Models.user_info;
using Pizza_Project.services.interfaces;

namespace Pizza_Project.authentication
{
    public class Authentication
    {
        private readonly IAuthService _authService;
        private readonly UserController _userController;

        public Authentication(IAuthService authService, UserController userController)
        {
            _authService = authService;
            _userController = userController;
        }
        
        public void Login(string email, string password)
        {

            if (_authService.GetAuthStatus())
            {
                return;
            }

            try
            {
                var user = _userController.GetByEmail(email);
                if (user.Password == password)
                {
                    _authService.UpdateAuthStatus(true);
                    Console.WriteLine("User logged in");
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Email or password is incorrect.");
            }
            
        }

        public void Logout() {
            _authService.UpdateAuthStatus(false);
            Console.WriteLine("User logged out.");
        }

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
                    UserAddresses = new List<PersonAddress>
                    {
                        new PersonAddress
                        {
                            Address = address,
                            City = city,
                            State = state,
                            ZipCode = zipCode,
                            ExtraInformation = extraInformation
                        }
                    }
                });
        }
    }
}