namespace Simulated_Money_App
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listbPlayers = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblPot = new System.Windows.Forms.Label();
            this.btnEmptyPot = new System.Windows.Forms.Button();
            this.btnBet = new System.Windows.Forms.Button();
            this.numBet = new System.Windows.Forms.NumericUpDown();
            this.btnEliminate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlayerToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newPlayerToolStripMenuItem
            // 
            this.newPlayerToolStripMenuItem.Name = "newPlayerToolStripMenuItem";
            this.newPlayerToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.newPlayerToolStripMenuItem.Text = "New Player";
            this.newPlayerToolStripMenuItem.Click += new System.EventHandler(this.newPlayerToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // listbPlayers
            // 
            this.listbPlayers.FormattingEnabled = true;
            this.listbPlayers.Location = new System.Drawing.Point(69, 27);
            this.listbPlayers.Name = "listbPlayers";
            this.listbPlayers.Size = new System.Drawing.Size(84, 121);
            this.listbPlayers.TabIndex = 1;
            this.listbPlayers.SelectedValueChanged += new System.EventHandler(this.listbPlayers_SelectedValueChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(51, 121);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(159, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 22);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(266, 54);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(52, 19);
            this.lblMoney.TabIndex = 9;
            this.lblMoney.Text = "Money";
            // 
            // lblPot
            // 
            this.lblPot.AutoSize = true;
            this.lblPot.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPot.Location = new System.Drawing.Point(159, 27);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(69, 25);
            this.lblPot.TabIndex = 10;
            this.lblPot.Text = "Pot: $0";
            // 
            // btnEmptyPot
            // 
            this.btnEmptyPot.Location = new System.Drawing.Point(295, 27);
            this.btnEmptyPot.Name = "btnEmptyPot";
            this.btnEmptyPot.Size = new System.Drawing.Size(88, 25);
            this.btnEmptyPot.TabIndex = 11;
            this.btnEmptyPot.Text = "Empty Pot To...";
            this.btnEmptyPot.UseVisualStyleBackColor = true;
            this.btnEmptyPot.Click += new System.EventHandler(this.btnEmptyPot_Click);
            // 
            // btnBet
            // 
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.Location = new System.Drawing.Point(295, 113);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(64, 23);
            this.btnBet.TabIndex = 12;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // numBet
            // 
            this.numBet.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numBet.Location = new System.Drawing.Point(295, 87);
            this.numBet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBet.Name = "numBet";
            this.numBet.Size = new System.Drawing.Size(64, 20);
            this.numBet.TabIndex = 13;
            // 
            // btnEliminate
            // 
            this.btnEliminate.Location = new System.Drawing.Point(164, 125);
            this.btnEliminate.Name = "btnEliminate";
            this.btnEliminate.Size = new System.Drawing.Size(75, 23);
            this.btnEliminate.TabIndex = 14;
            this.btnEliminate.Text = "Eliminate";
            this.btnEliminate.UseVisualStyleBackColor = true;
            this.btnEliminate.Click += new System.EventHandler(this.btnEliminate_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 162);
            this.Controls.Add(this.btnEliminate);
            this.Controls.Add(this.numBet);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.btnEmptyPot);
            this.Controls.Add(this.lblPot);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.listbPlayers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Money Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ListBox listbPlayers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEmptyPot;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.NumericUpDown numBet;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblMoney;
        public System.Windows.Forms.Label lblPot;
        private System.Windows.Forms.Button btnEliminate;
    }
}

