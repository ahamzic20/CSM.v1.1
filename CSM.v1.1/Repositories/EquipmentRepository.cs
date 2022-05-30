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
    public class EquipmentRepository
    {
        public static Equipment GetEquipment(int id)
        {
            Equipment equipment = null;

            string sql = $"SELECT * FROM Equipment WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                equipment = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return equipment;
        }

        public static List<Equipment> GetEquipments()
        {
            List<Equipment> equipments = new List<Equipment>();
            
            

            string sql = "SELECT * FROM Equipment";

            DB.SetConfiguration("ahamzic20_DB", "ahamzic20", "pNzDysZy");

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Equipment equipment = CreateObject(reader);
                equipments.Add(equipment);
            }

            reader.Close();
            DB.CloseConnection();

            return equipments;
        }

       

        private static Equipment CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            DateTime dateTime = DateTime.Parse(reader["DateTime"].ToString());
            string projectName = reader["ProjectName"].ToString();
            string equipmentName = reader["EquipmentName"].ToString();
            string description = reader["Description"].ToString();
            int idSupplier = int.Parse(reader["IdSupplier"].ToString());
            int idSource = int.Parse(reader["IdSource"].ToString());
            int idType = int.Parse(reader["IdType"].ToString());
            int idEmployee = int.Parse(reader["IdEmployee"].ToString());


            var equipment = new Equipment
            {
                Id = id,
                DateTime = dateTime,
                ProjectName = projectName, 
                Description = description,
                IdSupplier = idSupplier,
                IdSource = idSource,
                IdType = idType,
                EquipmentName = equipmentName,
                IdEmployee = idEmployee,
                

            };

            return equipment;
        }
        public static void InsertEquipment(int foiemployee, int source, string projectname, string equipmentname, int equipmenttype, string description,
              int  cipemployee)
        {
            string sql = $"INSERT INTO  Equipment (DateTime,ProjectName,EquipmentName,Description,IdSupplier,IdSource,IdType,IdEmployee) VALUES (GETDATE(),'{projectname}','{equipmentname}','{description}',{cipemployee},{source},{equipmenttype},{foiemployee})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }




    }
}

