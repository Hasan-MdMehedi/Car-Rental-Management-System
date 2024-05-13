namespace CarRental
{
    partial class Rental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rental));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rentdataGridView1 = new System.Windows.Forms.DataGridView();
            this.feestb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.priceButton = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.idtb = new System.Windows.Forms.TextBox();
            this.regbutton = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.custmrnametb = new System.Windows.Forms.TextBox();
            this.modelbutton = new System.Windows.Forms.TextBox();
            this.brandButton = new System.Windows.Forms.TextBox();
            this.available = new System.Windows.Forms.TextBox();
            this.carregcb = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rentdate = new System.Windows.Forms.DateTimePicker();
            this.returndate = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.custcb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1234, 109);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "   Rental";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1209, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 28);
            this.label2.TabIndex = 48;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(456, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 27);
            this.textBox2.TabIndex = 45;
            this.textBox2.Text = " CAR RENTAL SYSTEM ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(259, 530);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 5);
            this.panel5.TabIndex = 77;
            // 
            // rentdataGridView1
            // 
            this.rentdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentdataGridView1.Location = new System.Drawing.Point(493, 161);
            this.rentdataGridView1.Name = "rentdataGridView1";
            this.rentdataGridView1.RowHeadersWidth = 51;
            this.rentdataGridView1.RowTemplate.Height = 24;
            this.rentdataGridView1.Size = new System.Drawing.Size(708, 474);
            this.rentdataGridView1.TabIndex = 84;
            this.rentdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentdataGridView1_CellContentClick);
            // 
            // feestb
            // 
            this.feestb.Location = new System.Drawing.Point(259, 510);
            this.feestb.Name = "feestb";
            this.feestb.Size = new System.Drawing.Size(200, 22);
            this.feestb.TabIndex = 75;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(164, 634);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 34);
            this.button4.TabIndex = 83;
            this.button4.Text = "BACK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // priceButton
            // 
            this.priceButton.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceButton.Location = new System.Drawing.Point(31, 498);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(121, 34);
            this.priceButton.TabIndex = 73;
            this.priceButton.Text = "   RentFee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(758, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 82;
            this.label3.Text = " Car\'s Rent";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Location = new System.Drawing.Point(341, 564);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 34);
            this.deleteButton.TabIndex = 81;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EditButton.Location = new System.Drawing.Point(164, 564);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(137, 34);
            this.EditButton.TabIndex = 80;
            this.EditButton.Text = "EDIT";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(26, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 79;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(263, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 5);
            this.panel3.TabIndex = 78;
            // 
            // idtb
            // 
            this.idtb.Location = new System.Drawing.Point(263, 152);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(200, 22);
            this.idtb.TabIndex = 76;
            // 
            // regbutton
            // 
            this.regbutton.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbutton.Location = new System.Drawing.Point(26, 152);
            this.regbutton.Name = "regbutton";
            this.regbutton.Size = new System.Drawing.Size(121, 34);
            this.regbutton.TabIndex = 74;
            this.regbutton.Text = "        Id";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(254, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 5);
            this.panel2.TabIndex = 72;
            // 
            // custmrnametb
            // 
            this.custmrnametb.Location = new System.Drawing.Point(254, 345);
            this.custmrnametb.Name = "custmrnametb";
            this.custmrnametb.Size = new System.Drawing.Size(200, 22);
            this.custmrnametb.TabIndex = 70;
            this.custmrnametb.TextChanged += new System.EventHandler(this.custmrnametb_TextChanged);
            // 
            // modelbutton
            // 
            this.modelbutton.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelbutton.Location = new System.Drawing.Point(26, 345);
            this.modelbutton.Name = "modelbutton";
            this.modelbutton.Size = new System.Drawing.Size(121, 34);
            this.modelbutton.TabIndex = 68;
            this.modelbutton.Text = "   Name";
            // 
            // brandButton
            // 
            this.brandButton.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandButton.Location = new System.Drawing.Point(26, 276);
            this.brandButton.Name = "brandButton";
            this.brandButton.Size = new System.Drawing.Size(121, 34);
            this.brandButton.TabIndex = 67;
            this.brandButton.Text = "   CustId";
            // 
            // available
            // 
            this.available.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available.Location = new System.Drawing.Point(26, 211);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(121, 34);
            this.available.TabIndex = 86;
            this.available.Text = "  CarReg";
            // 
            // carregcb
            // 
            this.carregcb.FormattingEnabled = true;
            this.carregcb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.carregcb.Location = new System.Drawing.Point(254, 220);
            this.carregcb.Name = "carregcb";
            this.carregcb.Size = new System.Drawing.Size(200, 24);
            this.carregcb.TabIndex = 85;
            this.carregcb.SelectedIndexChanged += new System.EventHandler(this.carregcb_SelectedIndexChanged);
            this.carregcb.SelectionChangeCommitted += new System.EventHandler(this.carregcb_SelectionChangeCommitted);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 397);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 34);
            this.textBox1.TabIndex = 87;
            this.textBox1.Text = "  Rantal Date";
            // 
            // rentdate
            // 
            this.rentdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentdate.CalendarForeColor = System.Drawing.Color.OrangeRed;
            this.rentdate.CalendarMonthBackground = System.Drawing.Color.OrangeRed;
            this.rentdate.Location = new System.Drawing.Point(254, 409);
            this.rentdate.Name = "rentdate";
            this.rentdate.Size = new System.Drawing.Size(221, 22);
            this.rentdate.TabIndex = 90;
            // 
            // returndate
            // 
            this.returndate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returndate.CalendarForeColor = System.Drawing.Color.OrangeRed;
            this.returndate.CalendarMonthBackground = System.Drawing.Color.OrangeRed;
            this.returndate.Location = new System.Drawing.Point(254, 458);
            this.returndate.Name = "returndate";
            this.returndate.Size = new System.Drawing.Size(221, 22);
            this.returndate.TabIndex = 92;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 446);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 34);
            this.textBox3.TabIndex = 91;
            this.textBox3.Text = "  Return Date";
            // 
            // custcb
            // 
            this.custcb.FormattingEnabled = true;
            this.custcb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.custcb.Location = new System.Drawing.Point(254, 286);
            this.custcb.Name = "custcb";
            this.custcb.Size = new System.Drawing.Size(200, 24);
            this.custcb.TabIndex = 93;
            this.custcb.SelectionChangeCommitted += new System.EventHandler(this.custcb_SelectionChangeCommitted);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 693);
            this.Controls.Add(this.custcb);
            this.Controls.Add(this.returndate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.rentdate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.available);
            this.Controls.Add(this.carregcb);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.rentdataGridView1);
            this.Controls.Add(this.feestb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.idtb);
            this.Controls.Add(this.regbutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.custmrnametb);
            this.Controls.Add(this.modelbutton);
            this.Controls.Add(this.brandButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView rentdataGridView1;
        private System.Windows.Forms.TextBox feestb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox priceButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.TextBox regbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox custmrnametb;
        private System.Windows.Forms.TextBox modelbutton;
        private System.Windows.Forms.TextBox brandButton;
        private System.Windows.Forms.TextBox available;
        private System.Windows.Forms.ComboBox carregcb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker rentdate;
        private System.Windows.Forms.DateTimePicker returndate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox custcb;
    }
}