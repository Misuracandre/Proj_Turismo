using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public class HotelService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\Documents\Exercicios_Treino\Proj_Web_API\Proj_Web_API\Mdf\dbTool.mdf";
        readonly SqlConnection conn;
        //private ICityRepository _cityRepository;

        public HotelService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            //_cityRepository = new CityRepository();
        }

        public bool Insert(Hotel hotel)
        {
            bool status = false;

            try
            {
                string strInsert = "insert into City (Name, IdAddress, Value)" + "values (@Name, @IdAddress, @Value); select cast(scope_identity() as int)";
                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Name", hotel.Name));
                commandInsert.Parameters.Add(new SqlParameter("@IdAddress", InsertAddress(hotel.Address).Id));
                commandInsert.Parameters.Add(new SqlParameter("@Value", hotel.Value));

                commandInsert.ExecuteScalar();
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

        public Address InsertAddress(Address address)
        {
            bool status = false;

            try
            {
                string strInsert = "insert into City (Street, Number, Neighborhood, ZipCode, Unit, IdCity)" + "values (@Street, @Number, @Neighborhood, @ZipCode, @Extension, @IdCity); select cast(scope_identity() as int)";
                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Description", address.Street));
                commandInsert.Parameters.Add(new SqlParameter("@Number", address.Number));
                commandInsert.Parameters.Add(new SqlParameter("@Neighborhood", address.Neighborhood));
                commandInsert.Parameters.Add(new SqlParameter("@ZipCode", address.ZipCode));
                commandInsert.Parameters.Add(new SqlParameter("@Unit", address.Unit));
                commandInsert.Parameters.Add(new SqlParameter("@IdCity", InsertCity(address.City).Id));

                address.Id = commandInsert.ExecuteNonQuery();
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
            return address;
        }

        public City InsertCity(City city)
        {
            bool status = false;

            try
            {
                string strInsert = "insert into City (Description)" + "values (@Description); select cast(scope_identity() as int";
                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Description", city.Description));

                city.Id = commandInsert.ExecuteNonQuery();
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
            return city;
        }
    }
}
