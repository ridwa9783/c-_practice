namespace Average_display
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
            this.lblaverageoutput = new System.Windows.Forms.Label();
            this.txtscore2 = new System.Windows.Forms.TextBox();
            this.lblscore2 = new System.Windows.Forms.Label();
            this.txtscore1 = new System.Windows.Forms.TextBox();
            this.lblscore1 = new System.Windows.Forms.Label();
            this.lblscore3 = new System.Windows.Forms.Label();
            this.txtscore3 = new System.Windows.Forms.TextBox();
            this.lblaverage = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblaverageoutput
            // 
            this.lblaverageoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblaverageoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblaverageoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaverageoutput.Location = new System.Drawing.Point(243, 239);
            this.lblaverageoutput.Name = "lblaverageoutput";
            this.lblaverageoutput.Size = new System.Drawing.Size(237, 33);
            this.lblaverageoutput.TabIndex = 53;
            this.lblaverageoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtscore2
            // 
            this.txtscore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore2.Location = new System.Drawing.Point(243, 139);
            this.txtscore2.Name = "txtscore2";
            this.txtscore2.Size = new System.Drawing.Size(237, 29);
            this.txtscore2.TabIndex = 51;
            // 
            // lblscore2
            // 
            this.lblscore2.AutoSize = true;
            this.lblscore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore2.Location = new System.Drawing.Point(99, 140);
            this.lblscore2.Name = "lblscore2";
            this.lblscore2.Size = new System.Drawing.Size(126, 24);
            this.lblscore2.TabIndex = 50;
            this.lblscore2.Text = "Test Score #2";
            // 
            // txtscore1
            // 
            this.txtscore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore1.Location = new System.Drawing.Point(243, 88);
            this.txtscore1.Name = "txtscore1";
            this.txtscore1.Size = new System.Drawing.Size(237, 29);
            this.txtscore1.TabIndex = 48;
            // 
            // lblscore1
            // 
            this.lblscore1.AutoSize = true;
            this.lblscore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore1.Location = new System.Drawing.Point(99, 89);
            this.lblscore1.Name = "lblscore1";
            this.lblscore1.Size = new System.Drawing.Size(126, 24);
            this.lblscore1.TabIndex = 47;
            this.lblscore1.Text = "Test Score #1";
            // 
            // lblscore3
            // 
            this.lblscore3.AutoSize = true;
            this.lblscore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore3.Location = new System.Drawing.Point(99, 192);
            this.lblscore3.Name = "lblscore3";
            this.lblscore3.Size = new System.Drawing.Size(126, 24);
            this.lblscore3.TabIndex = 54;
            this.lblscore3.Text = "Test Score #3";
            // 
            // txtscore3
            // 
            this.txtscore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore3.Location = new System.Drawing.Point(243, 189);
            this.txtscore3.Name = "txtscore3";
            this.txtscore3.Size = new System.Drawing.Size(237, 29);
            this.txtscore3.TabIndex = 55;
            // 
            // lblaverage
            // 
            this.lblaverage.AutoSize = true;
            this.lblaverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaverage.Location = new System.Drawing.Point(144, 243);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(81, 24);
            this.lblaverage.TabIndex = 56;
            this.lblaverage.Text = "Average";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(103, 304);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(179, 86);
            this.btncalculate.TabIndex = 57;
            this.btncalculate.Text = "Calculate Average";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(288, 304);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(179, 39);
            this.btnclear.TabIndex = 58;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(288, 351);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(179, 39);
            this.btnexit.TabIndex = 59;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 481);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblaverage);
            this.Controls.Add(this.txtscore3);
            this.Controls.Add(this.lblscore3);
            this.Controls.Add(this.lblaverageoutput);
            this.Controls.Add(this.txtscore2);
            this.Controls.Add(this.lblscore2);
            this.Controls.Add(this.txtscore1);
            this.Controls.Add(this.lblscore1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblaverageoutput;
        private System.Windows.Forms.TextBox txtscore2;
        private System.Windows.Forms.Label lblscore2;
        private System.Windows.Forms.TextBox txtscore1;
        private System.Windows.Forms.Label lblscore1;
        private System.Windows.Forms.Label lblscore3;
        private System.Windows.Forms.TextBox txtscore3;
        private System.Windows.Forms.Label lblaverage;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

