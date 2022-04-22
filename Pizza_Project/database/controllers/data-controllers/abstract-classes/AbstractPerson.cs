using System.Collections.Generic;

namespace Pizza_Project.database.controllers.data_controllers.abstract_classes
{
    public abstract class AbstractPerson<T> : AbstractCRUD<T>
    {
        public T GetByPhone(string phoneNumber)
        {
            return FindItemByProperty(Read(), phoneNumber, "PhoneNumber");
        }
    }
}