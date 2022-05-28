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
    public class CipEmployeeRepository
    {
        public static CipEmployee GetCipEmployee(int id)
        {
            CipEmployee cipemployee = null;

            string sql = $"SELECT * FROM CipEmployees WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                cipemployee = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return cipemployee;
        }

        public static List<CipEmployee> GetCipEmployees()
        {
            List <CipEmployee> cipemployees = new List<CipEmployee>();



            string sql = "SELECT * FROM CipEmployees";

            DB.SetConfiguration("ahamzic20_DB", "ahamzic20", "pNzDysZy");

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                CipEmployee cipemployee = CreateObject(reader);
                cipemployees.Add(cipemployee);
            }

            reader.Close();
            DB.CloseConnection();

            return cipemployees;
        }

        private static CipEmployee CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            

            var cipemployee = new CipEmployee
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
               
            };

            return cipemployee;
        }
    }
}
