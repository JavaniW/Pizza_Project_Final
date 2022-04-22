using System;
using System.Collections.Generic;
using Pizza_Project;
using Pizza_Project.database.Models.order_info;
using Pizza_Project.database.controllers.data_controllers.menu_controllers;

namespace Pizza_Project.kiosk
{
    public class Cart
    {
        private readonly MenuItemController _menuItemController;
        private readonly MenuIngredientController _menuIngredientController;
        
        private List<OrderItems> _cartItems;
        private double _orderTotal = 0;

        public Cart()
        {
            this._cartItems = new List<OrderItems>();
            this._menuItemController = new MenuItemController();
            this._menuIngredientController = new MenuIngredientController();
        }

        /// <summary>
        /// Adds item to cart.
        /// </summary>
        /// <param name="itemId">A food item's id</param>
        /// <param name="ingredients">List of ingredients added by user.</param>
        /// <param name="quantity">Total number of item to be ordered.</param>
        /// <returns>true if item added, false if item could not be added.</returns>
        public bool AddItem(List<string> ingredients, int quantity, string itemType)
        {
            //var menuItem = _menuItemController.GetById(itemId);
            //menuItem.IngredientIds = ingredients;


            /* var orderItem = new OrderItems
             {
                 Id = Identifier.CreateIdentifier(),
                 Name = "Pizza" + this._cartItems.Count,
                 //MenuItem = menuItem,
                 ItemTotal = _menuIngredientController.GetIngredientPrice(ingredients),
                 //ItemTotal = _menuItemController.GetFinalPrice(menuItem.Price, menuItem.IngredientIds),
                 Quantity = quantity
             };
            */

            if (GetToppingAmount(ingredients) > 4) return false;
            var orderItem = this.CreateItem(ingredients, quantity, itemType);
            
            this._cartItems.Add(orderItem);
            this.CalculateCartTotal();
            return true;
        }
        
        /// <summary>
        /// Removes item from cart
        /// </summary>
        /// <param name="id">Id of item to be removed</param>
        /// <returns>True if value was removed, false if value was not able to be removed.</returns>
        public bool RemoveItem(string id)
        {
            foreach (var item in this._cartItems)
            {
                if (item.Id.Equals(id))
                {
                    this._cartItems.Remove(item);
                    this.CalculateCartTotal();
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Updates a cart item.
        /// </summary>
        /// <param name="id">id of item to update</param>
        /// <param name="ingredients">list of ingredient ids</param>
        /// <param name="quantity">number of item</param>
        /// <returns>true if updated, false if could not update</returns>
        public bool UpdateItem(string id, List<string> ingredients, int quantity, string itemType)
        {
            if (GetToppingAmount(ingredients) > 4) return false;

            foreach (var item in this._cartItems)
            {
                if (item.Id.Equals(id))
                {
                    var newItem = this.CreateItem(ingredients, quantity, itemType, item.Id);
                    this._cartItems[this._cartItems.IndexOf(item)] = newItem;
                    this.CalculateCartTotal();
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Creates a cart item
        /// </summary>
        /// <param name="itemId">id of menu item</param>
        /// <param name="ingredients">list of ingredient ids</param>
        /// <param name="quantity">number of menu item</param>
        /// <param name="id">previous id if exists</param>
        /// <returns>a created order item</returns>
        private OrderItems CreateItem(List<string> ingredients, int quantity, string itemType, string id = "")
        {
            //var menuItem = _menuItemController.GetById(itemId);
            //menuItem.IngredientIds = ingredients;

            if (id.Equals("")) id = Identifier.CreateIdentifier();

            return new OrderItems
            {
                Id = id,
                Name = itemType + this._cartItems.Count,
                Ingredients = ingredients,
                ItemTotal = _menuIngredientController.GetIngredientPrice(ingredients),
                Quantity = quantity
            };
        }

        /// <summary>
        /// Gets total number of added toppings
        /// </summary>
        /// <param name="ids">list of ingredient ids</param>
        /// <returns>number of toppings</returns>
        private int GetToppingAmount(List<string> ids)
        {
            var toppingCount = 0;
            var ingredients = this._menuIngredientController.Read();

            foreach (var id in ids)
            {
                foreach (var ingredient in ingredients)
                {
                    if (ingredient.Id.Equals(id))
                    {
                        if (ingredient.Category.Equals("meat") ||
                            ingredient.Category.Equals("vegetable") ||
                            ingredient.Category.Equals("fruit")) toppingCount++;
                    }
                }
            }

            return toppingCount;
        }
        
        /// <summary>
        /// Calculates total price of cart.
        /// </summary>
        private void CalculateCartTotal()
        {
            double total = 0;
            this._cartItems.ForEach(e => total += (e.ItemTotal * e.Quantity));
            this._orderTotal = total;
        }

        /// <summary>
        /// Gets order total
        /// </summary>
        /// <returns>Cart Total</returns>
        public double GetOrderPrice()
        {
            return _orderTotal;
        }

        /// <summary>
        /// gets all cart details
        /// </summary>
        /// <returns>Cart items and cart price.</returns>
        public (List<OrderItems>, double) GetCartDetails()
        {
            return (this._cartItems, this._orderTotal);
        }

        public string GetItemId(string itemName)
        {
            string itemId = "";
            this._cartItems.ForEach(item =>
            {
                //System.Diagnostics.Debug.WriteLine(item.Name);
                if (item.Name.Equals(itemName))
                {
                    itemId = item.Id;

                }
            });
            return itemId;
        }
    }
}