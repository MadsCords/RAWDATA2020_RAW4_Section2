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
        IList<Name_Basics> GetNames(int page, int pageSize);
        IList<Users_SearchHistory> GetSearchHistory(int? userid);
        IList<SearchTitleFunction> SearchTitle(int userid, string searchentry, int page, int pageSize);
        IList<SearchActorFunction> SearchActor(string searchentry);
        IList<StructuredSearchFunction> StructuredSearch(int userid, string entrytitle, string entryplot, string entrycharacters, string entryname);
        Users CreateUser(Users user);
        Users GetUser(string username, string password);
        IList<Users_SearchHistory> GetSearchHistory(int userid);
    }
}