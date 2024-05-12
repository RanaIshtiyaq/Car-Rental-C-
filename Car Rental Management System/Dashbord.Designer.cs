namespace Car_Rental_Management_System
{
    partial class dashbord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenue = new System.Windows.Forms.Panel();
            this.btnBokiRep = new System.Windows.Forms.Button();
            this.btnCusRep = new System.Windows.Forms.Button();
            this.btnCarRep = new System.Windows.Forms.Button();
            this.btnCutomers = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnCars = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnDashord = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnDash = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlMenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenue
            // 
            this.pnlMenue.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlMenue.Controls.Add(this.btnBokiRep);
            this.pnlMenue.Controls.Add(this.btnCusRep);
            this.pnlMenue.Controls.Add(this.btnCarRep);
            this.pnlMenue.Controls.Add(this.btnCutomers);
            this.pnlMenue.Controls.Add(this.btnCategories);
            this.pnlMenue.Controls.Add(this.btnCars);
            this.pnlMenue.Controls.Add(this.btnBooking);
            this.pnlMenue.Controls.Add(this.pbLogo);
            this.pnlMenue.Controls.Add(this.btnDashord);
            this.pnlMenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenue.Location = new System.Drawing.Point(0, 0);
            this.pnlMenue.Name = "pnlMenue";
            this.pnlMenue.Size = new System.Drawing.Size(1351, 73);
            this.pnlMenue.TabIndex = 6;
            // 
            // btnBokiRep
            // 
            this.btnBokiRep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBokiRep.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBokiRep.ForeColor = System.Drawing.Color.White;
            this.btnBokiRep.Image = global::Car_Rental_Management_System.Properties.Resources.bokRepW;
            this.btnBokiRep.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBokiRep.Location = new System.Drawing.Point(965, 2);
            this.btnBokiRep.Name = "btnBokiRep";
            this.btnBokiRep.Size = new System.Drawing.Size(137, 81);
            this.btnBokiRep.TabIndex = 8;
            this.btnBokiRep.Text = "Booking Report";
            this.btnBokiRep.UseVisualStyleBackColor = true;
            this.btnBokiRep.Click += new System.EventHandler(this.btnBokiRep_Click);
            this.btnBokiRep.MouseEnter += new System.EventHandler(this.btnBokiRep_MouseEnter);
            this.btnBokiRep.MouseLeave += new System.EventHandler(this.btnBokiRep_MouseLeave);
            // 
            // btnCusRep
            // 
            this.btnCusRep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCusRep.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusRep.ForeColor = System.Drawing.Color.White;
            this.btnCusRep.Image = global::Car_Rental_Management_System.Properties.Resources.ClientRepW;
            this.btnCusRep.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCusRep.Location = new System.Drawing.Point(841, 2);
            this.btnCusRep.Name = "btnCusRep";
            this.btnCusRep.Size = new System.Drawing.Size(125, 81);
            this.btnCusRep.TabIndex = 7;
            this.btnCusRep.Text = "Client Report";
            this.btnCusRep.UseVisualStyleBackColor = true;
            this.btnCusRep.Click += new System.EventHandler(this.btnCusRep_Click);
            this.btnCusRep.MouseEnter += new System.EventHandler(this.btnCusRep_MouseEnter);
            this.btnCusRep.MouseLeave += new System.EventHandler(this.btnCusRep_MouseLeave);
            // 
            // btnCarRep
            // 
            this.btnCarRep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCarRep.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarRep.ForeColor = System.Drawing.Color.White;
            this.btnCarRep.Image = global::Car_Rental_Management_System.Properties.Resources.carReportW;
            this.btnCarRep.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCarRep.Location = new System.Drawing.Point(723, 2);
            this.btnCarRep.Name = "btnCarRep";
            this.btnCarRep.Size = new System.Drawing.Size(119, 81);
            this.btnCarRep.TabIndex = 6;
            this.btnCarRep.Text = "Car Report";
            this.btnCarRep.UseVisualStyleBackColor = true;
            this.btnCarRep.Click += new System.EventHandler(this.btnCarRep_Click);
            this.btnCarRep.MouseEnter += new System.EventHandler(this.btnCarRep_MouseEnter);
            this.btnCarRep.MouseLeave += new System.EventHandler(this.btnCarRep_MouseLeave);
            // 
            // btnCutomers
            // 
            this.btnCutomers.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCutomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCutomers.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCutomers.ForeColor = System.Drawing.Color.White;
            this.btnCutomers.Image = global::Car_Rental_Management_System.Properties.Resources.buyersW;
            this.btnCutomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCutomers.Location = new System.Drawing.Point(605, 2);
            this.btnCutomers.Name = "btnCutomers";
            this.btnCutomers.Size = new System.Drawing.Size(119, 81);
            this.btnCutomers.TabIndex = 5;
            this.btnCutomers.Text = "Client";
            this.btnCutomers.UseVisualStyleBackColor = false;
            this.btnCutomers.Click += new System.EventHandler(this.btnCutomers_Click);
            this.btnCutomers.MouseEnter += new System.EventHandler(this.btnCutomers_MouseEnter);
            this.btnCutomers.MouseLeave += new System.EventHandler(this.btnCutomers_MouseLeave);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCategories.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Image = global::Car_Rental_Management_System.Properties.Resources.carTypeW;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategories.Location = new System.Drawing.Point(487, 2);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(119, 81);
            this.btnCategories.TabIndex = 4;
            this.btnCategories.Text = "Category";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            this.btnCategories.MouseEnter += new System.EventHandler(this.btnCategories_MouseEnter);
            this.btnCategories.MouseLeave += new System.EventHandler(this.btnCategories_MouseLeave);
            // 
            // btnCars
            // 
            this.btnCars.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCars.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCars.ForeColor = System.Drawing.Color.White;
            this.btnCars.Image = global::Car_Rental_Management_System.Properties.Resources.CarW;
            this.btnCars.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCars.Location = new System.Drawing.Point(369, 2);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(119, 81);
            this.btnCars.TabIndex = 3;
            this.btnCars.Text = "Car";
            this.btnCars.UseVisualStyleBackColor = false;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            this.btnCars.MouseEnter += new System.EventHandler(this.btnCars_MouseEnter);
            this.btnCars.MouseLeave += new System.EventHandler(this.btnCars_MouseLeave);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBooking.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Image = global::Car_Rental_Management_System.Properties.Resources.CarRentW;
            this.btnBooking.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBooking.Location = new System.Drawing.Point(251, 2);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(119, 81);
            this.btnBooking.TabIndex = 2;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            this.btnBooking.MouseEnter += new System.EventHandler(this.btnBooking_MouseEnter);
            this.btnBooking.MouseLeave += new System.EventHandler(this.btnBooking_MouseLeave);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbLogo.Image = global::Car_Rental_Management_System.Properties.Resources.Car_Rental_Logo;
            this.pbLogo.Location = new System.Drawing.Point(-9, -36);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(142, 156);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnDashord
            // 
            this.btnDashord.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDashord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDashord.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashord.ForeColor = System.Drawing.Color.White;
            this.btnDashord.Image = global::Car_Rental_Management_System.Properties.Resources.homeW;
            this.btnDashord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDashord.Location = new System.Drawing.Point(133, 2);
            this.btnDashord.Name = "btnDashord";
            this.btnDashord.Size = new System.Drawing.Size(119, 81);
            this.btnDashord.TabIndex = 1;
            this.btnDashord.Text = "Dashboard";
            this.btnDashord.UseVisualStyleBackColor = false;
            this.btnDashord.Click += new System.EventHandler(this.btnDashord_Click);
            this.btnDashord.MouseEnter += new System.EventHandler(this.btnDashord_MouseEnter);
            this.btnDashord.MouseLeave += new System.EventHandler(this.btnDashord_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 666);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 24);
            this.panel1.TabIndex = 40;
            // 
            // pnDash
            // 
            this.pnDash.BackgroundImage = global::Car_Rental_Management_System.Properties.Resources.dbpic;
            this.pnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnDash.Location = new System.Drawing.Point(0, 73);
            this.pnDash.Name = "pnDash";
            this.pnDash.Size = new System.Drawing.Size(1351, 596);
            this.pnDash.TabIndex = 7;
            // 
            // dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnDash);
            this.Controls.Add(this.pnlMenue);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "dashbord";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AD CAR RENTAL\'s";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.pnlMenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnDashord;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnCutomers;
        private System.Windows.Forms.Panel pnlMenue;
        private System.Windows.Forms.Button btnCusRep;
        private System.Windows.Forms.Button btnBokiRep;
        private System.Windows.Forms.Button btnCarRep;
        private System.Windows.Forms.Panel pnDash;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

