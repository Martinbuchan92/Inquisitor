namespace Inquisitor
{
    partial class Inquisitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inquisitor));
            this.nupBAB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nupSTR = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nupDEX = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nupWeaponEnhancementBonus = new System.Windows.Forms.NumericUpDown();
            this.btnD20 = new System.Windows.Forms.Button();
            this.txtD20 = new System.Windows.Forms.TextBox();
            this.nupLVL = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPointBlank = new System.Windows.Forms.CheckBox();
            this.chkRapidShot = new System.Windows.Forms.CheckBox();
            this.chkBane = new System.Windows.Forms.CheckBox();
            this.chkJustice = new System.Windows.Forms.CheckBox();
            this.chkDestruction = new System.Windows.Forms.CheckBox();
            this.nupLv5 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nupLv3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkEvil = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAttack = new System.Windows.Forms.TextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ChkCrit = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTotalDamage = new System.Windows.Forms.TextBox();
            this.txtDamage = new System.Windows.Forms.TextBox();
            this.btnDamage = new System.Windows.Forms.Button();
            this.chkHammerGap = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupBAB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDEX)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupWeaponEnhancementBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLVL)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupLv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLv3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // nupBAB
            // 
            this.nupBAB.Location = new System.Drawing.Point(166, 82);
            this.nupBAB.Name = "nupBAB";
            this.nupBAB.Size = new System.Drawing.Size(120, 31);
            this.nupBAB.TabIndex = 0;
            this.nupBAB.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nupBAB.ValueChanged += new System.EventHandler(this.nupBAB_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "BAB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "STR";
            // 
            // nupSTR
            // 
            this.nupSTR.Location = new System.Drawing.Point(166, 119);
            this.nupSTR.Name = "nupSTR";
            this.nupSTR.Size = new System.Drawing.Size(120, 31);
            this.nupSTR.TabIndex = 3;
            this.nupSTR.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "DEX";
            // 
            // nupDEX
            // 
            this.nupDEX.Location = new System.Drawing.Point(166, 156);
            this.nupDEX.Name = "nupDEX";
            this.nupDEX.Size = new System.Drawing.Size(120, 31);
            this.nupDEX.TabIndex = 5;
            this.nupDEX.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nupWeaponEnhancementBonus);
            this.groupBox1.Controls.Add(this.btnD20);
            this.groupBox1.Controls.Add(this.txtD20);
            this.groupBox1.Controls.Add(this.nupLVL);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nupSTR);
            this.groupBox1.Controls.Add(this.nupDEX);
            this.groupBox1.Controls.Add(this.nupBAB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 382);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "WepEnhBon";
            // 
            // nupWeaponEnhancementBonus
            // 
            this.nupWeaponEnhancementBonus.Location = new System.Drawing.Point(166, 193);
            this.nupWeaponEnhancementBonus.Name = "nupWeaponEnhancementBonus";
            this.nupWeaponEnhancementBonus.Size = new System.Drawing.Size(120, 31);
            this.nupWeaponEnhancementBonus.TabIndex = 10;
            this.nupWeaponEnhancementBonus.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnD20
            // 
            this.btnD20.Location = new System.Drawing.Point(19, 247);
            this.btnD20.Name = "btnD20";
            this.btnD20.Size = new System.Drawing.Size(120, 40);
            this.btnD20.TabIndex = 9;
            this.btnD20.Text = "D20";
            this.btnD20.UseVisualStyleBackColor = true;
            this.btnD20.Click += new System.EventHandler(this.btnD20_Click);
            // 
            // txtD20
            // 
            this.txtD20.Location = new System.Drawing.Point(166, 252);
            this.txtD20.Name = "txtD20";
            this.txtD20.Size = new System.Drawing.Size(100, 31);
            this.txtD20.TabIndex = 8;
            // 
            // nupLVL
            // 
            this.nupLVL.Location = new System.Drawing.Point(166, 45);
            this.nupLVL.Name = "nupLVL";
            this.nupLVL.Size = new System.Drawing.Size(120, 31);
            this.nupLVL.TabIndex = 7;
            this.nupLVL.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.nupLVL.ValueChanged += new System.EventHandler(this.nupLVL_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "LVL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBane);
            this.groupBox2.Controls.Add(this.chkJustice);
            this.groupBox2.Controls.Add(this.chkDestruction);
            this.groupBox2.Controls.Add(this.nupLv5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nupLv3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(349, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 382);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Judgement";
            // 
            // chkPointBlank
            // 
            this.chkPointBlank.AutoSize = true;
            this.chkPointBlank.Location = new System.Drawing.Point(21, 89);
            this.chkPointBlank.Name = "chkPointBlank";
            this.chkPointBlank.Size = new System.Drawing.Size(207, 29);
            this.chkPointBlank.TabIndex = 8;
            this.chkPointBlank.Text = "Point Blank <30ft";
            this.chkPointBlank.UseVisualStyleBackColor = true;
            // 
            // chkRapidShot
            // 
            this.chkRapidShot.AutoSize = true;
            this.chkRapidShot.Location = new System.Drawing.Point(21, 54);
            this.chkRapidShot.Name = "chkRapidShot";
            this.chkRapidShot.Size = new System.Drawing.Size(150, 29);
            this.chkRapidShot.TabIndex = 7;
            this.chkRapidShot.Text = "Rapid Shot";
            this.chkRapidShot.UseVisualStyleBackColor = true;
            // 
            // chkBane
            // 
            this.chkBane.AutoSize = true;
            this.chkBane.Location = new System.Drawing.Point(33, 223);
            this.chkBane.Name = "chkBane";
            this.chkBane.Size = new System.Drawing.Size(94, 29);
            this.chkBane.TabIndex = 6;
            this.chkBane.Text = "Bane";
            this.chkBane.UseVisualStyleBackColor = true;
            // 
            // chkJustice
            // 
            this.chkJustice.AutoSize = true;
            this.chkJustice.Location = new System.Drawing.Point(33, 158);
            this.chkJustice.Name = "chkJustice";
            this.chkJustice.Size = new System.Drawing.Size(112, 29);
            this.chkJustice.TabIndex = 5;
            this.chkJustice.Text = "Justice";
            this.chkJustice.UseVisualStyleBackColor = true;
            // 
            // chkDestruction
            // 
            this.chkDestruction.AutoSize = true;
            this.chkDestruction.Location = new System.Drawing.Point(33, 121);
            this.chkDestruction.Name = "chkDestruction";
            this.chkDestruction.Size = new System.Drawing.Size(153, 29);
            this.chkDestruction.TabIndex = 4;
            this.chkDestruction.Text = "Destruction";
            this.chkDestruction.UseVisualStyleBackColor = true;
            // 
            // nupLv5
            // 
            this.nupLv5.Location = new System.Drawing.Point(148, 82);
            this.nupLv5.Name = "nupLv5";
            this.nupLv5.Size = new System.Drawing.Size(120, 31);
            this.nupLv5.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "5 Level";
            // 
            // nupLv3
            // 
            this.nupLv3.Location = new System.Drawing.Point(148, 45);
            this.nupLv3.Name = "nupLv3";
            this.nupLv3.Size = new System.Drawing.Size(120, 31);
            this.nupLv3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "3 Level";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkEvil);
            this.groupBox3.Location = new System.Drawing.Point(726, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 146);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enemy";
            // 
            // chkEvil
            // 
            this.chkEvil.AutoSize = true;
            this.chkEvil.Location = new System.Drawing.Point(21, 47);
            this.chkEvil.Name = "chkEvil";
            this.chkEvil.Size = new System.Drawing.Size(79, 29);
            this.chkEvil.TabIndex = 0;
            this.chkEvil.Text = "Evil";
            this.chkEvil.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAttack);
            this.groupBox4.Controls.Add(this.btnAttack);
            this.groupBox4.Location = new System.Drawing.Point(16, 409);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1025, 138);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Attack";
            // 
            // txtAttack
            // 
            this.txtAttack.Location = new System.Drawing.Point(22, 35);
            this.txtAttack.Multiline = true;
            this.txtAttack.Name = "txtAttack";
            this.txtAttack.Size = new System.Drawing.Size(787, 96);
            this.txtAttack.TabIndex = 1;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(875, 87);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(144, 45);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ChkCrit);
            this.groupBox5.Controls.Add(this.btnClear);
            this.groupBox5.Controls.Add(this.txtTotalDamage);
            this.groupBox5.Controls.Add(this.txtDamage);
            this.groupBox5.Controls.Add(this.btnDamage);
            this.groupBox5.Location = new System.Drawing.Point(16, 553);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1025, 160);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Damage";
            // 
            // ChkCrit
            // 
            this.ChkCrit.AutoSize = true;
            this.ChkCrit.Location = new System.Drawing.Point(677, 107);
            this.ChkCrit.Name = "ChkCrit";
            this.ChkCrit.Size = new System.Drawing.Size(77, 29);
            this.ChkCrit.TabIndex = 2;
            this.ChkCrit.Text = "Crit";
            this.ChkCrit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(875, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 45);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTotalDamage
            // 
            this.txtTotalDamage.Location = new System.Drawing.Point(677, 49);
            this.txtTotalDamage.Name = "txtTotalDamage";
            this.txtTotalDamage.Size = new System.Drawing.Size(100, 31);
            this.txtTotalDamage.TabIndex = 3;
            // 
            // txtDamage
            // 
            this.txtDamage.Location = new System.Drawing.Point(22, 40);
            this.txtDamage.Multiline = true;
            this.txtDamage.Name = "txtDamage";
            this.txtDamage.Size = new System.Drawing.Size(618, 96);
            this.txtDamage.TabIndex = 2;
            // 
            // btnDamage
            // 
            this.btnDamage.Location = new System.Drawing.Point(875, 109);
            this.btnDamage.Name = "btnDamage";
            this.btnDamage.Size = new System.Drawing.Size(144, 45);
            this.btnDamage.TabIndex = 1;
            this.btnDamage.Text = "Damage";
            this.btnDamage.UseVisualStyleBackColor = true;
            this.btnDamage.Click += new System.EventHandler(this.btnDamage_Click);
            // 
            // chkHammerGap
            // 
            this.chkHammerGap.AutoSize = true;
            this.chkHammerGap.Checked = true;
            this.chkHammerGap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHammerGap.Location = new System.Drawing.Point(21, 123);
            this.chkHammerGap.Name = "chkHammerGap";
            this.chkHammerGap.Size = new System.Drawing.Size(206, 29);
            this.chkHammerGap.TabIndex = 1;
            this.chkHammerGap.Text = "Hammer the Gap";
            this.chkHammerGap.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkPointBlank);
            this.groupBox6.Controls.Add(this.chkHammerGap);
            this.groupBox6.Controls.Add(this.chkRapidShot);
            this.groupBox6.Location = new System.Drawing.Point(726, 170);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(315, 223);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Feats";
            // 
            // Inquisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 725);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inquisitor";
            this.Text = "Inquisitor";
            this.Load += new System.EventHandler(this.Inquisitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupBAB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDEX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupWeaponEnhancementBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLVL)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupLv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLv3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupBAB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupSTR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupDEX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nupWeaponEnhancementBonus;
        private System.Windows.Forms.Button btnD20;
        private System.Windows.Forms.TextBox txtD20;
        private System.Windows.Forms.NumericUpDown nupLVL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkBane;
        private System.Windows.Forms.CheckBox chkJustice;
        private System.Windows.Forms.CheckBox chkDestruction;
        private System.Windows.Forms.NumericUpDown nupLv5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupLv3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkEvil;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtAttack;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.TextBox txtDamage;
        private System.Windows.Forms.Button btnDamage;
        private System.Windows.Forms.CheckBox chkPointBlank;
        private System.Windows.Forms.CheckBox chkRapidShot;
        private System.Windows.Forms.CheckBox ChkCrit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTotalDamage;
        private System.Windows.Forms.CheckBox chkHammerGap;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

