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
            this.label2 = new System.Windows.Forms.Label();
            this.prof_lbl = new System.Windows.Forms.Label();
            this.ac = new System.Windows.Forms.Label();
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
            this.name = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.player_class = new System.Windows.Forms.Label();
            this.class_box = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.skills = new System.Windows.Forms.FlowLayoutPanel();
            this.toolsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spells = new System.Windows.Forms.Button();
            this.ac_plus = new System.Windows.Forms.Button();
            this.ac_minus = new System.Windows.Forms.Button();
            this.cha = new WindowsFormsApp5.Plus_Minus_Stat();
            this.wis = new WindowsFormsApp5.Plus_Minus_Stat();
            this.inte = new WindowsFormsApp5.Plus_Minus_Stat();
            this.con = new WindowsFormsApp5.Plus_Minus_Stat();
            this.dex = new WindowsFormsApp5.Plus_Minus_Stat();
            this.str = new WindowsFormsApp5.Plus_Minus_Stat();
            this.abilityScore6 = new WindowsFormsApp5.AbilityScore();
            this.abilityScore5 = new WindowsFormsApp5.AbilityScore();
            this.abilityScore4 = new WindowsFormsApp5.AbilityScore();
            this.abilityScore3 = new WindowsFormsApp5.AbilityScore();
            this.abilityScore2 = new WindowsFormsApp5.AbilityScore();
            this.abilityScore1 = new WindowsFormsApp5.AbilityScore();
            this.invertory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hp = new System.Windows.Forms.NumericUpDown();
            this.temp_hp = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_hp)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "PROFITIENCY: +";
            // 
            // prof_lbl
            // 
            this.prof_lbl.AutoSize = true;
            this.prof_lbl.BackColor = System.Drawing.Color.Transparent;
            this.prof_lbl.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prof_lbl.Location = new System.Drawing.Point(508, 146);
            this.prof_lbl.Name = "prof_lbl";
            this.prof_lbl.Size = new System.Drawing.Size(20, 19);
            this.prof_lbl.TabIndex = 9;
            this.prof_lbl.Text = "2";
            // 
            // ac
            // 
            this.ac.AutoSize = true;
            this.ac.BackColor = System.Drawing.Color.Transparent;
            this.ac.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac.Location = new System.Drawing.Point(379, 406);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(31, 19);
            this.ac.TabIndex = 12;
            this.ac.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "AC: ";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
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
            this.groupBox7.Location = new System.Drawing.Point(216, 221);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Level:";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.BackColor = System.Drawing.Color.Transparent;
            this.level.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level.Location = new System.Drawing.Point(424, 114);
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
            this.button4.Location = new System.Drawing.Point(95, 531);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "DONE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(200, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(74, 19);
            this.name.TabIndex = 32;
            this.name.Text = "NAME: ";
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(280, 13);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(211, 26);
            this.name_box.TabIndex = 33;
            this.name_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // player_class
            // 
            this.player_class.AutoSize = true;
            this.player_class.BackColor = System.Drawing.Color.Transparent;
            this.player_class.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_class.Location = new System.Drawing.Point(199, 47);
            this.player_class.Name = "player_class";
            this.player_class.Size = new System.Drawing.Size(75, 19);
            this.player_class.TabIndex = 34;
            this.player_class.Text = "CLASS:";
            // 
            // class_box
            // 
            this.class_box.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_box.FormattingEnabled = true;
            this.class_box.Items.AddRange(new object[] {
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
            this.class_box.Location = new System.Drawing.Point(280, 44);
            this.class_box.Name = "class_box";
            this.class_box.Size = new System.Drawing.Size(211, 27);
            this.class_box.TabIndex = 35;
            this.class_box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(349, 85);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 36;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(430, 85);
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
            this.skills.BackColor = System.Drawing.Color.Transparent;
            this.skills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skills.Location = new System.Drawing.Point(256, 608);
            this.skills.Name = "skills";
            this.skills.Size = new System.Drawing.Size(256, 211);
            this.skills.TabIndex = 38;
            this.skills.Click += new System.EventHandler(this.skills_Click);
            this.skills.Paint += new System.Windows.Forms.PaintEventHandler(this.skills_Paint);
            // 
            // toolsPanel
            // 
            this.toolsPanel.AutoScroll = true;
            this.toolsPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolsPanel.Location = new System.Drawing.Point(12, 645);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(190, 174);
            this.toolsPanel.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(220, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // spells
            // 
            this.spells.Location = new System.Drawing.Point(389, 235);
            this.spells.Name = "spells";
            this.spells.Size = new System.Drawing.Size(89, 23);
            this.spells.TabIndex = 42;
            this.spells.Text = "SPELLS";
            this.spells.UseVisualStyleBackColor = true;
            this.spells.Click += new System.EventHandler(this.spells_Click);
            // 
            // ac_plus
            // 
            this.ac_plus.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac_plus.Location = new System.Drawing.Point(416, 406);
            this.ac_plus.Name = "ac_plus";
            this.ac_plus.Size = new System.Drawing.Size(25, 25);
            this.ac_plus.TabIndex = 43;
            this.ac_plus.Tag = "ac";
            this.ac_plus.Text = "+";
            this.ac_plus.UseVisualStyleBackColor = true;
            this.ac_plus.Visible = false;
            this.ac_plus.Click += new System.EventHandler(this.plus_minus_stat);
            // 
            // ac_minus
            // 
            this.ac_minus.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac_minus.Location = new System.Drawing.Point(447, 406);
            this.ac_minus.Name = "ac_minus";
            this.ac_minus.Size = new System.Drawing.Size(25, 25);
            this.ac_minus.TabIndex = 44;
            this.ac_minus.Tag = "ac";
            this.ac_minus.Text = "-";
            this.ac_minus.UseVisualStyleBackColor = true;
            this.ac_minus.Visible = false;
            this.ac_minus.Click += new System.EventHandler(this.plus_minus_stat);
            // 
            // cha
            // 
            this.cha.BackColor = System.Drawing.SystemColors.Control;
            this.cha.Location = new System.Drawing.Point(121, 452);
            this.cha.Name = "cha";
            this.cha.Size = new System.Drawing.Size(35, 64);
            this.cha.TabIndex = 50;
            // 
            // wis
            // 
            this.wis.BackColor = System.Drawing.SystemColors.Control;
            this.wis.Location = new System.Drawing.Point(121, 372);
            this.wis.Name = "wis";
            this.wis.Size = new System.Drawing.Size(35, 64);
            this.wis.TabIndex = 49;
            // 
            // inte
            // 
            this.inte.BackColor = System.Drawing.SystemColors.Control;
            this.inte.Location = new System.Drawing.Point(121, 292);
            this.inte.Name = "inte";
            this.inte.Size = new System.Drawing.Size(35, 64);
            this.inte.TabIndex = 48;
            // 
            // con
            // 
            this.con.BackColor = System.Drawing.SystemColors.Control;
            this.con.Location = new System.Drawing.Point(121, 212);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(35, 64);
            this.con.TabIndex = 47;
            // 
            // dex
            // 
            this.dex.BackColor = System.Drawing.SystemColors.Control;
            this.dex.Location = new System.Drawing.Point(121, 132);
            this.dex.Name = "dex";
            this.dex.Size = new System.Drawing.Size(35, 64);
            this.dex.TabIndex = 46;
            // 
            // str
            // 
            this.str.BackColor = System.Drawing.SystemColors.Control;
            this.str.Location = new System.Drawing.Point(121, 52);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(35, 64);
            this.str.TabIndex = 45;
            // 
            // abilityScore6
            // 
            this.abilityScore6.BackColor = System.Drawing.Color.Transparent;
            this.abilityScore6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.abilityScore6.Location = new System.Drawing.Point(12, 442);
            this.abilityScore6.Name = "abilityScore6";
            this.abilityScore6.Size = new System.Drawing.Size(103, 74);
            this.abilityScore6.TabIndex = 21;
            this.abilityScore6.Load += new System.EventHandler(this.abilityScore6_Load);
            // 
            // abilityScore5
            // 
            this.abilityScore5.BackColor = System.Drawing.Color.Transparent;
            this.abilityScore5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.abilityScore5.Location = new System.Drawing.Point(12, 362);
            this.abilityScore5.Name = "abilityScore5";
            this.abilityScore5.Size = new System.Drawing.Size(103, 74);
            this.abilityScore5.TabIndex = 20;
            this.abilityScore5.Load += new System.EventHandler(this.abilityScore5_Load);
            // 
            // abilityScore4
            // 
            this.abilityScore4.BackColor = System.Drawing.Color.Transparent;
            this.abilityScore4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.abilityScore4.Location = new System.Drawing.Point(12, 282);
            this.abilityScore4.Name = "abilityScore4";
            this.abilityScore4.Size = new System.Drawing.Size(103, 74);
            this.abilityScore4.TabIndex = 19;
            this.abilityScore4.Load += new System.EventHandler(this.abilityScore4_Load);
            // 
            // abilityScore3
            // 
            this.abilityScore3.BackColor = System.Drawing.Color.Transparent;
            this.abilityScore3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.abilityScore3.Location = new System.Drawing.Point(12, 202);
            this.abilityScore3.Name = "abilityScore3";
            this.abilityScore3.Size = new System.Drawing.Size(103, 74);
            this.abilityScore3.TabIndex = 18;
            this.abilityScore3.Load += new System.EventHandler(this.abilityScore3_Load);
            // 
            // abilityScore2
            // 
            this.abilityScore2.BackColor = System.Drawing.Color.Transparent;
            this.abilityScore2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.abilityScore2.Location = new System.Drawing.Point(12, 122);
            this.abilityScore2.Name = "abilityScore2";
            this.abilityScore2.Size = new System.Drawing.Size(103, 74);
            this.abilityScore2.TabIndex = 17;
            this.abilityScore2.Load += new System.EventHandler(this.abilityScore2_Load);
            // 
            // abilityScore1
            // 
            this.abilityScore1.BackColor = System.Drawing.Color.Transparent;
            this.abilityScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.abilityScore1.Location = new System.Drawing.Point(12, 42);
            this.abilityScore1.Name = "abilityScore1";
            this.abilityScore1.Size = new System.Drawing.Size(103, 74);
            this.abilityScore1.TabIndex = 16;
            this.abilityScore1.Load += new System.EventHandler(this.abilityScore1_Load);
            // 
            // invertory
            // 
            this.invertory.Location = new System.Drawing.Point(389, 264);
            this.invertory.Name = "invertory";
            this.invertory.Size = new System.Drawing.Size(89, 23);
            this.invertory.TabIndex = 61;
            this.invertory.Text = "INVERTORY";
            this.invertory.UseVisualStyleBackColor = true;
            this.invertory.Click += new System.EventHandler(this.invertory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.temp_hp);
            this.groupBox1.Controls.Add(this.hp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(216, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 129);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "HP";
            // 
            // hp
            // 
            this.hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hp.Location = new System.Drawing.Point(6, 36);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(64, 26);
            this.hp.TabIndex = 1;
            this.hp.ValueChanged += new System.EventHandler(this.hp_ValueChanged);
            // 
            // temp_hp
            // 
            this.temp_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_hp.Location = new System.Drawing.Point(7, 91);
            this.temp_hp.Name = "temp_hp";
            this.temp_hp.Size = new System.Drawing.Size(63, 26);
            this.temp_hp.TabIndex = 2;
            this.temp_hp.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "TEMP HP";
            // 
            // cha_save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 831);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.invertory);
            this.Controls.Add(this.cha);
            this.Controls.Add(this.wis);
            this.Controls.Add(this.inte);
            this.Controls.Add(this.con);
            this.Controls.Add(this.dex);
            this.Controls.Add(this.str);
            this.Controls.Add(this.ac_minus);
            this.Controls.Add(this.ac_plus);
            this.Controls.Add(this.spells);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.skills);
            this.Controls.Add(this.toolsPanel);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.class_box);
            this.Controls.Add(this.player_class);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.name);
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
            this.Controls.Add(this.ac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prof_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "cha_save";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_hp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label prof_lbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ac;
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
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label player_class;
        private System.Windows.Forms.ComboBox class_box;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel skills;
        private System.Windows.Forms.FlowLayoutPanel toolsPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button spells;
        private System.Windows.Forms.Button ac_plus;
        private System.Windows.Forms.Button ac_minus;
        private Plus_Minus_Stat str;
        private Plus_Minus_Stat dex;
        private Plus_Minus_Stat con;
        private Plus_Minus_Stat inte;
        private Plus_Minus_Stat wis;
        private Plus_Minus_Stat cha;
        private System.Windows.Forms.Button invertory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown temp_hp;
        private System.Windows.Forms.NumericUpDown hp;
        private System.Windows.Forms.Label label3;
    }
}

