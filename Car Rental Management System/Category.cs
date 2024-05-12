using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Management_System
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        public void show()
        {
            try
            {
                queryClass.selectds("Select * from Category");
                dgvCategory.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCatogeryName.Text == "") { MessageBox.Show("Fill the fields"); }
                else
                {
                    string qry = string.Format("Insert into Category(Cat_Name,Description)values('" + tbCatogeryName.Text + "','" + tbDescription.Text + "')");
                    queryClass.insert(qry);
                    show();
                    queryClass.clrearC(this);
                    MessageBox.Show("One record added", "Record Added", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Inser Query Problem or May Empty Field", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (queryClass.id == 0) { MessageBox.Show("Click on record for delete"); }
                else
                {
                    DialogResult iExit = MessageBox.Show("Are you sure, You want to DELETE record", "Want Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iExit == DialogResult.Yes)
                    {
                        string qry = string.Format("delete from Category where ID=@i");
                        queryClass.Delete(qry);
                        show();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (queryClass.id == 0) { MessageBox.Show("Double click on record for Update"); }
                else
                {
                    DialogResult iExit = MessageBox.Show("Are you sure, You want to UPDATE record", "Want Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iExit == DialogResult.Yes)
                    {
                        string qry = string.Format("update Category set Cat_Name='" + tbCatogeryName.Text + "', Description='" + tbDescription.Text + "' where ID=@i");
                        queryClass.update(qry);
                        show();
                        queryClass.clrearC(this);
                        btnSubmit.Enabled = true;
                    }
                }
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                queryClass.id = Convert.ToInt32(dgvCategory.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                btnSubmit.Enabled = false;
                tbCatogeryName.Text=dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbDescription.Text=dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            show();
        }

        private void tbCatogeryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valadr(e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            queryClass.clrearC(this);
        }
    }
}
