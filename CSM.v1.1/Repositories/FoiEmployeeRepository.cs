using CSM.v1._1.Class;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM.v1._1.Repositories
{
    public class FoiEmployeeRepository
    {
        public static FoiEmployee GetFoiEmployee(int id)
        {
            FoiEmployee foiemployee = null;

            string sql = $"SELECT * FROM FoiEmployees WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                foiemployee = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return foiemployee;
        }

        public static List<FoiEmployee> GetFoiEmployees()
        {
            List<FoiEmployee> foiemployees = new List<FoiEmployee>();



            string sql = "SELECT * FROM FoiEmployees";

            DB.SetConfiguration("ahamzic20_DB", "ahamzic20", "pNzDysZy");

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                FoiEmployee foiemployee = CreateObject(reader);
                foiemployees.Add(foiemployee);
            }

            reader.Close();
            DB.CloseConnection();

            return foiemployees;
        }

        private static FoiEmployee CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();


            var foiemployee = new FoiEmployee
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,

            };

            return foiemployee;
        }
        public static int GetFoiEmployeeId(string foiemployeename)
        {
            int id = 0;
            var words = foiemployeename.Split(' ');
            string sql = $"SELECT Id FROM FoiEmployees WHERE  FirstName='{words[0]}' AND LastName='{words[1]}';";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                id = int.Parse(reader["Id"].ToString());
                reader.Close();
            }

            DB.CloseConnection();
            return id;
        }
    }
}
