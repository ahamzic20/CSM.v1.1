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

            ShowEquipment();
        }

        private void ShowEquipment()
        {

          
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
            int foiemployee =(int) numFoiEmployee.Value;
            int source = (int)numSource.Value;
            var projectname = txtProjectName.Text;
            int equipmenttype= (int)numEquipmenType.Value;
            var equipmentname= txtEquipmentName.Text;
            var discription = txtDescription.Text;
            int cipemployee = (int)numCipEmployee.Value;
            EquipmentRepository.InsertEquipment(foiemployee,source,projectname,equipmentname,equipmenttype,discription,
                cipemployee);


        }

        private void cboFoiEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            var FoiEmployee = cboFoiEmployee.SelectedItem as FoiEmployee;
            
        }
    }
}
