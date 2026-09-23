namespace homework_ca242
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
            this.btnclose = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtnumeric = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtweek = new System.Windows.Forms.TextBox();
            this.lblyear = new System.Windows.Forms.Label();
            this.lblnumeric = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblweek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(414, 358);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(152, 40);
            this.btnclose.TabIndex = 25;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(245, 358);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(152, 40);
            this.btnclear.TabIndex = 24;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(75, 358);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(152, 40);
            this.btnshow.TabIndex = 23;
            this.btnshow.Text = "Show Date";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(75, 277);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(491, 59);
            this.lbloutput.TabIndex = 22;
            // 
            // txtyear
            // 
            this.txtyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.Location = new System.Drawing.Point(348, 218);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(218, 26);
            this.txtyear.TabIndex = 21;
            // 
            // txtnumeric
            // 
            this.txtnumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumeric.Location = new System.Drawing.Point(348, 175);
            this.txtnumeric.Name = "txtnumeric";
            this.txtnumeric.Size = new System.Drawing.Size(218, 26);
            this.txtnumeric.TabIndex = 20;
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(348, 125);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(218, 26);
            this.txtname.TabIndex = 19;
            // 
            // txtweek
            // 
            this.txtweek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtweek.Location = new System.Drawing.Point(348, 73);
            this.txtweek.Name = "txtweek";
            this.txtweek.Size = new System.Drawing.Size(218, 26);
            this.txtweek.TabIndex = 18;
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(220, 224);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(109, 20);
            this.lblyear.TabIndex = 16;
            this.lblyear.Text = "Enter the year";
            // 
            // lblnumeric
            // 
            this.lblnumeric.AutoSize = true;
            this.lblnumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeric.Location = new System.Drawing.Point(71, 181);
            this.lblnumeric.Name = "lblnumeric";
            this.lblnumeric.Size = new System.Drawing.Size(258, 20);
            this.lblnumeric.TabIndex = 15;
            this.lblnumeric.Text = "Enter the numeric day of the month";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(116, 131);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(213, 20);
            this.lblname.TabIndex = 14;
            this.lblname.Text = "Enter the name of the month";
            // 
            // lblweek
            // 
            this.lblweek.AutoSize = true;
            this.lblweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweek.Location = new System.Drawing.Point(139, 79);
            this.lblweek.Name = "lblweek";
            this.lblweek.Size = new System.Drawing.Size(190, 20);
            this.lblweek.TabIndex = 13;
            this.lblweek.Text = "Enter the day of the week";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtnumeric);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtweek);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lblnumeric);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblweek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtnumeric;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtweek;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lblnumeric;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblweek;
    }
}

