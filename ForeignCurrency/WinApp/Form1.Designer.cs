
namespace WinApp
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grd_ExchangeRatePast = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_sterling_selling = new System.Windows.Forms.Label();
            this.lbl_sterling_buying = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_euro_selling = new System.Windows.Forms.Label();
            this.lbl_euro_buying = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_dollar_selling = new System.Windows.Forms.Label();
            this.lbl_dollar_buying = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ExchangeRatePast)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grd_ExchangeRatePast);
            this.groupBox4.Location = new System.Drawing.Point(325, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(613, 540);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exchange Rate Past";
            // 
            // grd_ExchangeRatePast
            // 
            this.grd_ExchangeRatePast.AllowUserToAddRows = false;
            this.grd_ExchangeRatePast.AllowUserToDeleteRows = false;
            this.grd_ExchangeRatePast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_ExchangeRatePast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_ExchangeRatePast.Location = new System.Drawing.Point(3, 18);
            this.grd_ExchangeRatePast.Name = "grd_ExchangeRatePast";
            this.grd_ExchangeRatePast.ReadOnly = true;
            this.grd_ExchangeRatePast.RowHeadersWidth = 51;
            this.grd_ExchangeRatePast.RowTemplate.Height = 24;
            this.grd_ExchangeRatePast.Size = new System.Drawing.Size(607, 519);
            this.grd_ExchangeRatePast.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_sterling_selling);
            this.groupBox3.Controls.Add(this.lbl_sterling_buying);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(16, 401);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 160);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "STERLING £";
            // 
            // lbl_sterling_selling
            // 
            this.lbl_sterling_selling.AutoSize = true;
            this.lbl_sterling_selling.Location = new System.Drawing.Point(120, 102);
            this.lbl_sterling_selling.Name = "lbl_sterling_selling";
            this.lbl_sterling_selling.Size = new System.Drawing.Size(46, 17);
            this.lbl_sterling_selling.TabIndex = 3;
            this.lbl_sterling_selling.Text = "label9";
            // 
            // lbl_sterling_buying
            // 
            this.lbl_sterling_buying.AutoSize = true;
            this.lbl_sterling_buying.Location = new System.Drawing.Point(117, 54);
            this.lbl_sterling_buying.Name = "lbl_sterling_buying";
            this.lbl_sterling_buying.Size = new System.Drawing.Size(54, 17);
            this.lbl_sterling_buying.TabIndex = 2;
            this.lbl_sterling_buying.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "SELLING";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "BUYING";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_euro_selling);
            this.groupBox2.Controls.Add(this.lbl_euro_buying);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(13, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 160);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EURO €";
            // 
            // lbl_euro_selling
            // 
            this.lbl_euro_selling.AutoSize = true;
            this.lbl_euro_selling.Location = new System.Drawing.Point(123, 95);
            this.lbl_euro_selling.Name = "lbl_euro_selling";
            this.lbl_euro_selling.Size = new System.Drawing.Size(46, 17);
            this.lbl_euro_selling.TabIndex = 3;
            this.lbl_euro_selling.Text = "label5";
            // 
            // lbl_euro_buying
            // 
            this.lbl_euro_buying.AutoSize = true;
            this.lbl_euro_buying.Location = new System.Drawing.Point(120, 47);
            this.lbl_euro_buying.Name = "lbl_euro_buying";
            this.lbl_euro_buying.Size = new System.Drawing.Size(46, 17);
            this.lbl_euro_buying.TabIndex = 2;
            this.lbl_euro_buying.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "SELLING";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "BUYING";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_dollar_selling);
            this.groupBox1.Controls.Add(this.lbl_dollar_buying);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DOLLAR $";
            // 
            // lbl_dollar_selling
            // 
            this.lbl_dollar_selling.AutoSize = true;
            this.lbl_dollar_selling.Location = new System.Drawing.Point(119, 95);
            this.lbl_dollar_selling.Name = "lbl_dollar_selling";
            this.lbl_dollar_selling.Size = new System.Drawing.Size(46, 17);
            this.lbl_dollar_selling.TabIndex = 3;
            this.lbl_dollar_selling.Text = "label4";
            // 
            // lbl_dollar_buying
            // 
            this.lbl_dollar_buying.AutoSize = true;
            this.lbl_dollar_buying.Location = new System.Drawing.Point(116, 47);
            this.lbl_dollar_buying.Name = "lbl_dollar_buying";
            this.lbl_dollar_buying.Size = new System.Drawing.Size(46, 17);
            this.lbl_dollar_buying.TabIndex = 2;
            this.lbl_dollar_buying.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "SELLING";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUYING";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 578);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foreign Currency ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ExchangeRatePast)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grd_ExchangeRatePast;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_sterling_selling;
        private System.Windows.Forms.Label lbl_sterling_buying;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_euro_selling;
        private System.Windows.Forms.Label lbl_euro_buying;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_dollar_selling;
        private System.Windows.Forms.Label lbl_dollar_buying;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

