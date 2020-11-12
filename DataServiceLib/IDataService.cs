using System.Collections.Generic;

namespace DataServiceLib
{
    public interface IDataService
    {
        //IList<Category> GetCategories();
        //Category GetCategory(int id);
        //IList<Product> GetProducts();
        IList<Title_Basics> GetTitles();
        IList<Users> GetUsers();
        //IList<Users> GetUserId(int id);
        IList<Name_Basics> GetNames();
        //IList<Name_Basics> GetNameId(int id);
        IList<SearchTitleFunction> SearchTitle(int userid, string searchentry);
        IList<SearchTitleFunction> StructuredSearch(int userid, string entrytitle, string entryplot, string entrycharacters, string entryname);
        //Product GetProduct(int id);
        Users CreateUser(Users user);
        //void CreateCategory(Category category);
        //bool UpdateCategory(Category category);
        //bool DeleteCategory(int id);
    }
}