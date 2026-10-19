namespace Airplane_ticket_booking_system
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chinsurance = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiobusnessclass = new System.Windows.Forms.RadioButton();
            this.radionormalclass = new System.Windows.Forms.RadioButton();
            this.radiofirstclass = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.lblweight = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblpasengerage = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblpasengername = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(583, 611);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(136, 49);
            this.btnexit.TabIndex = 163;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(288, 611);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(159, 49);
            this.btnclear.TabIndex = 162;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(45, 611);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(159, 49);
            this.btncalculate.TabIndex = 161;
            this.btncalculate.Text = "claculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chinsurance);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(45, 480);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 93);
            this.groupBox3.TabIndex = 160;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aditional options";
            // 
            // chinsurance
            // 
            this.chinsurance.AutoSize = true;
            this.chinsurance.Location = new System.Drawing.Point(32, 44);
            this.chinsurance.Name = "chinsurance";
            this.chinsurance.Size = new System.Drawing.Size(419, 33);
            this.chinsurance.TabIndex = 0;
            this.chinsurance.Text = "add travel insurance ($25 per ticket)";
            this.chinsurance.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiobusnessclass);
            this.groupBox2.Controls.Add(this.radionormalclass);
            this.groupBox2.Controls.Add(this.radiofirstclass);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 97);
            this.groupBox2.TabIndex = 159;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "travel class";
            // 
            // radiobusnessclass
            // 
            this.radiobusnessclass.AutoSize = true;
            this.radiobusnessclass.Location = new System.Drawing.Point(462, 45);
            this.radiobusnessclass.Name = "radiobusnessclass";
            this.radiobusnessclass.Size = new System.Drawing.Size(195, 33);
            this.radiobusnessclass.TabIndex = 159;
            this.radiobusnessclass.TabStop = true;
            this.radiobusnessclass.Text = "business class";
            this.radiobusnessclass.UseVisualStyleBackColor = true;
            // 
            // radionormalclass
            // 
            this.radionormalclass.AutoSize = true;
            this.radionormalclass.Location = new System.Drawing.Point(243, 45);
            this.radionormalclass.Name = "radionormalclass";
            this.radionormalclass.Size = new System.Drawing.Size(173, 33);
            this.radionormalclass.TabIndex = 158;
            this.radionormalclass.TabStop = true;
            this.radionormalclass.Text = "normal class";
            this.radionormalclass.UseVisualStyleBackColor = true;
            // 
            // radiofirstclass
            // 
            this.radiofirstclass.AutoSize = true;
            this.radiofirstclass.Location = new System.Drawing.Point(30, 45);
            this.radiofirstclass.Name = "radiofirstclass";
            this.radiofirstclass.Size = new System.Drawing.Size(137, 33);
            this.radiofirstclass.TabIndex = 157;
            this.radiofirstclass.TabStop = true;
            this.radiofirstclass.Text = "first class";
            this.radiofirstclass.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(789, 31);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(440, 504);
            this.listBox1.TabIndex = 158;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtweight);
            this.groupBox1.Controls.Add(this.txtnumber);
            this.groupBox1.Controls.Add(this.lblweight);
            this.groupBox1.Controls.Add(this.lblnumber);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblpasengerage);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.lblpasengername);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(33, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(724, 311);
            this.groupBox1.TabIndex = 157;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal information";
            // 
            // txtweight
            // 
            this.txtweight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtweight.Location = new System.Drawing.Point(338, 242);
            this.txtweight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(354, 43);
            this.txtweight.TabIndex = 143;
            // 
            // txtnumber
            // 
            this.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumber.Location = new System.Drawing.Point(338, 183);
            this.txtnumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(354, 43);
            this.txtnumber.TabIndex = 142;
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweight.Location = new System.Drawing.Point(24, 229);
            this.lblweight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(286, 33);
            this.lblweight.TabIndex = 141;
            this.lblweight.Text = "baggage weight(kg) :";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumber.Location = new System.Drawing.Point(24, 168);
            this.lblnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(254, 33);
            this.lblnumber.TabIndex = 140;
            this.lblnumber.Text = "number of tickets :";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(338, 48);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(354, 43);
            this.txtname.TabIndex = 139;
            // 
            // lblpasengerage
            // 
            this.lblpasengerage.AutoSize = true;
            this.lblpasengerage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasengerage.Location = new System.Drawing.Point(24, 105);
            this.lblpasengerage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpasengerage.Name = "lblpasengerage";
            this.lblpasengerage.Size = new System.Drawing.Size(223, 33);
            this.lblpasengerage.TabIndex = 138;
            this.lblpasengerage.Text = "passenger age :";
            // 
            // txtage
            // 
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(338, 115);
            this.txtage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(354, 43);
            this.txtage.TabIndex = 137;
            // 
            // lblpasengername
            // 
            this.lblpasengername.AutoSize = true;
            this.lblpasengername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasengername.Location = new System.Drawing.Point(24, 48);
            this.lblpasengername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpasengername.Name = "lblpasengername";
            this.lblpasengername.Size = new System.Drawing.Size(232, 33);
            this.lblpasengername.TabIndex = 136;
            this.lblpasengername.Text = "passenger name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 688);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chinsurance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radiobusnessclass;
        private System.Windows.Forms.RadioButton radionormalclass;
        private System.Windows.Forms.RadioButton radiofirstclass;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblpasengerage;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblpasengername;
    }
}

