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

         


            List<EquipmentDataSource> equipmentdatasources = EquipmentDataSourceRepository.GetEquipmentDataSources();

            //FoiEmployee employee = FoiEmployeeRepository.GetFoiEmployee();


            dgvEquipment.DataSource = equipmentdatasources;
           

            dgvEquipment.Columns["Id"].DisplayIndex = 0;
            dgvEquipment.Columns["EquipmentName"].DisplayIndex = 1;
            dgvEquipment.Columns["ProjectName"].DisplayIndex = 2;
            dgvEquipment.Columns["Description"].DisplayIndex = 3;
            dgvEquipment.Columns["EquipmentType"].DisplayIndex = 4;
            dgvEquipment.Columns["SourceName"].DisplayIndex = 5;
            dgvEquipment.Columns["DateTime"].DisplayIndex = 6;
            dgvEquipment.Columns["SupplierName"].DisplayIndex = 7;
            dgvEquipment.Columns["EmployeeName"].DisplayIndex = 8;


        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            FrmAddEquipment frmaddequipment = new FrmAddEquipment();
            Hide();
            frmaddequipment.ShowDialog();
            Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            FrmAddEquipment frmaddequipment = new FrmAddEquipment();
            Hide();
            frmaddequipment.ShowDialog();
            Close();

        }
    }
}
