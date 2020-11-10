using System.Collections.Generic;

namespace DataServiceLib
{
    public interface IDataService
    {
        IList<Category> GetCategories();
        Category GetCategory(int id);
        IList<Product> GetProducts();
        IList<title_basics> GetTitles();
        IList<Users> GetUsers();
        Product GetProduct(int id);
        void CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(int id);
    }
}