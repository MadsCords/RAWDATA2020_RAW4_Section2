using System.Collections.Generic;

namespace DataServiceLib
{
    public interface IDataService
    {
        IList<TitleBasicsList> GetTitles(int page, int pageSize);
        int NumberOfMovies();
        int NumberOfActors();
        Title_Basics GetTitle(int? userid, string tconst);
        IList<Users> GetUsers();
        //IList<Users> GetUserId(int id);
        IList<Name_Basics> GetNames(int page, int pageSize);
        IList<Users_SearchHistory> GetSearchHistory(int? userid);
        //IList<Name_Basics> GetNameId(int id);
        IList<SearchTitleFunction> SearchTitle(int userid, string searchentry, int page, int pageSize);
        IList<SearchActorFunction> SearchActor(string searchentry);
        IList<StructuredSearchFunction> StructuredSearch(int userid, string entrytitle, string entryplot, string entrycharacters, string entryname);
        //Product GetProduct(int id);
        Users CreateUser(Users user); // = null, string salt = null
        Users GetUser(string username, int userid);
        IList<Users_SearchHistory> GetSearchHistory(int userid);
    }
}