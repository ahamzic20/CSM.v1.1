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
    public class EquipmentTypeRepository
    {
        public static EquipmentType GetEquipmentType(int id)
        {
            EquipmentType equipmentType = null;

            string sql = $"SELECT * FROM EquipmentType WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                equipmentType = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return equipmentType;
        }

        public static List<EquipmentType> GetEquipmentTypes()
        {
            List<EquipmentType> equipmentTypes = new List<EquipmentType>();



            string sql = "SELECT * FROM EquipmentType";

            DB.SetConfiguration("ahamzic20_DB", "ahamzic20", "pNzDysZy");

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                EquipmentType equipmentType = CreateObject(reader);
                equipmentTypes.Add(equipmentType);
            }

            reader.Close();
            DB.CloseConnection();

            return equipmentTypes;
        }

        private static EquipmentType CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string Name = reader["Name"].ToString();
         


            var equipmentType = new EquipmentType
            {
                Id = id,
                Name = Name,
            };

            return equipmentType;
        }
    }
}
