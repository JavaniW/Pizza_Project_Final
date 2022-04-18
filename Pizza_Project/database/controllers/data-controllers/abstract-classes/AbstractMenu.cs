using System.Collections.Generic;
using System.Linq;

namespace Pizza_Project.database.controllers.data_controllers.abstract_classes
{
    public abstract class AbstractMenu<T> : AbstractCRUD<T>
    {
        public List<T> GetItemByCategory(string category)
        {
            var items = this.Read();
            
            var newList = new List<T>();
            var tempList = new List<T>();
            
            foreach (var item in items)
            {
                tempList.Add(item);
                if (FindItemByProperty(tempList, category, "Category") != null)
                {
                    newList.Add(item);
                }
                tempList.Clear();
            }

            return newList;

        }

        public T GetItemByName(string name)
        {
            return FindItemByProperty(this.Read(), name, "Name");
        }
    }
}