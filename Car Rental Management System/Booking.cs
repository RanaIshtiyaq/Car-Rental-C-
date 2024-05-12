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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        public void show()
        {
            try
            {
                queryClass.selectds("Select * from Booking");
                dgvBooking.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void hideStat()
        {
            dtReturnDate.Visible = false; label5.Visible = false;
            tbDuration.Visible=false;label1.Visible=false;
            tbAmount.Visible=false;label6.Visible=false;
            pnButons.Location = new System.Drawing.Point(129, 318);
        }
        private void ShowStat()
        {
            dtReturnDate.Visible = true; label5.Visible = true;
            tbDuration.Visible = true; label1.Visible = true;
            tbAmount.Visible = true; label6.Visible = true;
            pnButons.Location=new System.Drawing.Point(129, 465);
        }
        private void Booking_Load(object sender, EventArgs e)
        {
            show(); hideStat();
        }
        string qry;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCarName.Text == "") { MessageBox.Show("Fill the fields"); }
                else
                {
                    if (cmbStatus.Text == "Not returned")
                    {
                        qry = string.Format("Insert into Booking(Car_Name,Car_No,Client_Name,Booking_Date,Car_Status)values('" + tbCarName.Text + "','" + tbCarNo.Text + "','" + tbClientName.Text + "','" + dtBokDate.Value + "','" + cmbStatus.Text + "')");
                    }
                    else
                    {
                        qry = string.Format("Insert into Booking(Car_Name,Car_No,Client_Name,Booking_Date,Car_Status,Return_Date,Duration,Amount)values('" + tbCarName.Text + "','" + tbCarNo.Text + "','" + tbClientName.Text + "','" + dtBokDate.Value + "','" + cmbStatus.Text + "','" + dtReturnDate.Value + "','" + tbDuration.Text + "','" + tbAmount.Text + "')");
                    }
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

        private void dgvBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {try{
            queryClass.id = Convert.ToInt32(dgvBooking.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Do not select header");
            }
        }

        private void dgvBooking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
             btnSubmit.Enabled = false;
            tbCarName.Text=dgvBooking.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbCarNo.Text = dgvBooking.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbClientName.Text = dgvBooking.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtBokDate.Text = dgvBooking.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbStatus.Text = dgvBooking.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtReturnDate.Text = dgvBooking.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbDuration.Text = dgvBooking.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbAmount.Text = dgvBooking.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
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
                        string qry = string.Format("delete from Booking where ID=@i");
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
                if (queryClass.id == 0) { MessageBox.Show("Double click on record for update"); }
                else
                {
                    DialogResult iExit = MessageBox.Show("Are you sure, You want to UPDATE record", "Want Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iExit == DialogResult.Yes)
                    {
                        btnSubmit.Enabled = true;
                        string qry = string.Format("update Booking set Car_Name='" + tbCarName.Text + "',Car_No='" + tbCarNo.Text + "',Client_Name='" + tbClientName.Text + "',Booking_Date='" + dtBokDate.Value + "',Car_Status='" + cmbStatus.Text + "',Return_Date='" + dtReturnDate.Value + "',Duration='" + tbDuration.Text + "',Amount='" + tbAmount.Text + "' where ID=@i");
                        queryClass.update(qry);
                        show();
                        queryClass.clrearC(this);
                    }
                }
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }


        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "Not returned")
            {
                dtReturnDate.Value = dtReturnDate.Value.Date ;
                tbDuration.Text="0";
                tbAmount.Text = "0";
                hideStat();
            }
            else 
            { 
                ShowStat();
                
 
            }
        }

        private void dtReturnDate_ValueChanged(object sender, EventArgs e)
        {
            
            queryClass.CarName = tbCarName.Text;
            queryClass.select("Select Daily_Price from Car where Car_Name=@p");
            

            TimeSpan duration = dtReturnDate.Value - dtBokDate.Value;
            tbDuration.Text = duration.TotalDays.ToString();
            tbAmount.Text = Convert.ToString(Convert.ToDecimal(tbDuration.Text) * queryClass.pricee);
        }

        private void pbCarname_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCarname.Visible == true) dgvCarname.Visible = false;
                else
                {
                    dgvCarname.Visible = true; tbCarName.Focus();
                    queryClass.selectds("Select Car_Name,Car_No from Car");
                    dgvCarname.DataSource = queryClass.ds.Tables[0];
                }
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void dgvCarname_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbCarNo.Text = dgvCarname.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbCarName.Text = dgvCarname.Rows[e.RowIndex].Cells[0].Value.ToString();
                dgvCarname.Visible = false;
            }
            catch (Exception x) { MessageBox.Show(x.Message); }

        }

        private void pbClientName_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientName.Visible == true) dgvClientName.Visible = false;
                else
                {
                    dgvClientName.Visible = true; tbClientName.Focus();
                    queryClass.selectds("Select Client_Name from Client");
                    dgvClientName.DataSource = queryClass.ds.Tables[0];
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void dgvClientName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbClientName.Text = dgvClientName.Rows[e.RowIndex].Cells[0].Value.ToString();
                dgvClientName.Visible = false;
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                queryClass.selectds("Select * from Booking where Car_Name LIKE '%" + tbSearch.Text + "%'");
                dgvBooking.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tbCarName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                queryClass.selectds("Select Car_Name,Car_No from Car where Car_Name LIKE '%" + tbCarName.Text + "%'");
                dgvCarname.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tbCarName_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbCarNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valRegNo(e);
        }

        private void tbClientName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                queryClass.selectds("Select Client_Name from Client where Client_Name LIKE '%" + tbClientName.Text + "%'");
                dgvClientName.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tbClientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNumDec(e);
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum(e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            queryClass.clrearC(this);
        }

    }
}
