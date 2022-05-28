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
    public partial class FrmCipEmployees : Form
    {
        public FrmCipEmployees()
        {
            InitializeComponent();
        }

        private void FrmCipEmployees_Load(object sender, EventArgs e)
        {
            ShowCipEmployees();
        }

        private void ShowCipEmployees()
        {
            List<CipEmployee> cipEmployees = CipEmployeeRepository.GetCipEmployees(); 
            dgvCipEmployees.DataSource = cipEmployees;

            dgvCipEmployees.Columns["Id"].DisplayIndex = 0;
            dgvCipEmployees.Columns["FirstName"].DisplayIndex = 1;
            dgvCipEmployees.Columns["LastName"].DisplayIndex = 2;
         
        }

    }
}
