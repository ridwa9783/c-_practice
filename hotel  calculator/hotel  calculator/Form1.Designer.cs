namespace hotel__calculator
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
            this.txtguestname = new System.Windows.Forms.TextBox();
            this.txtnight = new System.Windows.Forms.TextBox();
            this.txtpricenight = new System.Windows.Forms.TextBox();
            this.txtroomtype = new System.Windows.Forms.TextBox();
            this.lblguestname = new System.Windows.Forms.Label();
            this.lblroomtype = new System.Windows.Forms.Label();
            this.lblnight = new System.Windows.Forms.Label();
            this.lblpricenight = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sevice = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.lblservicetax = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtguestname
            // 
            this.txtguestname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtguestname.Location = new System.Drawing.Point(354, 50);
            this.txtguestname.Name = "txtguestname";
            this.txtguestname.Size = new System.Drawing.Size(265, 39);
            this.txtguestname.TabIndex = 0;
            this.txtguestname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnight
            // 
            this.txtnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnight.Location = new System.Drawing.Point(354, 146);
            this.txtnight.Name = "txtnight";
            this.txtnight.Size = new System.Drawing.Size(265, 39);
            this.txtnight.TabIndex = 2;
            this.txtnight.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtpricenight
            // 
            this.txtpricenight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpricenight.Location = new System.Drawing.Point(354, 192);
            this.txtpricenight.Name = "txtpricenight";
            this.txtpricenight.Size = new System.Drawing.Size(265, 39);
            this.txtpricenight.TabIndex = 3;
            // 
            // txtroomtype
            // 
            this.txtroomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroomtype.Location = new System.Drawing.Point(354, 95);
            this.txtroomtype.Name = "txtroomtype";
            this.txtroomtype.Size = new System.Drawing.Size(265, 39);
            this.txtroomtype.TabIndex = 4;
            // 
            // lblguestname
            // 
            this.lblguestname.AutoSize = true;
            this.lblguestname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguestname.Location = new System.Drawing.Point(136, 72);
            this.lblguestname.Name = "lblguestname";
            this.lblguestname.Size = new System.Drawing.Size(199, 29);
            this.lblguestname.TabIndex = 5;
            this.lblguestname.Text = "enter guest name";
            // 
            // lblroomtype
            // 
            this.lblroomtype.AutoSize = true;
            this.lblroomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomtype.Location = new System.Drawing.Point(139, 117);
            this.lblroomtype.Name = "lblroomtype";
            this.lblroomtype.Size = new System.Drawing.Size(196, 29);
            this.lblroomtype.TabIndex = 6;
            this.lblroomtype.Text = "enter room name";
            // 
            // lblnight
            // 
            this.lblnight.AutoSize = true;
            this.lblnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnight.Location = new System.Drawing.Point(108, 152);
            this.lblnight.Name = "lblnight";
            this.lblnight.Size = new System.Drawing.Size(240, 29);
            this.lblnight.TabIndex = 7;
            this.lblnight.Text = "enter number of night";
            this.lblnight.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblpricenight
            // 
            this.lblpricenight.AutoSize = true;
            this.lblpricenight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpricenight.Location = new System.Drawing.Point(113, 192);
            this.lblpricenight.Name = "lblpricenight";
            this.lblpricenight.Size = new System.Drawing.Size(228, 29);
            this.lblpricenight.TabIndex = 8;
            this.lblpricenight.Text = "enter price per night";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(220, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "calculate Booking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "hotel room Booking calculator";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // sevice
            // 
            this.sevice.AutoSize = true;
            this.sevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevice.Location = new System.Drawing.Point(113, 340);
            this.sevice.Name = "sevice";
            this.sevice.Size = new System.Drawing.Size(182, 29);
            this.sevice.TabIndex = 11;
            this.sevice.Text = "sevice tax(10%)";
            this.sevice.Click += new System.EventHandler(this.label1_Click);
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(76, 381);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(242, 29);
            this.discount.TabIndex = 12;
            this.discount.Text = "Discount amount(5%)";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(136, 435);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(143, 29);
            this.total.TabIndex = 13;
            this.total.Text = "total amount";
            this.total.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lblservicetax
            // 
            this.lblservicetax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblservicetax.Location = new System.Drawing.Point(332, 339);
            this.lblservicetax.Name = "lblservicetax";
            this.lblservicetax.Size = new System.Drawing.Size(298, 30);
            this.lblservicetax.TabIndex = 14;
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotalamount.Location = new System.Drawing.Point(332, 435);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(298, 35);
            this.lbltotalamount.TabIndex = 15;
            // 
            // lbldiscount
            // 
            this.lbldiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldiscount.Location = new System.Drawing.Point(332, 381);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(298, 37);
            this.lbldiscount.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.lblservicetax);
            this.Controls.Add(this.total);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.sevice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblpricenight);
            this.Controls.Add(this.lblnight);
            this.Controls.Add(this.lblroomtype);
            this.Controls.Add(this.lblguestname);
            this.Controls.Add(this.txtroomtype);
            this.Controls.Add(this.txtpricenight);
            this.Controls.Add(this.txtnight);
            this.Controls.Add(this.txtguestname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtguestname;
        private System.Windows.Forms.TextBox txtnight;
        private System.Windows.Forms.TextBox txtpricenight;
        private System.Windows.Forms.TextBox txtroomtype;
        private System.Windows.Forms.Label lblguestname;
        private System.Windows.Forms.Label lblroomtype;
        private System.Windows.Forms.Label lblnight;
        private System.Windows.Forms.Label lblpricenight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sevice;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label lblservicetax;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label lbldiscount;
    }
}

