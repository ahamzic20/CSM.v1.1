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
    public class EquipmentDataSourceRepository
    {

        public static EquipmentDataSource GetEquipmentDataSource(int id)
        {
            EquipmentDataSource equipmentdatasource = null;

            string sql = $"SELECT * FROM Equipment WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                equipmentdatasource = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return equipmentdatasource;
        }

        public static List<EquipmentDataSource> GetEquipmentDataSources()
        {
            //SELECT e.Id, e.DateTime, e.ProjectName, e.EquipmentName, e.Description,
            //(c.FirstName + '' + c.LastName) AS SupplierName,
            //s.Name,
            //et.Name,
            //(f.FirstName + '' + f.LastName) AS EmployeeName
            //FROM Equipment e
            //JOIN CipEmployees c ON e.IdSupplier = c.Id
            //JOIN Source s ON e.IdSource = s.Id
            //JOIN EquipmentType et ON e.IdType = et.Id
            //JOIN FoiEmployees f ON e.IdEmployee = f.Id

            List<EquipmentDataSource> equipmentdatasources = new List<EquipmentDataSource>();


            string sql = $"SELECT e.Id, e.DateTime, e.ProjectName, e.EquipmentName, e.Description,(c.FirstName + ' ' + c.LastName) AS SupplierName,s.Name AS SourceName,et.Name AS EquipmentType,(f.FirstName + ' ' + f.LastName) AS EmployeeName FROM Equipment e JOIN CipEmployees c ON e.IdSupplier = c.Id JOIN Source s ON e.IdSource = s.Id JOIN EquipmentType et ON e.IdType = et.Id JOIN FoiEmployees f ON e.IdEmployee = f.Id";

            DB.SetConfiguration("ahamzic20_DB", "ahamzic20", "pNzDysZy");

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                EquipmentDataSource equipmentdatasource = CreateObject(reader);
                equipmentdatasources.Add(equipmentdatasource);
            }

            reader.Close();
            DB.CloseConnection();

            return equipmentdatasources;

        }


        private static EquipmentDataSource CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            DateTime dateTime = DateTime.Parse(reader["DateTime"].ToString());
            string projectName = reader["ProjectName"].ToString();
            string equipmentName = reader["EquipmentName"].ToString();
            string description = reader["Description"].ToString();
            string suppliername = reader["SupplierName"].ToString();
            string sourcename = reader["SourceName"].ToString();
            string equipmenttype = reader["EquipmentType"].ToString(); ;
            string employeename = reader["EmployeeName"].ToString();


            var equipmentdatasource = new EquipmentDataSource
            {
                Id = id,
                DateTime = dateTime,
                ProjectName = projectName,
                Description = description,
                EquipmentName = equipmentName,
                SupplierName = suppliername,
                SourceName = sourcename,
                EquipmentType= equipmenttype,
                EmployeeName= employeename

            };

            return equipmentdatasource;
        }






    }
}
