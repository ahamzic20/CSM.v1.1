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
    public partial class FrmLogin : Form
    {
        string username = "nastavnik";
        string password = "test";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Niste unjeli korisničko ime!", "Pogreška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Niste unjeli lozinku!", "Pogreška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (txtUsername.Text == username && txtPassword.Text == password)
                {
                    MessageBox.Show("Dobrodošli!", "Prijavljeni ste",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmEquipment frmCip = new FrmEquipment(); // na sljedecu formu
                    Hide();
                    frmCip.ShowDialog(); //
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
