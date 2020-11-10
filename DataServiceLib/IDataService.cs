using System.Collections.Generic;

namespace DataServiceLib
{
    public interface IDataService
    {
        IList<Category> GetCategories();
        Category GetCategory(int id);
        IList<Product> GetProducts();
        IList<Title_Basics> GetTitles();
        IList<Users> GetUsers();
        IList<Users> GetUserId(int id);
        IList<Name_Basics> GetNames();
        IList<Name_Basics> GetNameId(int id);
        Product GetProduct(int id);
        void CreateUser(Users user);
        void CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(int id);
    }
}