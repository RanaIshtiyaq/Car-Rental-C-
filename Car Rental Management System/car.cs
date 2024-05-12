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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }
        public void show()
        {
            try
            {
                queryClass.selectds("Select * from Car");
                dgvCar.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Car_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                    string qry = string.Format("Insert into Car(Cat_Name,Car_Name,Car_No,Insurance_No,Horse_Power,Car_Colore,Daily_Price)values('" + tbCatogeryName.Text + "','" + tbCarName.Text + "','" + tbCarNo.Text + "','" + tbInsuranceNo.Text + "','" + tbHorseP.Text + "','" + tbCarColor.Text + "','" + tbDayPrice.Text + "')");
                    queryClass.insert(qry);
                    show();
                    queryClass.clrearC(this);
                    MessageBox.Show("One record added", "Record Added", MessageBoxButtons.OK);
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
                        string qry = string.Format("delete from Car where ID=@i");
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
                if (queryClass.id == 0) { MessageBox.Show("Double click on desired record for update"); }
                else
                {
                    DialogResult iExit = MessageBox.Show("Are you sure, You want to UPDATE record", "Want Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iExit == DialogResult.Yes)
                    {
                        string qry = string.Format("update Car set Cat_Name='" + tbCatogeryName.Text + "', Car_Name='" + tbCarName.Text + "',Car_No='" + tbCarNo.Text + "',Insurance_No='" + tbInsuranceNo.Text + "',Horse_Power='" + tbHorseP.Text + "',Car_Colore='" + tbCarColor.Text + "',Daily_Price='" + tbDayPrice.Text + "' where ID=@i");
                        queryClass.update(qry);
                        show();
                        queryClass.clrearC(this);
                        btnSubmit.Enabled = true;
                    }
                }
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void dgvCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {try{
            queryClass.id = Convert.ToInt32(dgvCar.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void dgvCar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSubmit.Enabled = false;
                tbCatogeryName.Text = dgvCar.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbCarName.Text = dgvCar.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbCarNo.Text = dgvCar.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbInsuranceNo.Text = dgvCar.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbHorseP.Text = dgvCar.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbCarColor.Text = dgvCar.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbDayPrice.Text = dgvCar.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }

        }

        private void obCatName_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCatName.Visible == true) dgvCatName.Visible = false;
                else
                {
                    dgvCatName.Visible = true; tbCatogeryName.Focus();
                    queryClass.selectds("Select Cat_Name from Category");
                    dgvCatName.DataSource = queryClass.ds.Tables[0];
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }


        private void dgvCatName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbCatogeryName.Text = dgvCatName.Rows[e.RowIndex].Cells[0].Value.ToString();
                dgvCatName.Visible = false;
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void tbCatogeryName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                queryClass.selectds("Select Cat_Name from Category where Cat_Name LIKE '%" + tbCatogeryName.Text + "%'");
                dgvCatName.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tbCatogeryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbCarName_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbCarNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valRegNo(e);
        }

        private void tbInsuranceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valRegNo(e);
        }

        private void tbHorseP_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum(e);
        }

        private void tbCarColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbDayPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum(e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            queryClass.clrearC(this);
        }

        

        
    }
}
