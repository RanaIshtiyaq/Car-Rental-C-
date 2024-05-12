using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = string.Format("select * from admin where userName='" + tbUserName.Text + "' AND Pasword='" + tbPasword.Text + "' ");
                queryClass.con.Open();
                OleDbCommand cmd = new OleDbCommand(qry, queryClass.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    dashbord db = new dashbord();
                    db.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }

                queryClass.con.Close();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm You Want to Close Login Form", "Close Login Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
                this.Close();
        }
    }
}
