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
        int choose;
        string selectedId;
        string Projectname;
        string Equipmentname;
        string Description;
        public FrmAddEquipment(int id, string Id, string projectname, string equipmentname,  string description)
        {
            choose = id;
            selectedId = Id;
            Projectname = projectname;
            Equipmentname = equipmentname;
            Description = description;
            InitializeComponent();
        }

        private void FrmAddEquipment_Load(object sender, EventArgs e)
        {
            if (choose == 0) { 
            var foiemployees = FoiEmployeeRepository.GetFoiEmployees();
            cboSupplier.DataSource = foiemployees;

            var sources = SourceRepository.GetSources();
            cboSource.DataSource = sources;

            var cipemployees = CipEmployeeRepository.GetCipEmployees();
            cboEmployee.DataSource = cipemployees;

            var eqiupmenttypes = EquipmentTypeRepository.GetEquipmentTypes();
            cboEquipmentType.DataSource = eqiupmenttypes;
            }
            else if(choose==1)
            {


                int supplierid = FoiEmployeeRepository.GetCurrentId(selectedId);
                var foiemployees = FoiEmployeeRepository.GetFoiEmployees();
                cboSupplier.DataSource = foiemployees;
                cboSupplier.SelectedIndex = supplierid-1;

                
                int sourceid = SourceRepository.GetCurrentId(selectedId);
                var sources = SourceRepository.GetSources();
                cboSource.DataSource = sources;
                cboSource.SelectedIndex = sourceid - 1;


                int employeeid = CipEmployeeRepository.GetCurrentId(selectedId);
                var cipemployees = CipEmployeeRepository.GetCipEmployees();
                cboEmployee.DataSource = cipemployees;
                cboEmployee.SelectedIndex = employeeid - 1;

                int eqiupmenttypeid = EquipmentTypeRepository.GetCurrentId(selectedId);
                var eqiupmenttypes = EquipmentTypeRepository.GetEquipmentTypes();
                cboEquipmentType.DataSource = eqiupmenttypes;
                cboEquipmentType.SelectedIndex = eqiupmenttypeid-1;

                txtDescription.Text = Description;
                txtEquipmentName.Text = Equipmentname;
                txtProjectName.Text = Projectname;

                
                
            }
            txtDate.Text = DateTime.Now.ToString();
            
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
            string foiemployeename = cboSupplier.SelectedItem.ToString();
            //
            string sourcename = cboSource.SelectedItem.ToString();
            string equipmenttypename= cboEquipmentType.SelectedItem.ToString();
            string cipemployeename = cboEmployee.SelectedItem.ToString();

            int foiemployee = FoiEmployeeRepository.GetFoiEmployeeId(foiemployeename);
            //
            int source = SourceRepository.GetSourceId(sourcename);
            var projectname = txtProjectName.Text;

            int equipmenttype = EquipmentTypeRepository.GetEquipmentTypeId(equipmenttypename);


            var equipmentname= txtEquipmentName.Text;
            var discription = txtDescription.Text;
            int cipemployee = CipEmployeeRepository.GetCipEmployeeId(cipemployeename);

            if (choose == 0) {
               
                if (string.IsNullOrEmpty(equipmentname) || string.IsNullOrEmpty(projectname) || string.IsNullOrEmpty(Description))
                {
                    
                    MessageBox.Show("Nisu uneseni svi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    EquipmentRepository.InsertEquipment(foiemployee, source, projectname, equipmentname, equipmenttype, discription,
                        cipemployee);

                    FrmEquipment frmequipment = new FrmEquipment();
                    Hide();
                    frmequipment.ShowDialog();
                    Close();


                }
            }
            else if (choose == 1)
            {
              
                    EquipmentRepository.UpdateEquipment(foiemployee, source, projectname, equipmentname, equipmenttype, discription,
                cipemployee, selectedId );
                    FrmEquipment frmequipment = new FrmEquipment();
                    Hide();
                    frmequipment.ShowDialog();
                    Close();
               

            }
           
            

        }

       
    }
}
