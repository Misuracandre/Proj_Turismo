using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Dapper;
using System.Data.SqlClient;

namespace Repositories
{
    //public class CityRepository : ICityRepository
    //{
    //    private string _conn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\Documents\Exercicios_Treino\Proj_Web_API\Proj_Web_API\Mdf\dbTool.mdf";
    //    public List<City> GetAll()
    //    {
    //        List<City> list = new();
    //        using (var db = new SqlConnection(_conn))
    //        {
    //            var cities = db.Query<City>(City.GETALL);
    //            list = (List<City>)cities;
    //        }
    //        return list;
    //    }

    //    public bool Insert(City city)
    //    {
    //        using (var db = new SqlConnection(_conn))
    //        {
    //            db.Execute(City.INSERT, city);
    //        }
    //        return true;
    //    }
    //}
}
