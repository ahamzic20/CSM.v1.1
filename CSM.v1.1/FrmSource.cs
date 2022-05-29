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
    public partial class FrmSource : Form
    {
        public FrmSource()
        {
            InitializeComponent();
        }

        private void FrmSource_Load(object sender, EventArgs e)
        {
            ShowSource();
        }

        private void ShowSource()
        {
            List<Source> sources = SourceRepository.GetSources(); 
            dgvCipEmployees.DataSource = sources;

            dgvCipEmployees.Columns["Id"].DisplayIndex = 0;
            dgvCipEmployees.Columns["Name"].DisplayIndex = 1;

         
        }

    }
}
