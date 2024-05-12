namespace Car_Rental_Management_System
{
    partial class Booking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbHeading = new System.Windows.Forms.Label();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbCarNo = new System.Windows.Forms.TextBox();
            this.tbCarName = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.dtReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtBokDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.pnButons = new System.Windows.Forms.Panel();
            this.dgvCarname = new System.Windows.Forms.DataGridView();
            this.dgvClientName = new System.Windows.Forms.DataGridView();
            this.pbClientName = new System.Windows.Forms.PictureBox();
            this.pbCarname = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.pnButons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarname)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.MediumBlue;
            this.pnTop.Controls.Add(this.lbHeading);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(6);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1351, 47);
            this.pnTop.TabIndex = 19;
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.ForeColor = System.Drawing.Color.White;
            this.lbHeading.Location = new System.Drawing.Point(572, 8);
            this.lbHeading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(275, 31);
            this.lbHeading.TabIndex = 0;
            this.lbHeading.Text = "Booking Management";
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBooking.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvBooking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBooking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooking.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgvBooking.EnableHeadersVisualStyles = false;
            this.dgvBooking.GridColor = System.Drawing.Color.White;
            this.dgvBooking.Location = new System.Drawing.Point(365, 84);
            this.dgvBooking.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersVisible = false;
            this.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooking.ShowCellToolTips = false;
            this.dgvBooking.Size = new System.Drawing.Size(973, 487);
            this.dgvBooking.TabIndex = 13;
            this.dgvBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellClick);
            this.dgvBooking.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellDoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(0, 50);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 29);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(116, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 29);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(0, 2);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 29);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Client Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 301);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Return Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 344);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "No Of Days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Booking Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Car No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Car Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 391);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Total Amount";
            // 
            // tbClientName
            // 
            this.tbClientName.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientName.ForeColor = System.Drawing.Color.White;
            this.tbClientName.Location = new System.Drawing.Point(129, 171);
            this.tbClientName.Margin = new System.Windows.Forms.Padding(6);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(214, 27);
            this.tbClientName.TabIndex = 3;
            this.tbClientName.TextChanged += new System.EventHandler(this.tbClientName_TextChanged);
            this.tbClientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbClientName_KeyPress);
            // 
            // tbDuration
            // 
            this.tbDuration.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuration.ForeColor = System.Drawing.Color.White;
            this.tbDuration.Location = new System.Drawing.Point(129, 341);
            this.tbDuration.Margin = new System.Windows.Forms.Padding(6);
            this.tbDuration.MaxLength = 10;
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(214, 27);
            this.tbDuration.TabIndex = 7;
            this.tbDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDuration_KeyPress);
            // 
            // tbCarNo
            // 
            this.tbCarNo.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbCarNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarNo.ForeColor = System.Drawing.Color.White;
            this.tbCarNo.Location = new System.Drawing.Point(129, 129);
            this.tbCarNo.Margin = new System.Windows.Forms.Padding(6);
            this.tbCarNo.MaxLength = 15;
            this.tbCarNo.Name = "tbCarNo";
            this.tbCarNo.ReadOnly = true;
            this.tbCarNo.Size = new System.Drawing.Size(214, 27);
            this.tbCarNo.TabIndex = 2;
            this.tbCarNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCarNo_KeyPress);
            // 
            // tbCarName
            // 
            this.tbCarName.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarName.ForeColor = System.Drawing.Color.White;
            this.tbCarName.Location = new System.Drawing.Point(129, 84);
            this.tbCarName.Margin = new System.Windows.Forms.Padding(6);
            this.tbCarName.Multiline = true;
            this.tbCarName.Name = "tbCarName";
            this.tbCarName.Size = new System.Drawing.Size(214, 26);
            this.tbCarName.TabIndex = 1;
            this.tbCarName.TextChanged += new System.EventHandler(this.tbCarName_TextChanged);
            this.tbCarName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCarName_KeyPress);
            // 
            // tbAmount
            // 
            this.tbAmount.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.ForeColor = System.Drawing.Color.White;
            this.tbAmount.Location = new System.Drawing.Point(129, 388);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(6);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(214, 27);
            this.tbAmount.TabIndex = 8;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // dtReturnDate
            // 
            this.dtReturnDate.CalendarForeColor = System.Drawing.Color.White;
            this.dtReturnDate.CalendarMonthBackground = System.Drawing.Color.DodgerBlue;
            this.dtReturnDate.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtReturnDate.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReturnDate.Location = new System.Drawing.Point(129, 297);
            this.dtReturnDate.MaxDate = new System.DateTime(2090, 12, 31, 0, 0, 0, 0);
            this.dtReturnDate.MinDate = new System.DateTime(2019, 8, 12, 0, 0, 0, 0);
            this.dtReturnDate.Name = "dtReturnDate";
            this.dtReturnDate.Size = new System.Drawing.Size(214, 27);
            this.dtReturnDate.TabIndex = 6;
            this.dtReturnDate.ValueChanged += new System.EventHandler(this.dtReturnDate_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 258);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Status";
            // 
            // dtBokDate
            // 
            this.dtBokDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBokDate.Location = new System.Drawing.Point(129, 213);
            this.dtBokDate.Name = "dtBokDate";
            this.dtBokDate.Size = new System.Drawing.Size(214, 27);
            this.dtBokDate.TabIndex = 4;
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.White;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Returned",
            "Not returned"});
            this.cmbStatus.Location = new System.Drawing.Point(129, 255);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(214, 28);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.Text = "Not returned";
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // pnButons
            // 
            this.pnButons.Controls.Add(this.btnReset);
            this.pnButons.Controls.Add(this.btnUpdate);
            this.pnButons.Controls.Add(this.btnSubmit);
            this.pnButons.Controls.Add(this.btnDelete);
            this.pnButons.Location = new System.Drawing.Point(129, 440);
            this.pnButons.Name = "pnButons";
            this.pnButons.Size = new System.Drawing.Size(214, 79);
            this.pnButons.TabIndex = 42;
            // 
            // dgvCarname
            // 
            this.dgvCarname.AllowUserToAddRows = false;
            this.dgvCarname.AllowUserToDeleteRows = false;
            this.dgvCarname.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarname.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvCarname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCarname.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarname.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvCarname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarname.ColumnHeadersVisible = false;
            this.dgvCarname.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarname.DefaultCellStyle = dataGridViewCellStyle34;
            this.dgvCarname.GridColor = System.Drawing.Color.White;
            this.dgvCarname.Location = new System.Drawing.Point(129, 110);
            this.dgvCarname.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCarname.Name = "dgvCarname";
            this.dgvCarname.RowHeadersVisible = false;
            this.dgvCarname.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarname.ShowCellToolTips = false;
            this.dgvCarname.Size = new System.Drawing.Size(214, 214);
            this.dgvCarname.TabIndex = 44;
            this.dgvCarname.Visible = false;
            this.dgvCarname.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarname_CellClick);
            // 
            // dgvClientName
            // 
            this.dgvClientName.AllowUserToAddRows = false;
            this.dgvClientName.AllowUserToDeleteRows = false;
            this.dgvClientName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientName.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientName.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientName.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvClientName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientName.ColumnHeadersVisible = false;
            this.dgvClientName.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientName.DefaultCellStyle = dataGridViewCellStyle36;
            this.dgvClientName.GridColor = System.Drawing.Color.White;
            this.dgvClientName.Location = new System.Drawing.Point(129, 196);
            this.dgvClientName.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientName.Name = "dgvClientName";
            this.dgvClientName.RowHeadersVisible = false;
            this.dgvClientName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientName.ShowCellToolTips = false;
            this.dgvClientName.Size = new System.Drawing.Size(214, 238);
            this.dgvClientName.TabIndex = 46;
            this.dgvClientName.Visible = false;
            this.dgvClientName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientName_CellClick);
            // 
            // pbClientName
            // 
            this.pbClientName.Image = global::Car_Rental_Management_System.Properties.Resources.cmdPic;
            this.pbClientName.Location = new System.Drawing.Point(323, 173);
            this.pbClientName.Name = "pbClientName";
            this.pbClientName.Size = new System.Drawing.Size(20, 23);
            this.pbClientName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbClientName.TabIndex = 45;
            this.pbClientName.TabStop = false;
            this.pbClientName.Click += new System.EventHandler(this.pbClientName_Click);
            // 
            // pbCarname
            // 
            this.pbCarname.Image = global::Car_Rental_Management_System.Properties.Resources.cmdPic;
            this.pbCarname.Location = new System.Drawing.Point(323, 86);
            this.pbCarname.Name = "pbCarname";
            this.pbCarname.Size = new System.Drawing.Size(20, 23);
            this.pbCarname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCarname.TabIndex = 43;
            this.pbCarname.TabStop = false;
            this.pbCarname.Click += new System.EventHandler(this.pbCarname_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.Location = new System.Drawing.Point(1207, 51);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(6);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(131, 26);
            this.tbSearch.TabIndex = 12;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1064, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Search Car Name";
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(116, 50);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 29);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1351, 584);
            this.Controls.Add(this.dgvCarname);
            this.Controls.Add(this.dgvClientName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pbClientName);
            this.Controls.Add(this.dgvBooking);
            this.Controls.Add(this.pbCarname);
            this.Controls.Add(this.pnButons);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dtBokDate);
            this.Controls.Add(this.dtReturnDate);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.tbCarNo);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbCarName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.pnButons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbCarNo;
        private System.Windows.Forms.TextBox tbCarName;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.DateTimePicker dtReturnDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtBokDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel pnButons;
        private System.Windows.Forms.PictureBox pbCarname;
        private System.Windows.Forms.DataGridView dgvCarname;
        private System.Windows.Forms.PictureBox pbClientName;
        private System.Windows.Forms.DataGridView dgvClientName;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReset;
    }
}