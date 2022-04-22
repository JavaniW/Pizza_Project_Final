using System.Collections.Generic;
using Pizza_Project.database.Models;

namespace Pizza_Project.database.controllers.interfaces
{
    public interface ICRUD<T>
    {
        /// <summary>
        /// Creates an item to be added to the database
        /// </summary>
        /// <param name="item">Item to be created</param>
        /// <returns>Created item</returns>
        T Create(T item);
        
        ///<summary>
        /// Fetches all users from database
        ///</summary>
        List<T> Read();
        
        /// <summary>
        /// Updates a list of items.
        ///
        /// This method is the basis of all modifications to the database.
        /// </summary>
        /// <param name="list">List of items to be inserted into list</param>
        void Update(List<T> list);
        
        /// <summary>
        /// Updates a single item
        /// </summary>
        /// <param name="id">id of item to update</param>
        /// <param name="data">Updated data</param>
        void UpdateById(string id, T data);
        
        /// <summary>
        /// Deletes an item from the database
        /// </summary>
        /// <param name="id">id of item to delete</param>
        void Delete(string id);
        
        /// <summary>
        /// Gets item based on id
        /// </summary>
        /// <param name="id">id of item</param>
        /// <returns>Item based on id</returns>
        T GetById(string id);
        
        /// <summary>
        /// Gets the index of a specific item in database
        /// </summary>
        /// <param name="id">id of item</param>
        /// <returns>index of item in the database</returns>
        int GetIndex(string id);

        /// <summary>
        /// Gets all data from database
        /// </summary>
        /// <returns>entire database</returns>
        PizzaDatabase GetAllData();
        
        /// <summary>
        /// Dynamically fetches data from database based on a specific property
        /// </summary>
        /// <param name="list">List of items to search through </param>
        /// <param name="compareString">string to compare to the value in property</param>
        /// <param name="property">property name</param>
        /// <returns>item based on a property</returns>
        T FindItemByProperty(List<T> list, string compareString, string property);
    }
}