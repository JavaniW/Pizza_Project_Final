using System.Collections.Generic;

namespace Pizza_Project.database.controllers.interfaces
{
    public interface ICRUD<T>
    {
        T Create(T item);
        List<T> Read();
        void Update(List<T> list);
        void UpdateById(string id, T data);
        void Delete(string id);
        T GetById(string id);
        int GetIndex(string id);
    }
}