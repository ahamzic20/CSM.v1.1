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
    public class SourceRepository
    {

        public static Source GetSource(int id)
        {
            Source source = null;

            string sql = $"SELECT * FROM Source WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                source = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return source;
        }

        public static List<Source> GetSources()
        {
            List<Source> sources = new List<Source>();



            string sql = "SELECT * FROM Source";

            DB.SetConfiguration("ahamzic20_DB", "ahamzic20", "pNzDysZy");

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Source source= CreateObject(reader);
                sources.Add(source);
            }

            reader.Close();
            DB.CloseConnection();

            return sources;
        }

        private static Source CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string Name = reader["Name"].ToString();



            var source = new Source
            {
                Id = id,
                Name = Name,
            };

            return source;
        }

        public static int GetSourceId(string sourcename)
        {
            int id = 0;
         
            string sql = $"SELECT Id FROM Source WHERE  Name='{sourcename}'";
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
