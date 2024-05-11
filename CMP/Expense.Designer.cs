namespace CMP
{
    partial class Expense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expense));
            this.shto_exp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.data_exp = new System.Windows.Forms.Label();
            this.exp_date = new System.Windows.Forms.DateTimePicker();
            this.exp_cat = new System.Windows.Forms.ComboBox();
            this.exp = new System.Windows.Forms.Label();
            this.exp_desc = new System.Windows.Forms.TextBox();
            this.desc_exp = new System.Windows.Forms.Label();
            this.exp_amount = new System.Windows.Forms.TextBox();
            this.sasia_exp = new System.Windows.Forms.Label();
            this.exp_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.view_ex = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.expens = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.view_inc = new System.Windows.Forms.Label();
            this.income = new System.Windows.Forms.Label();
            this.dashboard = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // shto_exp
            // 
            this.shto_exp.AutoSize = true;
            this.shto_exp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shto_exp.ForeColor = System.Drawing.Color.SeaGreen;
            this.shto_exp.Location = new System.Drawing.Point(767, 662);
            this.shto_exp.Name = "shto_exp";
            this.shto_exp.Size = new System.Drawing.Size(215, 34);
            this.shto_exp.TabIndex = 66;
            this.shto_exp.Text = "Shtoni shpenzimin";
            this.shto_exp.UseVisualStyleBackColor = true;
            this.shto_exp.Click += new System.EventHandler(this.shto_exp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(947, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 105);
            this.panel2.TabIndex = 65;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(47, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 24);
            this.label15.TabIndex = 50;
            this.label15.Text = "TotalExpense";
            // 
            // data_exp
            // 
            this.data_exp.AutoSize = true;
            this.data_exp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_exp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.data_exp.Location = new System.Drawing.Point(947, 307);
            this.data_exp.Name = "data_exp";
            this.data_exp.Size = new System.Drawing.Size(52, 24);
            this.data_exp.TabIndex = 64;
            this.data_exp.Text = "Data";
            // 
            // exp_date
            // 
            this.exp_date.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_date.Location = new System.Drawing.Point(942, 337);
            this.exp_date.Name = "exp_date";
            this.exp_date.Size = new System.Drawing.Size(242, 30);
            this.exp_date.TabIndex = 63;
            // 
            // exp_cat
            // 
            this.exp_cat.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_cat.FormattingEnabled = true;
            this.exp_cat.Items.AddRange(new object[] {
            "Qira",
            "Shërbimet komunale",
            "Blerje per shtepine",
            "Karburant",
            "Transporti publik",
            "Mirëmbajtja e automjeteve",
            "Ushqime",
            "Restorante",
            "Pagesa e vizitave",
            "Blerja e ilaceve",
            "Filmat",
            "Koncerte",
            "Abonime",
            "Pajisje tualeti",
            "Prerje flokësh",
            "Veshje",
            "Kurse arsimore",
            "librat",
            "Mjetet shkollore",
            "Shlyerje borxhi",
            "Blerje me karte",
            "Kreditë",
            "Kursimet",
            "Overdraft",
            "Fondi i Emergjencave",
            "Dhurata dhe Donacione",
            "Dhurata per ditelindje",
            "Donacione bamirësie",
            "Ditëlindjet",
            "Dasma",
            "Udhëtim"});
            this.exp_cat.Location = new System.Drawing.Point(951, 248);
            this.exp_cat.Name = "exp_cat";
            this.exp_cat.Size = new System.Drawing.Size(224, 28);
            this.exp_cat.TabIndex = 62;
            // 
            // exp
            // 
            this.exp.AutoSize = true;
            this.exp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.exp.Location = new System.Drawing.Point(947, 210);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(51, 24);
            this.exp.TabIndex = 61;
            this.exp.Text = "Lloji";
            // 
            // exp_desc
            // 
            this.exp_desc.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_desc.Location = new System.Drawing.Point(606, 484);
            this.exp_desc.Multiline = true;
            this.exp_desc.Name = "exp_desc";
            this.exp_desc.Size = new System.Drawing.Size(219, 131);
            this.exp_desc.TabIndex = 60;
            // 
            // desc_exp
            // 
            this.desc_exp.AutoSize = true;
            this.desc_exp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_exp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.desc_exp.Location = new System.Drawing.Point(602, 443);
            this.desc_exp.Name = "desc_exp";
            this.desc_exp.Size = new System.Drawing.Size(110, 24);
            this.desc_exp.TabIndex = 59;
            this.desc_exp.Text = "Pershkrimi";
            // 
            // exp_amount
            // 
            this.exp_amount.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_amount.Location = new System.Drawing.Point(606, 363);
            this.exp_amount.Name = "exp_amount";
            this.exp_amount.Size = new System.Drawing.Size(219, 34);
            this.exp_amount.TabIndex = 58;
            // 
            // sasia_exp
            // 
            this.sasia_exp.AutoSize = true;
            this.sasia_exp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sasia_exp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sasia_exp.Location = new System.Drawing.Point(602, 322);
            this.sasia_exp.Name = "sasia_exp";
            this.sasia_exp.Size = new System.Drawing.Size(56, 24);
            this.sasia_exp.TabIndex = 57;
            this.sasia_exp.Text = "Sasia";
            // 
            // exp_name
            // 
            this.exp_name.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_name.Location = new System.Drawing.Point(606, 251);
            this.exp_name.Name = "exp_name";
            this.exp_name.Size = new System.Drawing.Size(219, 34);
            this.exp_name.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(602, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 24);
            this.label10.TabIndex = 55;
            this.label10.Text = "Emri i shpenzimit";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(1325, 12);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(81, 50);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 54;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(771, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 46);
            this.label9.TabIndex = 53;
            this.label9.Text = "Detajet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(351, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(309, 54);
            this.label8.TabIndex = 52;
            this.label8.Text = "Shpenzimet";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(6, 55);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(82, 77);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Location = new System.Drawing.Point(94, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 54);
            this.label7.TabIndex = 17;
            this.label7.Text = "CMP";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(10, 418);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 51);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(13, 361);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 297);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.view_ex);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.expens);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.view_inc);
            this.panel1.Controls.Add(this.income);
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 742);
            this.panel1.TabIndex = 51;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(45, 677);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(51, 51);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // view_ex
            // 
            this.view_ex.AutoSize = true;
            this.view_ex.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.view_ex.ForeColor = System.Drawing.Color.DarkGreen;
            this.view_ex.Location = new System.Drawing.Point(66, 429);
            this.view_ex.Name = "view_ex";
            this.view_ex.Size = new System.Drawing.Size(224, 27);
            this.view_ex.TabIndex = 11;
            this.view_ex.Text = "Shiko shpenzimet";
            this.view_ex.Click += new System.EventHandler(this.view_ex_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.logout.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.logout.Location = new System.Drawing.Point(98, 690);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(71, 27);
            this.logout.TabIndex = 9;
            this.logout.Text = "Dilni";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // expens
            // 
            this.expens.AutoSize = true;
            this.expens.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.expens.ForeColor = System.Drawing.Color.DarkGreen;
            this.expens.Location = new System.Drawing.Point(66, 372);
            this.expens.Name = "expens";
            this.expens.Size = new System.Drawing.Size(152, 27);
            this.expens.TabIndex = 7;
            this.expens.Text = "Shpenzimet";
            this.expens.Click += new System.EventHandler(this.expens_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 476);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // view_inc
            // 
            this.view_inc.AutoSize = true;
            this.view_inc.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.view_inc.ForeColor = System.Drawing.Color.DarkGreen;
            this.view_inc.Location = new System.Drawing.Point(66, 490);
            this.view_inc.Name = "view_inc";
            this.view_inc.Size = new System.Drawing.Size(247, 27);
            this.view_inc.TabIndex = 5;
            this.view_inc.Text = "Shikoni te ardhurat";
            this.view_inc.Click += new System.EventHandler(this.view_inc_Click);
            // 
            // income
            // 
            this.income.AutoSize = true;
            this.income.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.income.ForeColor = System.Drawing.Color.DarkGreen;
            this.income.Location = new System.Drawing.Point(70, 309);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(155, 27);
            this.income.TabIndex = 3;
            this.income.Text = "Te ardhurat";
            this.income.Click += new System.EventHandler(this.income_Click);
            // 
            // dashboard
            // 
            this.dashboard.AutoSize = true;
            this.dashboard.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.dashboard.ForeColor = System.Drawing.Color.DarkGreen;
            this.dashboard.Location = new System.Drawing.Point(70, 253);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(144, 27);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "Dashboard";
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 742);
            this.Controls.Add(this.shto_exp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.data_exp);
            this.Controls.Add(this.exp_date);
            this.Controls.Add(this.exp_cat);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.exp_desc);
            this.Controls.Add(this.desc_exp);
            this.Controls.Add(this.exp_amount);
            this.Controls.Add(this.sasia_exp);
            this.Controls.Add(this.exp_name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Expense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shto_exp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label data_exp;
        private System.Windows.Forms.DateTimePicker exp_date;
        private System.Windows.Forms.ComboBox exp_cat;
        private System.Windows.Forms.Label exp;
        private System.Windows.Forms.TextBox exp_desc;
        private System.Windows.Forms.Label desc_exp;
        private System.Windows.Forms.TextBox exp_amount;
        private System.Windows.Forms.Label sasia_exp;
        private System.Windows.Forms.TextBox exp_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label view_ex;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Label expens;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label view_inc;
        private System.Windows.Forms.Label income;
        private System.Windows.Forms.Label dashboard;
    }
}