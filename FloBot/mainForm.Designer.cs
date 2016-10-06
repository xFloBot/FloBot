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
            this.lblCharLvL = new System.Windows.Forms.Label();
            this.lblCharMP = new System.Windows.Forms.Label();
            this.lblCharHP = new System.Windows.Forms.Label();
            this.lblCharName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAutoBattle = new System.Windows.Forms.CheckBox();
            this.tbRestHP = new System.Windows.Forms.TrackBar();
            this.lblRestHP = new System.Windows.Forms.Label();
            this.tbEmHP = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEmHP = new System.Windows.Forms.Label();
            this.tbRestMP = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRestMP = new System.Windows.Forms.Label();
            this.tbEmMP = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.lblEmMP = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblExpCurrent = new System.Windows.Forms.Label();
            this.lblExpMax = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRestHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRestMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmMP)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(22, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hinsetzen bei(HP):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "HP";
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
            this.label4.Location = new System.Drawing.Point(317, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Maximaler level unterschied\r\n(+- vom Spieler Level)\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLvLRange
            // 
            this.tbLvLRange.Location = new System.Drawing.Point(334, 83);
            this.tbLvLRange.Name = "tbLvLRange";
            this.tbLvLRange.Size = new System.Drawing.Size(100, 20);
            this.tbLvLRange.TabIndex = 6;
            this.tbLvLRange.Text = "5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblLvL);
            this.groupBox1.Controls.Add(this.lblTarget);
            this.groupBox1.Controls.Add(this.lblHP);
            this.groupBox1.Location = new System.Drawing.Point(16, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 73);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gegner Übersicht";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblExpMax);
            this.groupBox2.Controls.Add(this.lblExpCurrent);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
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
            this.groupBox2.Size = new System.Drawing.Size(286, 161);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Charakter Übersicht";
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
            // lblCharMP
            // 
            this.lblCharMP.AutoSize = true;
            this.lblCharMP.Location = new System.Drawing.Point(151, 77);
            this.lblCharMP.Name = "lblCharMP";
            this.lblCharMP.Size = new System.Drawing.Size(35, 13);
            this.lblCharMP.TabIndex = 2;
            this.lblCharMP.Text = "label7";
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
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Location = new System.Drawing.Point(9, 37);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(35, 13);
            this.lblCharName.TabIndex = 2;
            this.lblCharName.Text = "label7";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "MP(gerade/max)";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Charakter";
            // 
            // cbAutoBattle
            // 
            this.cbAutoBattle.AutoSize = true;
            this.cbAutoBattle.Location = new System.Drawing.Point(319, 30);
            this.cbAutoBattle.Name = "cbAutoBattle";
            this.cbAutoBattle.Size = new System.Drawing.Size(138, 17);
            this.cbAutoBattle.TabIndex = 9;
            this.cbAutoBattle.Text = "Automatisch Angreifen?";
            this.cbAutoBattle.UseVisualStyleBackColor = true;
            // 
            // tbRestHP
            // 
            this.tbRestHP.AutoSize = false;
            this.tbRestHP.Location = new System.Drawing.Point(16, 302);
            this.tbRestHP.Maximum = 100;
            this.tbRestHP.Name = "tbRestHP";
            this.tbRestHP.Size = new System.Drawing.Size(234, 31);
            this.tbRestHP.TabIndex = 11;
            this.tbRestHP.TickFrequency = 10;
            this.tbRestHP.Value = 30;
            this.tbRestHP.Scroll += new System.EventHandler(this.tbRestHP_Scroll);
            // 
            // lblRestHP
            // 
            this.lblRestHP.AutoSize = true;
            this.lblRestHP.Location = new System.Drawing.Point(124, 286);
            this.lblRestHP.Name = "lblRestHP";
            this.lblRestHP.Size = new System.Drawing.Size(27, 13);
            this.lblRestHP.TabIndex = 12;
            this.lblRestHP.Tag = "";
            this.lblRestHP.Text = "30%";
            // 
            // tbEmHP
            // 
            this.tbEmHP.AutoSize = false;
            this.tbEmHP.Location = new System.Drawing.Point(16, 368);
            this.tbEmHP.Maximum = 100;
            this.tbEmHP.Name = "tbEmHP";
            this.tbEmHP.Size = new System.Drawing.Size(234, 31);
            this.tbEmHP.TabIndex = 11;
            this.tbEmHP.TickFrequency = 10;
            this.tbEmHP.Value = 10;
            this.tbEmHP.Scroll += new System.EventHandler(this.tbEmHP_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "HP trank bei:\r\n(Muss auf + gelegt sein)\r\n";
            // 
            // lblEmHP
            // 
            this.lblEmHP.AutoSize = true;
            this.lblEmHP.Location = new System.Drawing.Point(124, 339);
            this.lblEmHP.Name = "lblEmHP";
            this.lblEmHP.Size = new System.Drawing.Size(27, 13);
            this.lblEmHP.TabIndex = 12;
            this.lblEmHP.Tag = "";
            this.lblEmHP.Text = "10%";
            // 
            // tbRestMP
            // 
            this.tbRestMP.AutoSize = false;
            this.tbRestMP.Location = new System.Drawing.Point(256, 302);
            this.tbRestMP.Maximum = 100;
            this.tbRestMP.Name = "tbRestMP";
            this.tbRestMP.Size = new System.Drawing.Size(234, 31);
            this.tbRestMP.TabIndex = 11;
            this.tbRestMP.TickFrequency = 10;
            this.tbRestMP.Value = 5;
            this.tbRestMP.Scroll += new System.EventHandler(this.tbRestMP_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(262, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Hinsetzen bei(MP):";
            // 
            // lblRestMP
            // 
            this.lblRestMP.AutoSize = true;
            this.lblRestMP.Location = new System.Drawing.Point(364, 286);
            this.lblRestMP.Name = "lblRestMP";
            this.lblRestMP.Size = new System.Drawing.Size(21, 13);
            this.lblRestMP.TabIndex = 12;
            this.lblRestMP.Tag = "";
            this.lblRestMP.Text = "5%";
            // 
            // tbEmMP
            // 
            this.tbEmMP.AutoSize = false;
            this.tbEmMP.Location = new System.Drawing.Point(256, 368);
            this.tbEmMP.Maximum = 100;
            this.tbEmMP.Name = "tbEmMP";
            this.tbEmMP.Size = new System.Drawing.Size(234, 31);
            this.tbEmMP.TabIndex = 11;
            this.tbEmMP.TickFrequency = 10;
            this.tbEmMP.Scroll += new System.EventHandler(this.tbEmMP_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 1;
            // 
            // lblEmMP
            // 
            this.lblEmMP.AutoSize = true;
            this.lblEmMP.Location = new System.Drawing.Point(366, 336);
            this.lblEmMP.Name = "lblEmMP";
            this.lblEmMP.Size = new System.Drawing.Size(21, 13);
            this.lblEmMP.TabIndex = 12;
            this.lblEmMP.Tag = "";
            this.lblEmMP.Text = "0%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(268, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "MP trank bei:\r\n(Muss auf - gelegt sein)\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Exp gerade";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(151, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Exp benötigt";
            // 
            // lblExpCurrent
            // 
            this.lblExpCurrent.AutoSize = true;
            this.lblExpCurrent.Location = new System.Drawing.Point(9, 117);
            this.lblExpCurrent.Name = "lblExpCurrent";
            this.lblExpCurrent.Size = new System.Drawing.Size(70, 13);
            this.lblExpCurrent.TabIndex = 4;
            this.lblExpCurrent.Text = "kill a mob first";
            // 
            // lblExpMax
            // 
            this.lblExpMax.AutoSize = true;
            this.lblExpMax.Location = new System.Drawing.Point(151, 117);
            this.lblExpMax.Name = "lblExpMax";
            this.lblExpMax.Size = new System.Drawing.Size(131, 13);
            this.lblExpMax.TabIndex = 4;
            this.lblExpMax.Text = "maybe wrong after levelup";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 432);
            this.Controls.Add(this.lblEmHP);
            this.Controls.Add(this.lblEmMP);
            this.Controls.Add(this.lblRestMP);
            this.Controls.Add(this.lblRestHP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmHP);
            this.Controls.Add(this.tbEmMP);
            this.Controls.Add(this.tbRestMP);
            this.Controls.Add(this.tbRestHP);
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
            ((System.ComponentModel.ISupportInitialize)(this.tbRestHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRestMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmMP)).EndInit();
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
        public System.Windows.Forms.TrackBar tbRestHP;
        private System.Windows.Forms.Label lblRestHP;
        public System.Windows.Forms.TrackBar tbEmHP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEmHP;
        public System.Windows.Forms.TrackBar tbRestMP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRestMP;
        public System.Windows.Forms.TrackBar tbEmMP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblEmMP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lblExpMax;
        public System.Windows.Forms.Label lblExpCurrent;
    }
}

