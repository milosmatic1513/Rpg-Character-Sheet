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
            this.con_save = new System.Windows.Forms.CheckBox();
            this.str_save = new System.Windows.Forms.CheckBox();
            this.cha_save_mod = new System.Windows.Forms.Label();
            this.wis_save_mod = new System.Windows.Forms.Label();
            this.int_save_mod = new System.Windows.Forms.Label();
            this.con_save_mod = new System.Windows.Forms.Label();
            this.dex_save_mod = new System.Windows.Forms.Label();
            this.str_save_mod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.str_minus = new System.Windows.Forms.Button();
            this.dex_minus = new System.Windows.Forms.Button();
            this.con_minus = new System.Windows.Forms.Button();
            this.int_minus = new System.Windows.Forms.Button();
            this.wis_minus = new System.Windows.Forms.Button();
            this.cha_minus = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.player_class = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.skills = new System.Windows.Forms.FlowLayoutPanel();
            this.abilityScore6 = new WindowsFormsApp5.AbilityScore();
            this.abilityScore5 = new WindowsFormsApp5.AbilityScore();
            this.abilityScore4 = new WindowsFormsApp5.AbilityScore();
            this.abilityScore3 = new WindowsFormsApp5.AbilityScore();
            this.abilityScore2 = new WindowsFormsApp5.AbilityScore();
            this.abilityScore1 = new WindowsFormsApp5.AbilityScore();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 13);
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
            this.str_button.Location = new System.Drawing.Point(124, 50);
            this.str_button.Name = "str_button";
            this.str_button.Size = new System.Drawing.Size(25, 25);
            this.str_button.TabIndex = 2;
            this.str_button.Tag = "str";
            this.str_button.Text = "+";
            this.str_button.UseVisualStyleBackColor = true;
            this.str_button.Visible = false;
            this.str_button.Click += new System.EventHandler(this.plus_minus_stat);
            // 
            // dex_button
            // 
            this.dex_button.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dex_button.Location = new System.Drawing.Point(124, 130);
            this.dex_button.Name = "dex_button";
            this.dex_button.Size = new System.Drawing.Size(25, 25);
            this.dex_button.TabIndex = 4;
            this.dex_button.Tag = "dex";
            this.dex_button.Text = "+";
            this.dex_button.UseVisualStyleBackColor = true;
            this.dex_button.Visible = false;
            this.dex_button.Click += new System.EventHandler(this.plus_minus_stat);
            // 
            // cons_button
            // 
            this.cons_button.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cons_button.Location = new System.Drawing.Point(124, 211);
            this.cons_button.Name = "cons_button";
            this.cons_button.Size = new System.Drawing.Size(25, 25);
            this.cons_button.TabIndex = 4;
            this.cons_button.Tag = "con";
            this.cons_button.Text = "+";
            this.cons_button.UseVisualStyleBackColor = true;
            this.cons_button.Visible = false;
            this.cons_button.Click += new System.EventHandler(this.plus_minus_stat);
            // 
            // intel_button
            // 
            this.intel_button.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intel_button.Location = new System.Drawing.Point(124, 291);
            this.intel_button.Name = "intel_button";
            this.intel_button.Size = new System.Drawing.Size(25, 25);
            this.intel_button.TabIndex = 4;
            this.intel_button.Tag = "int";
            this.intel_button.Text = "+";
            this.intel_button.UseVisualStyleBackColor = true;
            this.intel_button.Visible = false;
            this.intel_button.Click += new System.EventHandler(this.plus_minus_stat);
            // 
            // wis_button
            // 
            this.wis_button.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wis_button.Location = new System.Drawing.Point(124, 369);
            this.wis_button.Name = "wis_button";
            this.wis_button.Size = new System.Drawing.Size(25, 25);
            this.wis_button.TabIndex = 4;
            this.wis_button.Tag = "wis";
            this.wis_button.Text = "+";
            this.wis_button.UseVisualStyleBackColor = true;
            this.wis_button.Visible = false;
            this.wis_button.Click += new System.EventHandler(this.plus_minus_stat);
            // 
            // cha_button
            // 
            this.cha_button.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cha_button.Location = new System.Drawing.Point(124, 451);
            this.cha_button.Name = "cha_button";
            this.cha_button.Size = new System.Drawing.Size(25, 25);
            this.cha_button.TabIndex = 6;
            this.cha_button.Tag = "cha";
            this.cha_button.Text = "+";
            this.cha_button.UseVisualStyleBackColor = true;
            this.cha_button.Visible = false;
            this.cha_button.Click += new System.EventHandler(this.plus_minus_stat);
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(12, 530);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(75, 23);
            this.done.TabIndex = 7;
            this.done.Text = "READY";
            this.done.UseVisualStyleBackColor = true;
            this.done.Visible = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "PROFITIENCY: +";
            // 
            // prof_lbl
            // 
            this.prof_lbl.AutoSize = true;
            this.prof_lbl.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prof_lbl.Location = new System.Drawing.Point(362, 97);
            this.prof_lbl.Name = "prof_lbl";
            this.prof_lbl.Size = new System.Drawing.Size(20, 19);
            this.prof_lbl.TabIndex = 9;
            this.prof_lbl.Text = "2";
            // 
            // ac_button
            // 
            this.ac_button.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac_button.Location = new System.Drawing.Point(215, 176);
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
            this.label5.Location = new System.Drawing.Point(247, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 154);
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
            this.groupBox7.Controls.Add(this.con_save);
            this.groupBox7.Controls.Add(this.str_save);
            this.groupBox7.Controls.Add(this.cha_save_mod);
            this.groupBox7.Controls.Add(this.wis_save_mod);
            this.groupBox7.Controls.Add(this.int_save_mod);
            this.groupBox7.Controls.Add(this.con_save_mod);
            this.groupBox7.Controls.Add(this.dex_save_mod);
            this.groupBox7.Controls.Add(this.str_save_mod);
            this.groupBox7.Location = new System.Drawing.Point(304, 130);
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
            this.wis_save.Tag = "wis";
            this.wis_save.Text = "WISDOM";
            this.wis_save.UseVisualStyleBackColor = true;
            this.wis_save.CheckedChanged += new System.EventHandler(this.saving_check);
            // 
            // dex_save
            // 
            this.dex_save.AutoSize = true;
            this.dex_save.Location = new System.Drawing.Point(16, 40);
            this.dex_save.Name = "dex_save";
            this.dex_save.Size = new System.Drawing.Size(87, 17);
            this.dex_save.TabIndex = 16;
            this.dex_save.Tag = "dex";
            this.dex_save.Text = "DEXTERITY";
            this.dex_save.UseVisualStyleBackColor = true;
            this.dex_save.CheckedChanged += new System.EventHandler(this.saving_check);
            // 
            // chaa_save
            // 
            this.chaa_save.AutoSize = true;
            this.chaa_save.Location = new System.Drawing.Point(16, 116);
            this.chaa_save.Name = "chaa_save";
            this.chaa_save.Size = new System.Drawing.Size(82, 17);
            this.chaa_save.TabIndex = 15;
            this.chaa_save.Tag = "cha";
            this.chaa_save.Text = "CHARISMA";
            this.chaa_save.UseVisualStyleBackColor = true;
            this.chaa_save.CheckedChanged += new System.EventHandler(this.saving_check);
            // 
            // intel_save
            // 
            this.intel_save.AutoSize = true;
            this.intel_save.Location = new System.Drawing.Point(16, 77);
            this.intel_save.Name = "intel_save";
            this.intel_save.Size = new System.Drawing.Size(97, 17);
            this.intel_save.TabIndex = 14;
            this.intel_save.Tag = "int";
            this.intel_save.Text = "INTELIGENCE";
            this.intel_save.UseVisualStyleBackColor = true;
            this.intel_save.CheckedChanged += new System.EventHandler(this.saving_check);
            // 
            // con_save
            // 
            this.con_save.AutoSize = true;
            this.con_save.Location = new System.Drawing.Point(16, 59);
            this.con_save.Name = "con_save";
            this.con_save.Size = new System.Drawing.Size(97, 17);
            this.con_save.TabIndex = 13;
            this.con_save.Tag = "con";
            this.con_save.Text = "CONSTUTION";
            this.con_save.UseVisualStyleBackColor = true;
            this.con_save.CheckedChanged += new System.EventHandler(this.saving_check);
            // 
            // str_save
            // 
            this.str_save.AutoSize = true;
            this.str_save.Location = new System.Drawing.Point(16, 20);
            this.str_save.Name = "str_save";
            this.str_save.Size = new System.Drawing.Size(86, 17);
            this.str_save.TabIndex = 12;
            this.str_save.Tag = "str";
            this.str_save.Text = "STRENGTH";
            this.str_save.UseVisualStyleBackColor = true;
            this.str_save.CheckedChanged += new System.EventHandler(this.saving_check);
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
            // int_save_mod
            // 
            this.int_save_mod.AutoSize = true;
            this.int_save_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.int_save_mod.Location = new System.Drawing.Point(118, 78);
            this.int_save_mod.Name = "int_save_mod";
            this.int_save_mod.Size = new System.Drawing.Size(21, 13);
            this.int_save_mod.TabIndex = 9;
            this.int_save_mod.Text = "+0";
            this.int_save_mod.Visible = false;
            // 
            // con_save_mod
            // 
            this.con_save_mod.AutoSize = true;
            this.con_save_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_save_mod.Location = new System.Drawing.Point(118, 59);
            this.con_save_mod.Name = "con_save_mod";
            this.con_save_mod.Size = new System.Drawing.Size(21, 13);
            this.con_save_mod.TabIndex = 8;
            this.con_save_mod.Text = "+0";
            this.con_save_mod.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Level:";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level.Location = new System.Drawing.Point(493, 97);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(20, 19);
            this.level.TabIndex = 23;
            this.level.Text = "1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "EDIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(95, 530);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "DONE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // str_minus
            // 
            this.str_minus.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.str_minus.Location = new System.Drawing.Point(124, 81);
            this.str_minus.Name = "str_minus";
            this.str_minus.Size = new System.Drawing.Size(25, 25);
            this.str_minus.TabIndex = 26;
            this.str_minus.Tag = "str";
            this.str_minus.Text = "-";
            this.str_minus.UseVisualStyleBackColor = true;
            this.str_minus.Visible = false;
            this.str_minus.Click += new System.EventHandler(this.plus_minus_stat);
            // 
            // dex_minus
            // 
            this.dex_minus.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dex_minus.Location = new System.Drawing.Point(124, 161);
            this.dex_minus.Name = "dex_minus";
            this.dex_minus.Size = new System.Drawing.Size(25, 25);
            this.dex_minus.TabIndex = 27;
            this.dex_minus.Tag = "dex";
            this.dex_minus.Text = "-";
            this.dex_minus.UseVisualStyleBackColor = true;
            this.dex_minus.Visible = false;
            this.dex_minus.Click += new System.EventHandler(this.plus_minus_stat);
            // 
            // con_minus
            // 
            this.con_minus.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_minus.Location = new System.Drawing.Point(124, 242);
            this.con_minus.Name = "con_minus";
            this.con_minus.Size = new System.Drawing.Size(25, 25);
            this.con_minus.TabIndex = 28;
            this.con_minus.Tag = "con";
            this.con_minus.Text = "-";
            this.con_minus.UseVisualStyleBackColor = true;
            this.con_minus.Visible = false;
            this.con_minus.Click += new System.EventHandler(this.plus_minus_stat);
            // 
            // int_minus
            // 
            this.int_minus.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.int_minus.Location = new System.Drawing.Point(124, 322);
            this.int_minus.Name = "int_minus";
            this.int_minus.Size = new System.Drawing.Size(25, 25);
            this.int_minus.TabIndex = 29;
            this.int_minus.Tag = "int";
            this.int_minus.Text = "-";
            this.int_minus.UseVisualStyleBackColor = true;
            this.int_minus.Visible = false;
            this.int_minus.Click += new System.EventHandler(this.plus_minus_stat);
            // 
            // wis_minus
            // 
            this.wis_minus.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wis_minus.Location = new System.Drawing.Point(124, 400);
            this.wis_minus.Name = "wis_minus";
            this.wis_minus.Size = new System.Drawing.Size(25, 25);
            this.wis_minus.TabIndex = 30;
            this.wis_minus.Tag = "wis";
            this.wis_minus.Text = "-";
            this.wis_minus.UseVisualStyleBackColor = true;
            this.wis_minus.Visible = false;
            this.wis_minus.Click += new System.EventHandler(this.plus_minus_stat);
            // 
            // cha_minus
            // 
            this.cha_minus.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cha_minus.Location = new System.Drawing.Point(124, 482);
            this.cha_minus.Name = "cha_minus";
            this.cha_minus.Size = new System.Drawing.Size(25, 25);
            this.cha_minus.TabIndex = 31;
            this.cha_minus.Tag = "cha";
            this.cha_minus.Text = "-";
            this.cha_minus.UseVisualStyleBackColor = true;
            this.cha_minus.Visible = false;
            this.cha_minus.Click += new System.EventHandler(this.plus_minus_stat);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(202, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(74, 19);
            this.name.TabIndex = 32;
            this.name.Text = "NAME: ";
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(282, 19);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(211, 26);
            this.name_box.TabIndex = 33;
            this.name_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // player_class
            // 
            this.player_class.AutoSize = true;
            this.player_class.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_class.Location = new System.Drawing.Point(201, 53);
            this.player_class.Name = "player_class";
            this.player_class.Size = new System.Drawing.Size(75, 19);
            this.player_class.TabIndex = 34;
            this.player_class.Text = "CLASS:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard"});
            this.comboBox1.Location = new System.Drawing.Point(282, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 27);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 559);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 36;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(93, 559);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 37;
            this.load.Text = "LOAD";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // skills
            // 
            this.skills.AutoScroll = true;
            this.skills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skills.Location = new System.Drawing.Point(251, 311);
            this.skills.Name = "skills";
            this.skills.Size = new System.Drawing.Size(220, 222);
            this.skills.TabIndex = 38;
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
            // cha_save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 603);
            this.Controls.Add(this.skills);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.player_class);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cha_minus);
            this.Controls.Add(this.wis_minus);
            this.Controls.Add(this.int_minus);
            this.Controls.Add(this.con_minus);
            this.Controls.Add(this.dex_minus);
            this.Controls.Add(this.str_minus);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.level);
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
        private System.Windows.Forms.Label int_save_mod;
        private System.Windows.Forms.Label con_save_mod;
        private System.Windows.Forms.Label dex_save_mod;
        private System.Windows.Forms.Label str_save_mod;
        private System.Windows.Forms.CheckBox wis_save;
        private System.Windows.Forms.CheckBox dex_save;
        private System.Windows.Forms.CheckBox chaa_save;
        private System.Windows.Forms.CheckBox intel_save;
        private System.Windows.Forms.CheckBox con_save;
        private System.Windows.Forms.CheckBox str_save;
        private AbilityScore abilityScore1;
        private AbilityScore abilityScore2;
        private AbilityScore abilityScore3;
        private AbilityScore abilityScore4;
        private AbilityScore abilityScore5;
        private AbilityScore abilityScore6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button str_minus;
        private System.Windows.Forms.Button dex_minus;
        private System.Windows.Forms.Button con_minus;
        private System.Windows.Forms.Button int_minus;
        private System.Windows.Forms.Button wis_minus;
        private System.Windows.Forms.Button cha_minus;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label player_class;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel skills;
    }
}

