using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM.v1._1.Class
{
    /// <summary>
    /// Klasa koja prikazuje podatke u početnoj tablici
    /// </summary>
    public class EquipmentDataSource
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string ProjectName { get; set; }
        public string EquipmentName { get; set; }
        public string Description { get; set; }
        public string SupplierName { get; set; }
        public string SourceName { get; set; }
        public string EquipmentType { get; set; }
        public string EmployeeName { get; set; }
    }
}
