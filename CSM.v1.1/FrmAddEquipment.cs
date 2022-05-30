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
    public partial class FrmAddEquipment : Form
    {
        public FrmAddEquipment()
        {
            InitializeComponent();
        }

        private void FrmAddEquipment_Load(object sender, EventArgs e)
        {
            var foiemployees = FoiEmployeeRepository.GetFoiEmployees();
            cboFoiEmployee.DataSource = foiemployees;

            var sources = SourceRepository.GetSources();
            cboSource.DataSource = sources;

            var cipemployees = CipEmployeeRepository.GetCipEmployees();
            cboCipEmployee.DataSource = cipemployees;

            var eqiupmenttypes = EquipmentTypeRepository.GetEquipmentTypes();
            cboEquipmentType.DataSource = eqiupmenttypes;
        }



     

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmEquipment frmequipment = new FrmEquipment();
            Hide();
            frmequipment.ShowDialog();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string foiemployeename = cboFoiEmployee.SelectedItem.ToString();
            string sourcename = cboSource.SelectedItem.ToString();
            string equipmenttypename= cboEquipmentType.SelectedItem.ToString();
            string cipemployeename = cboCipEmployee.SelectedItem.ToString();

            int foiemployee=FoiEmployeeRepository.GetFoiEmployeeId(foiemployeename);
            int source = SourceRepository.GetSourceId(sourcename);
            var projectname = txtProjectName.Text;

            int equipmenttype = EquipmentTypeRepository.GetEquipmentTypeId(equipmenttypename);


            var equipmentname= txtEquipmentName.Text;
            var discription = txtDescription.Text;
            int cipemployee = CipEmployeeRepository.GetCipEmployeeId(cipemployeename); 

            EquipmentRepository.InsertEquipment(foiemployee,source,projectname,equipmentname,equipmenttype,discription,
                cipemployee);


        }

       
    }
}
