namespace FloBot
{
    partial class mainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGameFound = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLvL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLvLRange = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCharName = new System.Windows.Forms.Label();
            this.lblCharLvL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCharHP = new System.Windows.Forms.Label();
            this.lblCharMP = new System.Windows.Forms.Label();
            this.cbAutoBattle = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGameFound
            // 
            this.lblGameFound.AutoSize = true;
            this.lblGameFound.Location = new System.Drawing.Point(13, 13);
            this.lblGameFound.Name = "lblGameFound";
            this.lblGameFound.Size = new System.Drawing.Size(95, 13);
            this.lblGameFound.TabIndex = 0;
            this.lblGameFound.Text = "Flo nicht gefunden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ziel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "HP übrig";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(6, 47);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(35, 13);
            this.lblTarget.TabIndex = 3;
            this.lblTarget.Text = "label3";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(148, 47);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(35, 13);
            this.lblHP.TabIndex = 4;
            this.lblHP.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LvL";
            // 
            // lblLvL
            // 
            this.lblLvL.AutoSize = true;
            this.lblLvL.Location = new System.Drawing.Point(223, 47);
            this.lblLvL.Name = "lblLvL";
            this.lblLvL.Size = new System.Drawing.Size(35, 13);
            this.lblLvL.TabIndex = 4;
            this.lblLvL.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Maximaler level unterschied:\r\n(+- vom Spieler Level)\r\n";
            // 
            // tbLvLRange
            // 
            this.tbLvLRange.Location = new System.Drawing.Point(162, 287);
            this.tbLvLRange.Name = "tbLvLRange";
            this.tbLvLRange.Size = new System.Drawing.Size(100, 20);
            this.tbLvLRange.TabIndex = 6;
            this.tbLvLRange.Text = "5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblLvL);
            this.groupBox1.Controls.Add(this.lblTarget);
            this.groupBox1.Controls.Add(this.lblHP);
            this.groupBox1.Location = new System.Drawing.Point(16, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gegner Übersicht";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCharLvL);
            this.groupBox2.Controls.Add(this.lblCharMP);
            this.groupBox2.Controls.Add(this.lblCharHP);
            this.groupBox2.Controls.Add(this.lblCharName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(16, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 119);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Charakter Übersicht";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Charakter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Level";
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Location = new System.Drawing.Point(9, 37);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(35, 13);
            this.lblCharName.TabIndex = 2;
            this.lblCharName.Text = "label7";
            // 
            // lblCharLvL
            // 
            this.lblCharLvL.AutoSize = true;
            this.lblCharLvL.Location = new System.Drawing.Point(151, 37);
            this.lblCharLvL.Name = "lblCharLvL";
            this.lblCharLvL.Size = new System.Drawing.Size(35, 13);
            this.lblCharLvL.TabIndex = 2;
            this.lblCharLvL.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "HP(gerade/max)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "MP(gerade/max)";
            // 
            // lblCharHP
            // 
            this.lblCharHP.AutoSize = true;
            this.lblCharHP.Location = new System.Drawing.Point(6, 77);
            this.lblCharHP.Name = "lblCharHP";
            this.lblCharHP.Size = new System.Drawing.Size(35, 13);
            this.lblCharHP.TabIndex = 2;
            this.lblCharHP.Text = "label7";
            // 
            // lblCharMP
            // 
            this.lblCharMP.AutoSize = true;
            this.lblCharMP.Location = new System.Drawing.Point(151, 77);
            this.lblCharMP.Name = "lblCharMP";
            this.lblCharMP.Size = new System.Drawing.Size(35, 13);
            this.lblCharMP.TabIndex = 2;
            this.lblCharMP.Text = "label7";
            // 
            // cbAutoBattle
            // 
            this.cbAutoBattle.AutoSize = true;
            this.cbAutoBattle.Location = new System.Drawing.Point(16, 317);
            this.cbAutoBattle.Name = "cbAutoBattle";
            this.cbAutoBattle.Size = new System.Drawing.Size(138, 17);
            this.cbAutoBattle.TabIndex = 9;
            this.cbAutoBattle.Text = "Automatisch Angreifen?";
            this.cbAutoBattle.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 432);
            this.Controls.Add(this.cbAutoBattle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbLvLRange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGameFound);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblGameFound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTarget;
        public System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblLvL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblCharLvL;
        public System.Windows.Forms.Label lblCharMP;
        public System.Windows.Forms.Label lblCharHP;
        public System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbLvLRange;
        public System.Windows.Forms.CheckBox cbAutoBattle;
    }
}

