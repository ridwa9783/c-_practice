namespace assigment
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
            this.lblnumberpackage = new System.Windows.Forms.Label();
            this.lblpriceper = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtperpackage = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblnumberpackage
            // 
            this.lblnumberpackage.AutoSize = true;
            this.lblnumberpackage.Location = new System.Drawing.Point(93, 72);
            this.lblnumberpackage.Name = "lblnumberpackage";
            this.lblnumberpackage.Size = new System.Drawing.Size(146, 20);
            this.lblnumberpackage.TabIndex = 0;
            this.lblnumberpackage.Text = "number of package";
            // 
            // lblpriceper
            // 
            this.lblpriceper.AutoSize = true;
            this.lblpriceper.Location = new System.Drawing.Point(93, 132);
            this.lblpriceper.Name = "lblpriceper";
            this.lblpriceper.Size = new System.Drawing.Size(135, 20);
            this.lblpriceper.TabIndex = 1;
            this.lblpriceper.Text = "price per package";
            this.lblpriceper.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(295, 72);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(161, 26);
            this.txtnumber.TabIndex = 2;
            // 
            // txtperpackage
            // 
            this.txtperpackage.Location = new System.Drawing.Point(295, 132);
            this.txtperpackage.Name = "txtperpackage";
            this.txtperpackage.Size = new System.Drawing.Size(161, 26);
            this.txtperpackage.TabIndex = 3;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(48, 340);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(131, 63);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(239, 340);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(121, 63);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(376, 363);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(104, 40);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(495, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(293, 344);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtperpackage);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.lblpriceper);
            this.Controls.Add(this.lblnumberpackage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumberpackage;
        private System.Windows.Forms.Label lblpriceper;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtperpackage;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox listBox1;
    }
}

