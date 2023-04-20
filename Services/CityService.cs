using System.Data.SqlClient;
using Models;
using Repositories;

namespace Services
{
    public class CityService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\Documents\Exercicios_Treino\Proj_Web_API\Proj_Web_API\Mdf\dbTool.mdf";
        readonly SqlConnection conn;
        //private ICityRepository _cityRepository;

        public CityService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            //_cityRepository = new CityRepository();
        }

        public bool Insert(City city)
        {
            bool status = false;

            try
            {
                string strInsert = "insert into City (Description)" + "values (@Description); select cast(scope_identity() as int";
                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Description", city.Description));

                commandInsert.ExecuteNonQuery();
                status = true;
            }
            catch (Exception)
            {
                status = false;
                throw;
            }
            finally
            {
                conn.Close();
            }
            return status;
        }
    }
}