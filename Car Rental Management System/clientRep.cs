using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Reporting.WinForms;


namespace Car_Rental_Management_System
{
    public partial class clientRep : Form
    {
        public clientRep()
        {
            InitializeComponent();
        }
        private DataSet1 GetDataonload()
        {

            queryClass.con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Client ", queryClass.con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "DataTable1");
            return ds;
        }
        private DataSet1 GetData()
        {
            queryClass.con.Close();
            queryClass.con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Client where ID=@i", queryClass.con);

            cmd.Parameters.AddWithValue("@i", tbSearch.Text);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "DataTable1");
            return ds;
        }

        private void clientRep_Load(object sender, EventArgs e)
        {
            DataSet1 ds = GetDataonload(); queryClass.con.Close();
            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);

            this.reportViewer1.RefreshReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet1 ds = GetData(); queryClass.con.Close();
                ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }
    }
}
