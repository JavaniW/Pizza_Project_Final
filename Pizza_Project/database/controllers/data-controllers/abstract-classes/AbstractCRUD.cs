using Pizza_Project.database.controllers.file_handler;
using Pizza_Project.database.controllers.interfaces;
using Pizza_Project.database.Models;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Pizza_Project.database.controllers.data_controllers.abstract_classes
{
    public abstract class AbstractCRUD<T> : ICRUD<T>
    {

        public T Create(T item)
        {
            var items = Read();
            items.Add(item);
            Update(items);
            return item;
        }

        public abstract List<T> Read();

        public abstract void Update(List<T> list);

        public void UpdateById(string id, T data) {
            var items = Read();
            var itemIndex = GetIndex(id);
            items[itemIndex] = data;
            Update(items);
        }

        public void Delete(string id) {
            var items = Read();
            var itemPosition = GetIndex(id);
            items.Remove(items[itemPosition]);
            Console.WriteLine(items.Count);
            Update(items);
        }

        public T GetById(string id)
        {
            return FindItemByProperty(Read(), id, "Id");
        }

        public PizzaDatabase GetAllData()
        {
            return DatabaseHandler.Read().Result;
        }

        public int GetIndex(string id)
        {
            var list = Read();
            return list.IndexOf(FindItemByProperty(list, id, "Id"));
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
