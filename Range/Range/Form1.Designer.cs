namespace Range
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
            this.lbldecision = new System.Windows.Forms.Label();
            this.lblrangedecision = new System.Windows.Forms.Label();
            this.txtrange = new System.Windows.Forms.TextBox();
            this.lblrange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldecision
            // 
            this.lbldecision.AutoSize = true;
            this.lbldecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldecision.Location = new System.Drawing.Point(68, 187);
            this.lbldecision.Name = "lbldecision";
            this.lbldecision.Size = new System.Drawing.Size(144, 24);
            this.lbldecision.TabIndex = 95;
            this.lbldecision.Text = "Range Decision";
            // 
            // lblrangedecision
            // 
            this.lblrangedecision.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblrangedecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblrangedecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrangedecision.Location = new System.Drawing.Point(72, 227);
            this.lblrangedecision.Name = "lblrangedecision";
            this.lblrangedecision.Size = new System.Drawing.Size(368, 33);
            this.lblrangedecision.TabIndex = 94;
            this.lblrangedecision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtrange
            // 
            this.txtrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrange.Location = new System.Drawing.Point(72, 141);
            this.txtrange.Name = "txtrange";
            this.txtrange.Size = new System.Drawing.Size(368, 29);
            this.txtrange.TabIndex = 91;
            // 
            // lblrange
            // 
            this.lblrange.AutoSize = true;
            this.lblrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrange.Location = new System.Drawing.Point(68, 104);
            this.lblrange.Name = "lblrange";
            this.lblrange.Size = new System.Drawing.Size(372, 24);
            this.lblrange.TabIndex = 90;
            this.lblrange.Text = "Enter an integer i the range of 1 throught 10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 29);
            this.label1.TabIndex = 96;
            this.label1.Text = "Range Checker Application";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(261, 331);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(179, 39);
            this.btnexit.TabIndex = 99;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(261, 284);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(179, 39);
            this.btnclear.TabIndex = 98;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(72, 284);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(179, 86);
            this.btncheck.TabIndex = 97;
            this.btncheck.Text = "Check Qualification";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 425);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldecision);
            this.Controls.Add(this.lblrangedecision);
            this.Controls.Add(this.txtrange);
            this.Controls.Add(this.lblrange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldecision;
        private System.Windows.Forms.Label lblrangedecision;
        private System.Windows.Forms.TextBox txtrange;
        private System.Windows.Forms.Label lblrange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncheck;
    }
}

