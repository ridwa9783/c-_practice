namespace assigment_file
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
            this.btncreatenewfile = new System.Windows.Forms.Button();
            this.btndeletefile = new System.Windows.Forms.Button();
            this.btndeleteitem = new System.Windows.Forms.Button();
            this.btnreadingfunction = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btncreatenewfile
            // 
            this.btncreatenewfile.Location = new System.Drawing.Point(31, 38);
            this.btncreatenewfile.Name = "btncreatenewfile";
            this.btncreatenewfile.Size = new System.Drawing.Size(220, 49);
            this.btncreatenewfile.TabIndex = 0;
            this.btncreatenewfile.Text = "create new file";
            this.btncreatenewfile.UseVisualStyleBackColor = true;
            this.btncreatenewfile.Click += new System.EventHandler(this.btncreatenewfile_Click);
            // 
            // btndeletefile
            // 
            this.btndeletefile.Location = new System.Drawing.Point(31, 209);
            this.btndeletefile.Name = "btndeletefile";
            this.btndeletefile.Size = new System.Drawing.Size(239, 61);
            this.btndeletefile.TabIndex = 1;
            this.btndeletefile.Text = "delete the file";
            this.btndeletefile.UseVisualStyleBackColor = true;
            this.btndeletefile.Click += new System.EventHandler(this.btndeletefile_Click);
            // 
            // btndeleteitem
            // 
            this.btndeleteitem.Location = new System.Drawing.Point(36, 297);
            this.btndeleteitem.Name = "btndeleteitem";
            this.btndeleteitem.Size = new System.Drawing.Size(229, 57);
            this.btndeleteitem.TabIndex = 2;
            this.btndeleteitem.Text = "delete the item file";
            this.btndeleteitem.UseVisualStyleBackColor = true;
            this.btndeleteitem.Click += new System.EventHandler(this.btndeleteitem_Click);
            // 
            // btnreadingfunction
            // 
            this.btnreadingfunction.Location = new System.Drawing.Point(36, 107);
            this.btnreadingfunction.Name = "btnreadingfunction";
            this.btnreadingfunction.Size = new System.Drawing.Size(215, 57);
            this.btnreadingfunction.TabIndex = 3;
            this.btnreadingfunction.Text = "reading other function";
            this.btnreadingfunction.UseVisualStyleBackColor = true;
            this.btnreadingfunction.Click += new System.EventHandler(this.btnreadingfunction_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(553, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 264);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnreadingfunction);
            this.Controls.Add(this.btndeleteitem);
            this.Controls.Add(this.btndeletefile);
            this.Controls.Add(this.btncreatenewfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncreatenewfile;
        private System.Windows.Forms.Button btndeletefile;
        private System.Windows.Forms.Button btndeleteitem;
        private System.Windows.Forms.Button btnreadingfunction;
        private System.Windows.Forms.ListBox listBox1;
    }
}

