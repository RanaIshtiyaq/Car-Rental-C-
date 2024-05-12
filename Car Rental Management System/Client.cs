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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        public void show()
        {
            try
            {
                queryClass.selectds("Select * from Client");
                dgvClient.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbClientName.Text == "") { MessageBox.Show("Fill the fields"); }
                else
                {
                    string qry = string.Format("Insert into Client(Client_Name,Cell_No,Licance_No,Age,Address)values('" + tbClientName.Text + "','" + tbCellNo.Text + "','" + tbLicanceCNIC.Text + "','" + tbage.Text + "','" + tbAddress.Text + "')");
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
                        string qry = string.Format("delete from Client where ID=@i");
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

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {try{
            queryClass.id = Convert.ToInt32(dgvClient.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void dgvClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try{

                btnSubmit.Enabled = false;
            tbClientName.Text=dgvClient.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbCellNo.Text = dgvClient.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbLicanceCNIC.Text = dgvClient.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbage.Text = dgvClient.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbAddress.Text = dgvClient.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
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
                        string qry = string.Format("update Client set Client_Name='" + tbClientName.Text + "',Cell_No='" + tbCellNo.Text + "',Licance_No='" + tbLicanceCNIC.Text + "',Age='" + tbage.Text + "',Address='" + tbAddress.Text + "' where ID=@i");
                        queryClass.update(qry);
                        show();
                        queryClass.clrearC(this);
                        btnSubmit.Enabled = true;
                    }
                }
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void tbClientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbCellNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valCell(e);
        }

        private void tbLicanceCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valCell(e);
            
        }

        private void tbage_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum(e);
        }

        private void tbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valadr(e);
        }

        private void tbLicanceCNIC_TextChanged(object sender, EventArgs e)
        {
            if (rbCnic.Checked)
                queryClass.valaCNICh(tbLicanceCNIC);
        }

        private void rbCnic_CheckedChanged(object sender, EventArgs e)
        {
            tbLicanceCNIC.Clear();
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            queryClass.clrearC(this);
        }

    }
}
