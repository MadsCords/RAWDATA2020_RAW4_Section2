using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataServiceLib
{
    public class DataService : IDataService
    {
      


        public DataService()
        {
           
        }


        //public IList<Category> GetCategories()
        //{
        //    return _categories;
        //}

        public IList<Title_Basics> GetTitles(int? userid)
        {
            var ctx = new ImdbDatabase();
            if (ctx.Users.FirstOrDefault(x => x.Userid == userid) == null)
                throw new ArgumentException("User not found");
            return ctx.Title_basics.ToList();
        }
        public Title_Basics GetTitle(int? userid, string tconst)
        {
            var ctx = new ImdbDatabase();
            if (ctx.Users.FirstOrDefault(x => x.Userid == userid) == null)
                throw new ArgumentException("User not found");
            return ctx.Title_basics.FirstOrDefault(x => x.Tconst == tconst);
        }
        public IList<Users> GetUsers()
        {
            var ctx = new ImdbDatabase();
            return ctx.Users.ToList();
        }
        public Users GetUser(string username)
        {
            var ctx = new ImdbDatabase();
            return ctx.Users.FirstOrDefault(x => x.Username == username);
        }
        public IList<Name_Basics> GetNames()
        {
            var ctx = new ImdbDatabase();
            return ctx.Names.ToList();
        }
        public IList<Users_SearchHistory> GetSearchHistory(int? userid)
        {
            var ctx = new ImdbDatabase();
            return ctx.SearchHistory.ToList();

        }
            //public IList<Name_Basics> GetNameId(int id)
            //{
            //    var ctx = new ImdbDatabase();
            //    return ctx.NameId.ToList();
            //}
            //public Category GetCategory(int id)
            //{
            //    return _categories.FirstOrDefault(x => x.Id == id);
            //}


            public Users CreateUser(Users user) //string firstname, string lastname, string username, string password = null, string salt = null
        {
            var ctx = new ImdbDatabase();

            var conn = (NpgsqlConnection)ctx.Database.GetDbConnection();
            conn.Open();
            var q = "select \"createUser\"('" + user.Username + "', '" + user.Password + "', '" + user.Firstname + "', '" + user.Lastname + "', '" + user.Birthyear + "')";
            //Console.WriteLine(q);
            var cmd = new NpgsqlCommand(q, conn);

            cmd.ExecuteNonQuery();

            return ctx.Users.FirstOrDefault(x => x.Username == user.Username);

        }
        //public Users DeleteUser(Users user)
        //{
        //    if ()
        //    {

        //    }
        //    var ctx = new ImdbDatabase();

        //    var conn = (NpgsqlConnection)ctx.Database.GetDbConnection();
        //    conn.Open();
        //    var q = "select \"createUser\"('" + user.Username + "', '" + user.Password + "', '" + user.Firstname + "', '" + user.Lastname + "', '" + user.Birthyear + "')";
        //    //Console.WriteLine(q);
        //    var cmd = new NpgsqlCommand(q, conn);

        //    cmd.ExecuteNonQuery();

        //    return ctx.Users.FirstOrDefault(x => x.Username == user.Username);

        //}
        public IList<SearchTitleFunction> SearchTitle(int userid, string searchentry)
        {
            var ctx = new ImdbDatabase();
            var result = ctx.SearchTitle.FromSqlInterpolated($"select * from string_search({userid},{searchentry})");
            //foreach (var searchTitle in result)
            //{
            //    Console.WriteLine($"{searchTitle.Tconst}, {searchTitle.PrimaryTitle}");
            //}
            return result.ToList();
        }

        public IList<StructuredSearchFunction> StructuredSearch(int userid, string entrytitle, string entryplot, string entrycharacters, string entryname)
        {
            var ctx = new ImdbDatabase();
            var result = ctx.StructuredSearch.FromSqlInterpolated($"select * from \"structured_string_search\"({userid},{entrytitle},{entryplot},{entrycharacters},{entryname})");
            //foreach (var searchTitle in result)
            //{
            //    Console.WriteLine($"{searchTitle.Tconst}, {searchTitle.PrimaryTitle}");
            //}
            return result.ToList();
        }
        //public void CreateCategory(Category category)
        //{
        //    var maxId = _categories.Max(x => x.Id);
        //    category.Id = maxId + 1;
        //    _categories.Add(category);
        //}

        //public bool UpdateCategory(Category category)
        //{ 
        //    var dbCat = GetCategory(category.Id);
        //    if (dbCat == null)
        //    {
        //        return false;
        //    }
        //    dbCat.Name = category.Name;
        //    dbCat.Description = category.Description;
        //    return true;
        //}

        //public bool DeleteCategory(int id)
        //{
        //    var dbCat = GetCategory(id);
        //    if (dbCat == null)
        //    {
        //        return false;
        //    }
        //    _categories.Remove(dbCat);
        //    return true;
        //}


        //public IList<Product> GetProducts()
        //{
        //    return _products;
        //}

        //public Product GetProduct(int id)
        //{
        //    return _products.FirstOrDefault(x => x.Id == id);
        //}


    }
}
