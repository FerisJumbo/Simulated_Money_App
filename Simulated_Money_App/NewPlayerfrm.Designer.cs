namespace Simulated_Money_App
{
    partial class NewPlayerfrm
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
            System.Windows.Forms.GroupBox gboxStartMoney;
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rad100 = new System.Windows.Forms.RadioButton();
            this.rad500 = new System.Windows.Forms.RadioButton();
            this.rad2000 = new System.Windows.Forms.RadioButton();
            this.rad1000 = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            gboxStartMoney = new System.Windows.Forms.GroupBox();
            gboxStartMoney.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // gboxStartMoney
            // 
            gboxStartMoney.Controls.Add(this.rad2000);
            gboxStartMoney.Controls.Add(this.rad1000);
            gboxStartMoney.Controls.Add(this.rad500);
            gboxStartMoney.Controls.Add(this.rad100);
            gboxStartMoney.Location = new System.Drawing.Point(25, 32);
            gboxStartMoney.Name = "gboxStartMoney";
            gboxStartMoney.Size = new System.Drawing.Size(115, 68);
            gboxStartMoney.TabIndex = 2;
            gboxStartMoney.TabStop = false;
            gboxStartMoney.Text = "Starting Money";
            // 
            // rad100
            // 
            this.rad100.AutoSize = true;
            this.rad100.Location = new System.Drawing.Point(7, 20);
            this.rad100.Name = "rad100";
            this.rad100.Size = new System.Drawing.Size(43, 17);
            this.rad100.TabIndex = 0;
            this.rad100.TabStop = true;
            this.rad100.Text = "100";
            this.rad100.UseVisualStyleBackColor = true;
            // 
            // rad500
            // 
            this.rad500.AutoSize = true;
            this.rad500.Location = new System.Drawing.Point(56, 20);
            this.rad500.Name = "rad500";
            this.rad500.Size = new System.Drawing.Size(43, 17);
            this.rad500.TabIndex = 1;
            this.rad500.TabStop = true;
            this.rad500.Text = "500";
            this.rad500.UseVisualStyleBackColor = true;
            // 
            // rad2000
            // 
            this.rad2000.AutoSize = true;
            this.rad2000.Location = new System.Drawing.Point(56, 43);
            this.rad2000.Name = "rad2000";
            this.rad2000.Size = new System.Drawing.Size(49, 17);
            this.rad2000.TabIndex = 3;
            this.rad2000.TabStop = true;
            this.rad2000.Text = "2000";
            this.rad2000.UseVisualStyleBackColor = true;
            // 
            // rad1000
            // 
            this.rad1000.AutoSize = true;
            this.rad1000.Location = new System.Drawing.Point(7, 43);
            this.rad1000.Name = "rad1000";
            this.rad1000.Size = new System.Drawing.Size(49, 17);
            this.rad1000.TabIndex = 2;
            this.rad1000.TabStop = true;
            this.rad1000.Text = "1000";
            this.rad1000.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(15, 106);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(141, 36);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // NewPlayerfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 150);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(gboxStartMoney);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "NewPlayerfrm";
            this.Text = "NewPlayerfrm";
            this.Load += new System.EventHandler(this.NewPlayerfrm_Load);
            gboxStartMoney.ResumeLayout(false);
            gboxStartMoney.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rad2000;
        private System.Windows.Forms.RadioButton rad1000;
        private System.Windows.Forms.RadioButton rad500;
        private System.Windows.Forms.RadioButton rad100;
        private System.Windows.Forms.Button btnCreate;
    }
}