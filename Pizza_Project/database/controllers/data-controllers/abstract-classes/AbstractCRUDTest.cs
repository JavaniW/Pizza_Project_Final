using System;
using System.Collections.Generic;
using System.Reflection;
using Pizza_Project.database.controllers.file_handler;
using Pizza_Project.database.controllers.interfaces;
using Pizza_Project.database.Models;
using Pizza_Project.database.Models.customer_info;
using Pizza_Project.database.Models.user_info;

namespace Pizza_Project.database.controllers.data_controllers.abstract_classes
{
    public abstract class AbstractCRUDTest<T> : ICRUD<T>
    {
        public T Create(T item)
        {
            var items = Read();
            items.Add(item);
            Update(items);
            return item;
        }

        ///<summary>
        /// Fetches all users from database
        ///</summary>
        public abstract List<T> Read();

        ///<summary>
        /// Replaces users with new list of users.
        ///</summary>
        public abstract void Update(List<T> list);

        ///<summary>
        /// Updates a single user.
        ///</summary>
        public void UpdateById(string id, T data) {
            var items = Read();
            var itemIndex = GetIndex(id);
            items[itemIndex] = data;
            Update(items);
        }

        ///<summary>
        /// Deletes user from database.
        ///</summary>
        public void Delete(string id) {
            var items = Read();
            var itemPosition = GetIndex(id);
            items.Remove(items[itemPosition]);
            Console.WriteLine(items.Count);
            Update(items);
        }

        ///<summary>
        /// Gets user by id.
        ///</summary>
        public T GetById(string id)
        {
            return FindItemByProperty(Read(), id, "id");
        }

        public T GetByPhone(string phoneNumber)
        {
            return FindItemByProperty(Read(), phoneNumber, "phoneNumber");
        }

        ///<summary>
        /// Get all data.
        ///</summary>
        protected PizzaDatabase GetAllData()
        {
            return DatabaseHandler.Read().Result;
        }

        ///<summary>
        /// Get user index
        ///</summary>
        public int GetIndex(string id)
        {
            var list = Read();
            return list.IndexOf(FindItemByProperty(list, id, "id"));
        }

        public T? FindItemByProperty(List<T> list, string compareString, string property)
        {
            foreach (var item in list)
            {
                Type t = item.GetType();
                PropertyInfo prop = t.GetProperty(property);
                if (compareString.Equals(prop.GetValue(item)))
                {
                    return item;
                }
            }

            return default;

        }
    }
}