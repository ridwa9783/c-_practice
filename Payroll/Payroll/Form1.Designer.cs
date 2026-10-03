namespace Payroll
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
            this.exitbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.lblgross = new System.Windows.Forms.Label();
            this.grossbylabel = new System.Windows.Forms.Label();
            this.hourlypayratetextbox = new System.Windows.Forms.TextBox();
            this.lblpay = new System.Windows.Forms.Label();
            this.hourseworkedtextbox = new System.Windows.Forms.TextBox();
            this.lblhours = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(319, 249);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(117, 39);
            this.exitbutton.TabIndex = 89;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(184, 249);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(117, 39);
            this.clearbutton.TabIndex = 88;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // calculatebutton
            // 
            this.calculatebutton.Location = new System.Drawing.Point(48, 249);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(117, 39);
            this.calculatebutton.TabIndex = 87;
            this.calculatebutton.Text = "Calculate gross pay";
            this.calculatebutton.UseVisualStyleBackColor = true;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton_Click);
            // 
            // lblgross
            // 
            this.lblgross.AutoSize = true;
            this.lblgross.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgross.Location = new System.Drawing.Point(86, 180);
            this.lblgross.Name = "lblgross";
            this.lblgross.Size = new System.Drawing.Size(99, 24);
            this.lblgross.TabIndex = 86;
            this.lblgross.Text = "Gross pay:";
            // 
            // grossbylabel
            // 
            this.grossbylabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grossbylabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grossbylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossbylabel.Location = new System.Drawing.Point(199, 176);
            this.grossbylabel.Name = "grossbylabel";
            this.grossbylabel.Size = new System.Drawing.Size(237, 33);
            this.grossbylabel.TabIndex = 85;
            this.grossbylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourlypayratetextbox
            // 
            this.hourlypayratetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlypayratetextbox.Location = new System.Drawing.Point(198, 123);
            this.hourlypayratetextbox.Name = "hourlypayratetextbox";
            this.hourlypayratetextbox.Size = new System.Drawing.Size(237, 29);
            this.hourlypayratetextbox.TabIndex = 84;
            // 
            // lblpay
            // 
            this.lblpay.AutoSize = true;
            this.lblpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpay.Location = new System.Drawing.Point(44, 126);
            this.lblpay.Name = "lblpay";
            this.lblpay.Size = new System.Drawing.Size(141, 24);
            this.lblpay.TabIndex = 83;
            this.lblpay.Text = "Hourly pay rate:";
            this.lblpay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // hourseworkedtextbox
            // 
            this.hourseworkedtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourseworkedtextbox.Location = new System.Drawing.Point(198, 72);
            this.hourseworkedtextbox.Name = "hourseworkedtextbox";
            this.hourseworkedtextbox.Size = new System.Drawing.Size(238, 29);
            this.hourseworkedtextbox.TabIndex = 82;
            // 
            // lblhours
            // 
            this.lblhours.AutoSize = true;
            this.lblhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhours.Location = new System.Drawing.Point(44, 75);
            this.lblhours.Name = "lblhours";
            this.lblhours.Size = new System.Drawing.Size(148, 24);
            this.lblhours.TabIndex = 81;
            this.lblhours.Text = "Hourse Worked:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 364);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.lblgross);
            this.Controls.Add(this.grossbylabel);
            this.Controls.Add(this.hourlypayratetextbox);
            this.Controls.Add(this.lblpay);
            this.Controls.Add(this.hourseworkedtextbox);
            this.Controls.Add(this.lblhours);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.Label lblgross;
        private System.Windows.Forms.Label grossbylabel;
        private System.Windows.Forms.TextBox hourlypayratetextbox;
        private System.Windows.Forms.Label lblpay;
        private System.Windows.Forms.TextBox hourseworkedtextbox;
        private System.Windows.Forms.Label lblhours;
    }
}

