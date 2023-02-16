namespace Vishvas_Pr_2
{
    partial class Interest_Cal
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_amt = new System.Windows.Forms.Label();
            this.lbl_rate = new System.Windows.Forms.Label();
            this.lbl_month = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.tb_amt = new System.Windows.Forms.TextBox();
            this.tb_rate = new System.Windows.Forms.TextBox();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.tb_interest = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(45, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(202, 18);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Simple Interest Calculater";
            // 
            // lbl_amt
            // 
            this.lbl_amt.AutoSize = true;
            this.lbl_amt.Location = new System.Drawing.Point(23, 55);
            this.lbl_amt.Name = "lbl_amt";
            this.lbl_amt.Size = new System.Drawing.Size(43, 13);
            this.lbl_amt.TabIndex = 1;
            this.lbl_amt.Text = "Amount";
            // 
            // lbl_rate
            // 
            this.lbl_rate.AutoSize = true;
            this.lbl_rate.Location = new System.Drawing.Point(23, 85);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(41, 13);
            this.lbl_rate.TabIndex = 2;
            this.lbl_rate.Text = "Rate %";
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Location = new System.Drawing.Point(23, 116);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(58, 13);
            this.lbl_month.TabIndex = 3;
            this.lbl_month.Text = "Time(Year)";
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(48, 217);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(140, 217);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // tb_amt
            // 
            this.tb_amt.Location = new System.Drawing.Point(100, 55);
            this.tb_amt.Name = "tb_amt";
            this.tb_amt.Size = new System.Drawing.Size(131, 20);
            this.tb_amt.TabIndex = 6;
            // 
            // tb_rate
            // 
            this.tb_rate.Location = new System.Drawing.Point(100, 85);
            this.tb_rate.Name = "tb_rate";
            this.tb_rate.Size = new System.Drawing.Size(131, 20);
            this.tb_rate.TabIndex = 7;
            // 
            // tb_time
            // 
            this.tb_time.Location = new System.Drawing.Point(100, 113);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(131, 20);
            this.tb_time.TabIndex = 8;
            // 
            // tb_interest
            // 
            this.tb_interest.Location = new System.Drawing.Point(100, 158);
            this.tb_interest.Name = "tb_interest";
            this.tb_interest.Size = new System.Drawing.Size(131, 20);
            this.tb_interest.TabIndex = 10;
            this.tb_interest.Visible = false;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(23, 161);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(43, 13);
            this.lbl_result.TabIndex = 9;
            this.lbl_result.Text = "Amount";
            this.lbl_result.Visible = false;
            // 
            // Interest_Cal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tb_interest);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.tb_rate);
            this.Controls.Add(this.tb_amt);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_month);
            this.Controls.Add(this.lbl_rate);
            this.Controls.Add(this.lbl_amt);
            this.Controls.Add(this.lbl_title);
            this.Name = "Interest_Cal";
            this.Text = "Interest_Cal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_amt;
        private System.Windows.Forms.Label lbl_rate;
        private System.Windows.Forms.Label lbl_month;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox tb_amt;
        private System.Windows.Forms.TextBox tb_rate;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.TextBox tb_interest;
        private System.Windows.Forms.Label lbl_result;
    }
}