using CSM.v1._1.Class;
using CSM.v1._1.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSM.v1._1
{
    public partial class FrmEquipment : Form
    {
        public FrmEquipment()
        {
            InitializeComponent();
        }

        private void FrmEquipment_Load(object sender, EventArgs e)
        {

            ShowEquipment();
        }

        private void ShowEquipment()
        {

         


            List<Equipment> equipments = EquipmentRepository.GetEquipments();
           
            dgvEquipment.DataSource = equipments;
           

            dgvEquipment.Columns["Id"].DisplayIndex = 0;
            

        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            FrmAddEquipment frmaddequipment = new FrmAddEquipment();
            Hide();
            frmaddequipment.ShowDialog();
            Close();
        }
    }
}
