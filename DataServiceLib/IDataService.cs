using System.Collections.Generic;

namespace DataServiceLib
{
    public interface IDataService
    {
        //IList<Category> GetCategories();
        //Category GetCategory(int id);
        //IList<Product> GetProducts();
        IList<Title_Basics> GetTitles(int? userid);
        Title_Basics GetTitle(int? userid, string tconst);
        IList<Users> GetUsers();
        //IList<Users> GetUserId(int id);
        IList<Name_Basics> GetNames();
        IList<Users_SearchHistory> GetSearchHistory(int? userid);
        //IList<Name_Basics> GetNameId(int id);
        IList<SearchTitleFunction> SearchTitle(int userid, string searchentry);
        IList<StructuredSearchFunction> StructuredSearch(int userid, string entrytitle, string entryplot, string entrycharacters, string entryname);
        //Product GetProduct(int id);
        Users CreateUser(Users user); //string firstname, string lastname, string username, string password = null, string salt = null
        Users GetUser(string username);
        
        //void CreateCategory(Category category);
        //bool UpdateCategory(Category category);
        //bool DeleteCategory(int id);
    }
}