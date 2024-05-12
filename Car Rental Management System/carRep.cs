using Microsoft.Reporting.WinForms;
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
    public partial class carRep : Form
    {
        public carRep()
        {
            InitializeComponent();
        }
        private DataSet2 GetDataonload()
        {

            queryClass.con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Car ", queryClass.con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet2 ds = new DataSet2();
            da.Fill(ds, "DataTable1");
            return ds;
        }
        private DataSet2 GetData()
        {
            queryClass.con.Close();
            queryClass.con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Car where ID=@i", queryClass.con);

            cmd.Parameters.AddWithValue("@i", tbSearch.Text);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet2 ds = new DataSet2();
            da.Fill(ds, "DataTable1");
            return ds;
        }
        private void carRep_Load(object sender, EventArgs e)
        {
            DataSet2 ds = GetDataonload(); queryClass.con.Close();
            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet2 ds = GetData(); queryClass.con.Close();
                ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }
    }
}
