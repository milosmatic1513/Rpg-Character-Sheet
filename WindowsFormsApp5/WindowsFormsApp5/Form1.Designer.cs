namespace WindowsFormsApp5
{
    partial class cha_save
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
            this.button1 = new System.Windows.Forms.Button();
            this.str_button = new System.Windows.Forms.Button();
            this.dex_button = new System.Windows.Forms.Button();
            this.cons_button = new System.Windows.Forms.Button();
            this.intel_button = new System.Windows.Forms.Button();
            this.wis_button = new System.Windows.Forms.Button();
            this.cha_button = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.prof_lbl = new System.Windows.Forms.Label();
            this.ac_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.wis_save = new System.Windows.Forms.CheckBox();
            this.dex_save = new System.Windows.Forms.CheckBox();
            this.chaa_save = new System.Windows.Forms.CheckBox();
            this.intel_save = new System.Windows.Forms.CheckBox();
            this.cons_save = new System.Windows.Forms.CheckBox();
            this.str_save = new System.Windows.Forms.CheckBox();
            this.cha_save_mod = new System.Windows.Forms.Label();
            this.wis_save_mod = new System.Windows.Forms.Label();
            this.intel_save_mod = new System.Windows.Forms.Label();
            this.cons_save_mod = new System.Windows.Forms.Label();
            this.dex_save_mod = new System.Windows.Forms.Label();
            this.str_save_mod = new System.Windows.Forms.Label();
            this.abilityScore6 = new WindowsFormsApp5.AbilityScore();
            this.abilityScore5 = new WindowsFormsApp5.AbilityScore();
            this.abilityScore4 = new WindowsFormsApp5.AbilityScore();
            this.abilityScore3 = new WindowsFormsApp5.AbilityScore();
            this.abilityScore2 = new WindowsFormsApp5.AbilityScore();
            this.abilityScore1 = new WindowsFormsApp5.AbilityScore();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "LEVEL UP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.lvl_up);
            // 
            // str_button
            // 
            this.str_button.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.str_button.Location = new System.Drawing.Point(124, 56);
            this.str_button.Name = "str_button";
            this.str_button.Size = new System.Drawing.Size(41, 42);
            this.str_button.TabIndex = 2;
            this.str_button.Text = "+";
            this.str_button.UseVisualStyleBackColor = true;
            this.str_button.Visible = false;
            this.str_button.Click += new System.EventHandler(this.str_button_Click);
            // 
            // dex_button
            // 
            this.dex_button.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dex_button.Location = new System.Drawing.Point(124, 137);
            this.dex_button.Name = "dex_button";
            this.dex_button.Size = new System.Drawing.Size(41, 42);
            this.dex_button.TabIndex = 4;
            this.dex_button.Text = "+";
            this.dex_button.UseVisualStyleBackColor = true;
            this.dex_button.Visible = false;
            this.dex_button.Click += new System.EventHandler(this.dex_button_Click);
            // 
            // cons_button
            // 
            this.cons_button.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cons_button.Location = new System.Drawing.Point(124, 218);
            this.cons_button.Name = "cons_button";
            this.cons_button.Size = new System.Drawing.Size(41, 42);
            this.cons_button.TabIndex = 4;
            this.cons_button.Text = "+";
            this.cons_button.UseVisualStyleBackColor = true;
            this.cons_button.Visible = false;
            this.cons_button.Click += new System.EventHandler(this.cons_button_Click);
            // 
            // intel_button
            // 
            this.intel_button.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intel_button.Location = new System.Drawing.Point(124, 301);
            this.intel_button.Name = "intel_button";
            this.intel_button.Size = new System.Drawing.Size(41, 42);
            this.intel_button.TabIndex = 4;
            this.intel_button.Text = "+";
            this.intel_button.UseVisualStyleBackColor = true;
            this.intel_button.Visible = false;
            this.intel_button.Click += new System.EventHandler(this.intel_button_Click);
            // 
            // wis_button
            // 
            this.wis_button.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wis_button.Location = new System.Drawing.Point(124, 381);
            this.wis_button.Name = "wis_button";
            this.wis_button.Size = new System.Drawing.Size(41, 42);
            this.wis_button.TabIndex = 4;
            this.wis_button.Text = "+";
            this.wis_button.UseVisualStyleBackColor = true;
            this.wis_button.Visible = false;
            this.wis_button.Click += new System.EventHandler(this.wis_button_Click);
            // 
            // cha_button
            // 
            this.cha_button.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cha_button.Location = new System.Drawing.Point(124, 463);
            this.cha_button.Name = "cha_button";
            this.cha_button.Size = new System.Drawing.Size(41, 42);
            this.cha_button.TabIndex = 6;
            this.cha_button.Text = "+";
            this.cha_button.UseVisualStyleBackColor = true;
            this.cha_button.Visible = false;
            this.cha_button.Click += new System.EventHandler(this.cha_button_Click);
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(90, 530);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(75, 23);
            this.done.TabIndex = 7;
            this.done.Text = "DONE";
            this.done.UseVisualStyleBackColor = true;
            this.done.Visible = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "PROFITIENCY: +";
            // 
            // prof_lbl
            // 
            this.prof_lbl.AutoSize = true;
            this.prof_lbl.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prof_lbl.Location = new System.Drawing.Point(352, 22);
            this.prof_lbl.Name = "prof_lbl";
            this.prof_lbl.Size = new System.Drawing.Size(20, 19);
            this.prof_lbl.TabIndex = 9;
            this.prof_lbl.Text = "2";
            // 
            // ac_button
            // 
            this.ac_button.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac_button.Location = new System.Drawing.Point(205, 101);
            this.ac_button.Name = "ac_button";
            this.ac_button.Size = new System.Drawing.Size(49, 28);
            this.ac_button.TabIndex = 13;
            this.ac_button.Text = "+";
            this.ac_button.UseVisualStyleBackColor = true;
            this.ac_button.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "AC: ";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.wis_save);
            this.groupBox7.Controls.Add(this.dex_save);
            this.groupBox7.Controls.Add(this.chaa_save);
            this.groupBox7.Controls.Add(this.intel_save);
            this.groupBox7.Controls.Add(this.cons_save);
            this.groupBox7.Controls.Add(this.str_save);
            this.groupBox7.Controls.Add(this.cha_save_mod);
            this.groupBox7.Controls.Add(this.wis_save_mod);
            this.groupBox7.Controls.Add(this.intel_save_mod);
            this.groupBox7.Controls.Add(this.cons_save_mod);
            this.groupBox7.Controls.Add(this.dex_save_mod);
            this.groupBox7.Controls.Add(this.str_save_mod);
            this.groupBox7.Location = new System.Drawing.Point(205, 135);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(167, 154);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            // 
            // wis_save
            // 
            this.wis_save.AutoSize = true;
            this.wis_save.Location = new System.Drawing.Point(16, 96);
            this.wis_save.Name = "wis_save";
            this.wis_save.Size = new System.Drawing.Size(72, 17);
            this.wis_save.TabIndex = 17;
            this.wis_save.Text = "WISDOM";
            this.wis_save.UseVisualStyleBackColor = true;
            this.wis_save.CheckedChanged += new System.EventHandler(this.wis_save_CheckedChanged);
            // 
            // dex_save
            // 
            this.dex_save.AutoSize = true;
            this.dex_save.Location = new System.Drawing.Point(16, 40);
            this.dex_save.Name = "dex_save";
            this.dex_save.Size = new System.Drawing.Size(87, 17);
            this.dex_save.TabIndex = 16;
            this.dex_save.Text = "DEXTERITY";
            this.dex_save.UseVisualStyleBackColor = true;
            this.dex_save.CheckedChanged += new System.EventHandler(this.dex_save_CheckedChanged);
            // 
            // chaa_save
            // 
            this.chaa_save.AutoSize = true;
            this.chaa_save.Location = new System.Drawing.Point(16, 116);
            this.chaa_save.Name = "chaa_save";
            this.chaa_save.Size = new System.Drawing.Size(82, 17);
            this.chaa_save.TabIndex = 15;
            this.chaa_save.Text = "CHARISMA";
            this.chaa_save.UseVisualStyleBackColor = true;
            this.chaa_save.CheckedChanged += new System.EventHandler(this.cha_save_CheckedChanged);
            // 
            // intel_save
            // 
            this.intel_save.AutoSize = true;
            this.intel_save.Location = new System.Drawing.Point(16, 77);
            this.intel_save.Name = "intel_save";
            this.intel_save.Size = new System.Drawing.Size(97, 17);
            this.intel_save.TabIndex = 14;
            this.intel_save.Text = "INTELIGENCE";
            this.intel_save.UseVisualStyleBackColor = true;
            this.intel_save.CheckedChanged += new System.EventHandler(this.intel_save_CheckedChanged);
            // 
            // cons_save
            // 
            this.cons_save.AutoSize = true;
            this.cons_save.Location = new System.Drawing.Point(16, 59);
            this.cons_save.Name = "cons_save";
            this.cons_save.Size = new System.Drawing.Size(97, 17);
            this.cons_save.TabIndex = 13;
            this.cons_save.Text = "CONSTUTION";
            this.cons_save.UseVisualStyleBackColor = true;
            this.cons_save.CheckedChanged += new System.EventHandler(this.cons_save_CheckedChanged);
            // 
            // str_save
            // 
            this.str_save.AutoSize = true;
            this.str_save.Location = new System.Drawing.Point(16, 20);
            this.str_save.Name = "str_save";
            this.str_save.Size = new System.Drawing.Size(86, 17);
            this.str_save.TabIndex = 12;
            this.str_save.Text = "STRENGTH";
            this.str_save.UseVisualStyleBackColor = true;
            this.str_save.CheckedChanged += new System.EventHandler(this.str_save_CheckedChanged);
            // 
            // cha_save_mod
            // 
            this.cha_save_mod.AutoSize = true;
            this.cha_save_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cha_save_mod.Location = new System.Drawing.Point(118, 117);
            this.cha_save_mod.Name = "cha_save_mod";
            this.cha_save_mod.Size = new System.Drawing.Size(21, 13);
            this.cha_save_mod.TabIndex = 11;
            this.cha_save_mod.Text = "+0";
            this.cha_save_mod.Visible = false;
            // 
            // wis_save_mod
            // 
            this.wis_save_mod.AutoSize = true;
            this.wis_save_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wis_save_mod.Location = new System.Drawing.Point(118, 97);
            this.wis_save_mod.Name = "wis_save_mod";
            this.wis_save_mod.Size = new System.Drawing.Size(21, 13);
            this.wis_save_mod.TabIndex = 10;
            this.wis_save_mod.Text = "+0";
            this.wis_save_mod.Visible = false;
            // 
            // intel_save_mod
            // 
            this.intel_save_mod.AutoSize = true;
            this.intel_save_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intel_save_mod.Location = new System.Drawing.Point(118, 78);
            this.intel_save_mod.Name = "intel_save_mod";
            this.intel_save_mod.Size = new System.Drawing.Size(21, 13);
            this.intel_save_mod.TabIndex = 9;
            this.intel_save_mod.Text = "+0";
            this.intel_save_mod.Visible = false;
            // 
            // cons_save_mod
            // 
            this.cons_save_mod.AutoSize = true;
            this.cons_save_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cons_save_mod.Location = new System.Drawing.Point(118, 59);
            this.cons_save_mod.Name = "cons_save_mod";
            this.cons_save_mod.Size = new System.Drawing.Size(21, 13);
            this.cons_save_mod.TabIndex = 8;
            this.cons_save_mod.Text = "+0";
            this.cons_save_mod.Visible = false;
            // 
            // dex_save_mod
            // 
            this.dex_save_mod.AutoSize = true;
            this.dex_save_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dex_save_mod.Location = new System.Drawing.Point(118, 40);
            this.dex_save_mod.Name = "dex_save_mod";
            this.dex_save_mod.Size = new System.Drawing.Size(21, 13);
            this.dex_save_mod.TabIndex = 7;
            this.dex_save_mod.Text = "+0";
            this.dex_save_mod.Visible = false;
            // 
            // str_save_mod
            // 
            this.str_save_mod.AutoSize = true;
            this.str_save_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.str_save_mod.Location = new System.Drawing.Point(118, 21);
            this.str_save_mod.Name = "str_save_mod";
            this.str_save_mod.Size = new System.Drawing.Size(21, 13);
            this.str_save_mod.TabIndex = 6;
            this.str_save_mod.Text = "+0";
            this.str_save_mod.Visible = false;
            // 
            // abilityScore6
            // 
            this.abilityScore6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.abilityScore6.Location = new System.Drawing.Point(12, 442);
            this.abilityScore6.Name = "abilityScore6";
            this.abilityScore6.Size = new System.Drawing.Size(103, 74);
            this.abilityScore6.TabIndex = 21;
            this.abilityScore6.Load += new System.EventHandler(this.abilityScore6_Load);
            // 
            // abilityScore5
            // 
            this.abilityScore5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.abilityScore5.Location = new System.Drawing.Point(12, 362);
            this.abilityScore5.Name = "abilityScore5";
            this.abilityScore5.Size = new System.Drawing.Size(103, 74);
            this.abilityScore5.TabIndex = 20;
            this.abilityScore5.Load += new System.EventHandler(this.abilityScore5_Load);
            // 
            // abilityScore4
            // 
            this.abilityScore4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.abilityScore4.Location = new System.Drawing.Point(12, 282);
            this.abilityScore4.Name = "abilityScore4";
            this.abilityScore4.Size = new System.Drawing.Size(103, 74);
            this.abilityScore4.TabIndex = 19;
            this.abilityScore4.Load += new System.EventHandler(this.abilityScore4_Load);
            // 
            // abilityScore3
            // 
            this.abilityScore3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.abilityScore3.Location = new System.Drawing.Point(12, 202);
            this.abilityScore3.Name = "abilityScore3";
            this.abilityScore3.Size = new System.Drawing.Size(103, 74);
            this.abilityScore3.TabIndex = 18;
            this.abilityScore3.Load += new System.EventHandler(this.abilityScore3_Load);
            // 
            // abilityScore2
            // 
            this.abilityScore2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.abilityScore2.Location = new System.Drawing.Point(12, 122);
            this.abilityScore2.Name = "abilityScore2";
            this.abilityScore2.Size = new System.Drawing.Size(103, 74);
            this.abilityScore2.TabIndex = 17;
            this.abilityScore2.Load += new System.EventHandler(this.abilityScore2_Load);
            // 
            // abilityScore1
            // 
            this.abilityScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.abilityScore1.Location = new System.Drawing.Point(12, 42);
            this.abilityScore1.Name = "abilityScore1";
            this.abilityScore1.Size = new System.Drawing.Size(103, 74);
            this.abilityScore1.TabIndex = 16;
            this.abilityScore1.Load += new System.EventHandler(this.abilityScore1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "1";
            // 
            // cha_save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 603);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abilityScore6);
            this.Controls.Add(this.abilityScore5);
            this.Controls.Add(this.abilityScore4);
            this.Controls.Add(this.abilityScore3);
            this.Controls.Add(this.abilityScore2);
            this.Controls.Add(this.abilityScore1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.ac_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prof_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.done);
            this.Controls.Add(this.cha_button);
            this.Controls.Add(this.wis_button);
            this.Controls.Add(this.intel_button);
            this.Controls.Add(this.cons_button);
            this.Controls.Add(this.dex_button);
            this.Controls.Add(this.str_button);
            this.Controls.Add(this.button1);
            this.Name = "cha_save";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button str_button;
        private System.Windows.Forms.Button dex_button;
        private System.Windows.Forms.Button cons_button;
        private System.Windows.Forms.Button intel_button;
        private System.Windows.Forms.Button wis_button;
        private System.Windows.Forms.Button cha_button;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label prof_lbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ac_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label cha_save_mod;
        private System.Windows.Forms.Label wis_save_mod;
        private System.Windows.Forms.Label intel_save_mod;
        private System.Windows.Forms.Label cons_save_mod;
        private System.Windows.Forms.Label dex_save_mod;
        private System.Windows.Forms.Label str_save_mod;
        private System.Windows.Forms.CheckBox wis_save;
        private System.Windows.Forms.CheckBox dex_save;
        private System.Windows.Forms.CheckBox chaa_save;
        private System.Windows.Forms.CheckBox intel_save;
        private System.Windows.Forms.CheckBox cons_save;
        private System.Windows.Forms.CheckBox str_save;
        private AbilityScore abilityScore1;
        private AbilityScore abilityScore2;
        private AbilityScore abilityScore3;
        private AbilityScore abilityScore4;
        private AbilityScore abilityScore5;
        private AbilityScore abilityScore6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

