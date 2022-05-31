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
        int Choose;
       
        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            Choose = 0;
            string id = null;
            string projectname = null; ;
            string equipmentname = null; ;
            string description = null;
            FrmAddEquipment frmaddequipment = new FrmAddEquipment(Choose,id,projectname,equipmentname,description);
            Hide();
            frmaddequipment.ShowDialog();
            Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Choose = 1;
            string id = dgvEquipment.CurrentRow.Cells["Id"].Value.ToString();
            string projectname = dgvEquipment.CurrentRow.Cells["ProjectName"].Value.ToString();
            string equipmentname = dgvEquipment.CurrentRow.Cells["EquipmentName"].Value.ToString();
            string description = dgvEquipment.CurrentRow.Cells["Description"].Value.ToString();
            FrmAddEquipment frmaddequipment = new FrmAddEquipment(Choose,id,projectname,equipmentname,description);
            Hide();
            frmaddequipment.ShowDialog();
            Close();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var Search = txtSearch.Text;
            List<EquipmentDataSource> equipmentdatasources = EquipmentSearchRepository.GetEquipmentDataSources(Search);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvEquipment.CurrentRow.Cells["Id"].Value.ToString();
            EquipmentRepository.DeleteEquipment(id);
            MessageBox.Show("Uspješno ste obrisali opremu ID: : " + id, "Brisanje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowEquipment();
            
        }
    }
}
