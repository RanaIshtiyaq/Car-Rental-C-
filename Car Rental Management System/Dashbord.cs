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
    public partial class dashbord : Form
    {
        public dashbord()
        {
            InitializeComponent();
        }

        public void showForm(Form f)
        {
            pnDash.Controls.Clear();
            f.TopLevel = false;
            pnDash.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
        }

        private void btnBooking_MouseEnter(object sender, EventArgs e)
        {
            btnBooking.Image = Properties.Resources.carRentalRed;
            btnBooking.ForeColor = Color.Red;
        }


        private void btnDashord_MouseEnter(object sender, EventArgs e)
        {
          btnDashord.Image = Properties.Resources.homeR;
          btnDashord.ForeColor = Color.Red;
        }

        private void btnDashord_MouseLeave(object sender, EventArgs e)
        {
            btnDashord.Image = Properties.Resources.homeW;
            btnDashord.ForeColor = Color.White;
        }

        private void btnBooking_MouseLeave(object sender, EventArgs e)
        {
            btnBooking.Image = Properties.Resources.CarRentW;
            btnBooking.ForeColor = Color.White;
        }

        private void btnCars_MouseEnter(object sender, EventArgs e)
        {
            btnCars.Image = Properties.Resources.CarR;
            btnCars.ForeColor = Color.Red;
        }

        private void btnCars_MouseLeave(object sender, EventArgs e)
        {
            btnCars.Image = Properties.Resources.CarW;
            btnCars.ForeColor = Color.White;
        }

        private void btnCategories_MouseEnter(object sender, EventArgs e)
        {
            btnCategories.Image = Properties.Resources.carTypeR;
            btnCategories.ForeColor = Color.Red;
        }

        private void btnCategories_MouseLeave(object sender, EventArgs e)
        {
            btnCategories.Image = Properties.Resources.carTypeW;
            btnCategories.ForeColor = Color.White;
        }

        private void btnCutomers_MouseEnter(object sender, EventArgs e)
        {
            btnCutomers.Image = Properties.Resources.buyersR;
            btnCutomers.ForeColor = Color.Red;
        }

        private void btnCutomers_MouseLeave(object sender, EventArgs e)
        {
            btnCutomers.Image = Properties.Resources.buyersW;
            btnCutomers.ForeColor = Color.White;
        }

        private void btnCarRep_MouseEnter(object sender, EventArgs e)
        {
            btnCarRep.Image = Properties.Resources.carReportR;
            btnCarRep.ForeColor = Color.Red;
        }

        private void btnCarRep_MouseLeave(object sender, EventArgs e)
        {
            btnCarRep.Image = Properties.Resources.carReportW;
            btnCarRep.ForeColor = Color.White;
        }

        private void btnCusRep_MouseEnter(object sender, EventArgs e)
        {
            btnCusRep.Image = Properties.Resources.ClientRepR;
            btnCusRep.ForeColor = Color.Red;
        }

        private void btnCusRep_MouseLeave(object sender, EventArgs e)
        {
            btnCusRep.Image = Properties.Resources.ClientRepW;
            btnCusRep.ForeColor = Color.White;
        }

        private void btnBokiRep_MouseEnter(object sender, EventArgs e)
        {
            btnBokiRep.Image = Properties.Resources.bokRepR;
            btnBokiRep.ForeColor = Color.Red;
        }

        private void btnBokiRep_MouseLeave(object sender, EventArgs e)
        {
            btnBokiRep.Image = Properties.Resources.bokRepW;
            btnBokiRep.ForeColor = Color.White;
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            showForm(cat);
        }

        private void btnDashord_Click(object sender, EventArgs e)
        {
            pnDash.Controls.Clear();
            pnDash.BackgroundImage = Properties.Resources.dbpic;
            
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            Car cr = new Car();
            showForm(cr);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Booking bk = new Booking();
            showForm(bk);
        }

        private void btnCutomers_Click(object sender, EventArgs e)
        {
            Client cl = new Client();
            showForm(cl);
        }

        private void btnCarRep_Click(object sender, EventArgs e)
        {
            carRep cr = new carRep();
            showForm(cr);
        }

        private void btnCusRep_Click(object sender, EventArgs e)
        {
            clientRep clrep = new clientRep();
            showForm(clrep);
        }

        private void btnBokiRep_Click(object sender, EventArgs e)
        {
            BookRep br = new BookRep();
            showForm(br);
        }
    }
}
