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
            // TODO: This line of code loads data into the 'dataSet1.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.dataSet1.Equipment);

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
