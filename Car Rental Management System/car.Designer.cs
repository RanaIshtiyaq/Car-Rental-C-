namespace Car_Rental_Management_System
{
    partial class Car
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbHeading = new System.Windows.Forms.Label();
            this.dgvCar = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCarName = new System.Windows.Forms.TextBox();
            this.tbCatogeryName = new System.Windows.Forms.TextBox();
            this.tbCarNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHorseP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDayPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCarColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbInsuranceNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.obCatName = new System.Windows.Forms.PictureBox();
            this.dgvCatName = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obCatName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatName)).BeginInit();
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
            this.pnTop.TabIndex = 9;
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.ForeColor = System.Drawing.Color.White;
            this.lbHeading.Location = new System.Drawing.Point(617, 7);
            this.lbHeading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(217, 31);
            this.lbHeading.TabIndex = 0;
            this.lbHeading.Text = "Car Management";
            // 
            // dgvCar
            // 
            this.dgvCar.AllowUserToAddRows = false;
            this.dgvCar.AllowUserToDeleteRows = false;
            this.dgvCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCar.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvCar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCar.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCar.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCar.EnableHeadersVisualStyles = false;
            this.dgvCar.GridColor = System.Drawing.Color.White;
            this.dgvCar.Location = new System.Drawing.Point(365, 84);
            this.dgvCar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.RowHeadersVisible = false;
            this.dgvCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCar.ShowCellToolTips = false;
            this.dgvCar.Size = new System.Drawing.Size(973, 519);
            this.dgvCar.TabIndex = 11;
            this.dgvCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCar_CellClick);
            this.dgvCar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCar_CellDoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(131, 461);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 29);
            this.btnUpdate.TabIndex = 10;
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
            this.btnDelete.Location = new System.Drawing.Point(245, 407);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 29);
            this.btnDelete.TabIndex = 9;
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
            this.btnSubmit.Location = new System.Drawing.Point(131, 407);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 29);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Car Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Category Name";
            // 
            // tbCarName
            // 
            this.tbCarName.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarName.ForeColor = System.Drawing.Color.White;
            this.tbCarName.Location = new System.Drawing.Point(131, 127);
            this.tbCarName.Margin = new System.Windows.Forms.Padding(6);
            this.tbCarName.MaxLength = 15;
            this.tbCarName.Name = "tbCarName";
            this.tbCarName.Size = new System.Drawing.Size(214, 27);
            this.tbCarName.TabIndex = 2;
            this.tbCarName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCarName_KeyPress);
            // 
            // tbCatogeryName
            // 
            this.tbCatogeryName.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbCatogeryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCatogeryName.ForeColor = System.Drawing.Color.White;
            this.tbCatogeryName.Location = new System.Drawing.Point(131, 84);
            this.tbCatogeryName.Margin = new System.Windows.Forms.Padding(6);
            this.tbCatogeryName.Name = "tbCatogeryName";
            this.tbCatogeryName.Size = new System.Drawing.Size(214, 27);
            this.tbCatogeryName.TabIndex = 1;
            this.tbCatogeryName.TextChanged += new System.EventHandler(this.tbCatogeryName_TextChanged);
            this.tbCatogeryName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCatogeryName_KeyPress);
            // 
            // tbCarNo
            // 
            this.tbCarNo.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbCarNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarNo.ForeColor = System.Drawing.Color.White;
            this.tbCarNo.Location = new System.Drawing.Point(131, 170);
            this.tbCarNo.Margin = new System.Windows.Forms.Padding(6);
            this.tbCarNo.MaxLength = 15;
            this.tbCarNo.Name = "tbCarNo";
            this.tbCarNo.Size = new System.Drawing.Size(214, 27);
            this.tbCarNo.TabIndex = 3;
            this.tbCarNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCarNo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Car No";
            // 
            // tbHorseP
            // 
            this.tbHorseP.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbHorseP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHorseP.ForeColor = System.Drawing.Color.White;
            this.tbHorseP.Location = new System.Drawing.Point(131, 256);
            this.tbHorseP.Margin = new System.Windows.Forms.Padding(6);
            this.tbHorseP.MaxLength = 5;
            this.tbHorseP.Name = "tbHorseP";
            this.tbHorseP.Size = new System.Drawing.Size(214, 27);
            this.tbHorseP.TabIndex = 5;
            this.tbHorseP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHorseP_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Horse Power";
            // 
            // tbDayPrice
            // 
            this.tbDayPrice.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbDayPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDayPrice.ForeColor = System.Drawing.Color.White;
            this.tbDayPrice.Location = new System.Drawing.Point(131, 338);
            this.tbDayPrice.Margin = new System.Windows.Forms.Padding(6);
            this.tbDayPrice.MaxLength = 5;
            this.tbDayPrice.Name = "tbDayPrice";
            this.tbDayPrice.Size = new System.Drawing.Size(214, 27);
            this.tbDayPrice.TabIndex = 7;
            this.tbDayPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDayPrice_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 341);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Daily Price";
            // 
            // tbCarColor
            // 
            this.tbCarColor.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbCarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarColor.ForeColor = System.Drawing.Color.White;
            this.tbCarColor.Location = new System.Drawing.Point(131, 298);
            this.tbCarColor.Margin = new System.Windows.Forms.Padding(6);
            this.tbCarColor.MaxLength = 15;
            this.tbCarColor.Name = "tbCarColor";
            this.tbCarColor.Size = new System.Drawing.Size(214, 27);
            this.tbCarColor.TabIndex = 6;
            this.tbCarColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCarColor_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 301);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Car Color";
            // 
            // tbInsuranceNo
            // 
            this.tbInsuranceNo.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbInsuranceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInsuranceNo.ForeColor = System.Drawing.Color.White;
            this.tbInsuranceNo.Location = new System.Drawing.Point(131, 212);
            this.tbInsuranceNo.Margin = new System.Windows.Forms.Padding(6);
            this.tbInsuranceNo.MaxLength = 30;
            this.tbInsuranceNo.Name = "tbInsuranceNo";
            this.tbInsuranceNo.Size = new System.Drawing.Size(214, 27);
            this.tbInsuranceNo.TabIndex = 4;
            this.tbInsuranceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInsuranceNo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Insurance no";
            // 
            // obCatName
            // 
            this.obCatName.Image = global::Car_Rental_Management_System.Properties.Resources.cmdPic;
            this.obCatName.Location = new System.Drawing.Point(325, 86);
            this.obCatName.Name = "obCatName";
            this.obCatName.Size = new System.Drawing.Size(20, 25);
            this.obCatName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.obCatName.TabIndex = 45;
            this.obCatName.TabStop = false;
            this.obCatName.Click += new System.EventHandler(this.obCatName_Click);
            // 
            // dgvCatName
            // 
            this.dgvCatName.AllowUserToAddRows = false;
            this.dgvCatName.AllowUserToDeleteRows = false;
            this.dgvCatName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatName.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvCatName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatName.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatName.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvCatName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatName.ColumnHeadersVisible = false;
            this.dgvCatName.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatName.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvCatName.EnableHeadersVisualStyles = false;
            this.dgvCatName.GridColor = System.Drawing.Color.White;
            this.dgvCatName.Location = new System.Drawing.Point(131, 111);
            this.dgvCatName.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCatName.Name = "dgvCatName";
            this.dgvCatName.RowHeadersVisible = false;
            this.dgvCatName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatName.ShowCellToolTips = false;
            this.dgvCatName.Size = new System.Drawing.Size(214, 225);
            this.dgvCatName.TabIndex = 47;
            this.dgvCatName.Visible = false;
            this.dgvCatName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatName_CellClick);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(247, 461);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 29);
            this.btnReset.TabIndex = 48;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1351, 616);
            this.Controls.Add(this.dgvCatName);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.obCatName);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.dgvCar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInsuranceNo);
            this.Controls.Add(this.tbCarColor);
            this.Controls.Add(this.tbDayPrice);
            this.Controls.Add(this.tbHorseP);
            this.Controls.Add(this.tbCarNo);
            this.Controls.Add(this.tbCarName);
            this.Controls.Add(this.tbCatogeryName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Car";
            this.Text = "car";
            this.Load += new System.EventHandler(this.Car_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obCatName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.DataGridView dgvCar;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCarName;
        private System.Windows.Forms.TextBox tbCatogeryName;
        private System.Windows.Forms.TextBox tbCarNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHorseP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDayPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCarColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbInsuranceNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox obCatName;
        private System.Windows.Forms.DataGridView dgvCatName;
        private System.Windows.Forms.Button btnReset;


    }
}