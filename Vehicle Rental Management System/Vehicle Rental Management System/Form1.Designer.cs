namespace Vehicle_Rental_Management_System
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
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.lblyear = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.lblnumber = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.rdluxury = new System.Windows.Forms.RadioButton();
            this.rdsuv = new System.Windows.Forms.RadioButton();
            this.rdeconomy = new System.Windows.Forms.RadioButton();
            this.cbinsurance = new System.Windows.Forms.CheckBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnumber
            // 
            this.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumber.Location = new System.Drawing.Point(277, 118);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(237, 31);
            this.txtnumber.TabIndex = 172;
            this.txtnumber.TextChanged += new System.EventHandler(this.txtnumber_TextChanged);
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(22, 165);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(249, 24);
            this.lblyear.TabIndex = 170;
            this.lblyear.Text = "Year Of Driving Experience :";
            // 
            // txtyear
            // 
            this.txtyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.Location = new System.Drawing.Point(277, 162);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(237, 31);
            this.txtyear.TabIndex = 169;
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumber.Location = new System.Drawing.Point(22, 121);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(217, 24);
            this.lblnumber.TabIndex = 168;
            this.lblnumber.Text = "Number Of Rental Days :";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(277, 29);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(237, 31);
            this.txtname.TabIndex = 167;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(22, 76);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(138, 24);
            this.lblage.TabIndex = 166;
            this.lblage.Text = "Customer age :";
            // 
            // txtage
            // 
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(277, 73);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(237, 31);
            this.txtage.TabIndex = 165;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(22, 32);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(157, 24);
            this.lblname.TabIndex = 164;
            this.lblname.Text = "Customer Name :";
            // 
            // rdluxury
            // 
            this.rdluxury.AutoSize = true;
            this.rdluxury.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdluxury.Location = new System.Drawing.Point(237, 26);
            this.rdluxury.Name = "rdluxury";
            this.rdluxury.Size = new System.Drawing.Size(69, 20);
            this.rdluxury.TabIndex = 175;
            this.rdluxury.TabStop = true;
            this.rdluxury.Text = "Luxury";
            this.rdluxury.UseVisualStyleBackColor = true;
            // 
            // rdsuv
            // 
            this.rdsuv.AutoSize = true;
            this.rdsuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdsuv.Location = new System.Drawing.Point(139, 26);
            this.rdsuv.Name = "rdsuv";
            this.rdsuv.Size = new System.Drawing.Size(56, 20);
            this.rdsuv.TabIndex = 173;
            this.rdsuv.TabStop = true;
            this.rdsuv.Text = "SUV";
            this.rdsuv.UseVisualStyleBackColor = true;
            // 
            // rdeconomy
            // 
            this.rdeconomy.AutoSize = true;
            this.rdeconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdeconomy.Location = new System.Drawing.Point(14, 26);
            this.rdeconomy.Name = "rdeconomy";
            this.rdeconomy.Size = new System.Drawing.Size(89, 20);
            this.rdeconomy.TabIndex = 171;
            this.rdeconomy.TabStop = true;
            this.rdeconomy.Text = "Economy";
            this.rdeconomy.UseVisualStyleBackColor = true;
            // 
            // cbinsurance
            // 
            this.cbinsurance.AutoSize = true;
            this.cbinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbinsurance.Location = new System.Drawing.Point(12, 27);
            this.cbinsurance.Name = "cbinsurance";
            this.cbinsurance.Size = new System.Drawing.Size(220, 20);
            this.cbinsurance.TabIndex = 174;
            this.cbinsurance.Text = "Add Insurance ($15 per day)";
            this.cbinsurance.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnexit.Location = new System.Drawing.Point(376, 455);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(160, 39);
            this.btnexit.TabIndex = 178;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnclear.Location = new System.Drawing.Point(205, 455);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(160, 39);
            this.btnclear.TabIndex = 177;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncalculate.ForeColor = System.Drawing.Color.Black;
            this.btncalculate.Location = new System.Drawing.Point(34, 455);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(160, 39);
            this.btncalculate.TabIndex = 176;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnumber);
            this.groupBox1.Controls.Add(this.lblyear);
            this.groupBox1.Controls.Add(this.txtyear);
            this.groupBox1.Controls.Add(this.lblnumber);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Location = new System.Drawing.Point(37, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 214);
            this.groupBox1.TabIndex = 179;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdluxury);
            this.groupBox2.Controls.Add(this.rdsuv);
            this.groupBox2.Controls.Add(this.rdeconomy);
            this.groupBox2.Location = new System.Drawing.Point(35, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 64);
            this.groupBox2.TabIndex = 180;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbinsurance);
            this.groupBox3.Location = new System.Drawing.Point(34, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 66);
            this.groupBox3.TabIndex = 181;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insurance option";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(611, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 290);
            this.listBox1.TabIndex = 182;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 531);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Name = "Form1";
            this.Text = "Vehicle Rental Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.RadioButton rdluxury;
        private System.Windows.Forms.RadioButton rdsuv;
        private System.Windows.Forms.RadioButton rdeconomy;
        private System.Windows.Forms.CheckBox cbinsurance;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

