using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM.v1._1.Class
{
    public class Equipment
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string ProjectName { get; set; }
        public int EquipmentName { get; set; }
        public string Description { get; set; }
        public int IdSupplier { get; set; }
        public int IdSource { get; set; }
        public int IdType { get; set; }
        public int IdEmployee { get; set; }

    }
}
