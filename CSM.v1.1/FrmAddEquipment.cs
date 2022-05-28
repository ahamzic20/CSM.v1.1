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
    }
}
