namespace VaccineRegistration
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProvinceCB = new System.Windows.Forms.ComboBox();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.SurnameTxt = new System.Windows.Forms.TextBox();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.GenderTxt = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.label1.Location = new System.Drawing.Point(265, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vaccine Registration";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(35, 108);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "Id:";
            this.IdLabel.Click += new System.EventHandler(this.IdLabel_Click);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(23, 146);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(52, 13);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Surname:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(18, 203);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "FirstName:";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(23, 246);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(45, 13);
            this.GenderLabel.TabIndex = 4;
            this.GenderLabel.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ProvinceCB
            // 
            this.ProvinceCB.FormattingEnabled = true;
            this.ProvinceCB.Items.AddRange(new object[] {
            "Gauteng ",
            "Eastern Cape",
            "Free State ",
            "Kwazulu-Natal",
            "Limpopo",
            "Mpumalanga",
            "Northern Cape",
            "North West ",
            "Western Cape"});
            this.ProvinceCB.Location = new System.Drawing.Point(113, 281);
            this.ProvinceCB.Name = "ProvinceCB";
            this.ProvinceCB.Size = new System.Drawing.Size(134, 21);
            this.ProvinceCB.TabIndex = 6;
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Location = new System.Drawing.Point(23, 281);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(52, 13);
            this.ProvinceLabel.TabIndex = 7;
            this.ProvinceLabel.Text = "Province:";
            this.ProvinceLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // Idtxt
            // 
            this.Idtxt.Location = new System.Drawing.Point(113, 105);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(134, 20);
            this.Idtxt.TabIndex = 8;
            this.Idtxt.TextChanged += new System.EventHandler(this.Idtxt_TextChanged);
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.Location = new System.Drawing.Point(113, 146);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.Size = new System.Drawing.Size(134, 20);
            this.SurnameTxt.TabIndex = 9;
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(113, 196);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(134, 20);
            this.FirstNameTxt.TabIndex = 10;
            // 
            // GenderTxt
            // 
            this.GenderTxt.Location = new System.Drawing.Point(113, 243);
            this.GenderTxt.Name = "GenderTxt";
            this.GenderTxt.Size = new System.Drawing.Size(134, 20);
            this.GenderTxt.TabIndex = 11;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(334, 347);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(154, 35);
            this.RegisterBtn.TabIndex = 12;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(814, 484);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.GenderTxt);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.SurnameTxt);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.ProvinceLabel);
            this.Controls.Add(this.ProvinceCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Vaccination Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ProvinceCB;
        private System.Windows.Forms.Label ProvinceLabel;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.TextBox SurnameTxt;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.TextBox GenderTxt;
        private System.Windows.Forms.Button RegisterBtn;
    }
}

