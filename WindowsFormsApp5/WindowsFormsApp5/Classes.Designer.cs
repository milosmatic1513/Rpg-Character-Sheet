namespace WindowsFormsApp5
{
    partial class Classes
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
            this.mainDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.topBar = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.topSpells = new System.Windows.Forms.FlowLayoutPanel();
            this.mainSpells = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.hitDie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.skillDesc = new System.Windows.Forms.TextBox();
            this.toolsDesc = new System.Windows.Forms.TextBox();
            this.descriptions = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainDisplay
            // 
            this.mainDisplay.AutoScroll = true;
            this.mainDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainDisplay.Location = new System.Drawing.Point(12, 121);
            this.mainDisplay.Name = "mainDisplay";
            this.mainDisplay.Size = new System.Drawing.Size(543, 167);
            this.mainDisplay.TabIndex = 1;
            // 
            // topBar
            // 
            this.topBar.AutoScroll = true;
            this.topBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topBar.Location = new System.Drawing.Point(12, 84);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(543, 38);
            this.topBar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Column";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove Column";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(306, 527);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // topSpells
            // 
            this.topSpells.AutoScroll = true;
            this.topSpells.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topSpells.Location = new System.Drawing.Point(12, 316);
            this.topSpells.Name = "topSpells";
            this.topSpells.Size = new System.Drawing.Size(543, 38);
            this.topSpells.TabIndex = 7;
            // 
            // mainSpells
            // 
            this.mainSpells.AutoScroll = true;
            this.mainSpells.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainSpells.Location = new System.Drawing.Point(12, 353);
            this.mainSpells.Name = "mainSpells";
            this.mainSpells.Size = new System.Drawing.Size(543, 164);
            this.mainSpells.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(122, 527);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 37);
            this.button4.TabIndex = 8;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // hitDie
            // 
            this.hitDie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitDie.Location = new System.Drawing.Point(660, 23);
            this.hitDie.Name = "hitDie";
            this.hitDie.Size = new System.Drawing.Size(28, 24);
            this.hitDie.TabIndex = 9;
            this.hitDie.TextChanged += new System.EventHandler(this.hitDie_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hit die :  1d";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Proficiencies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(588, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Armor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(588, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Weapons :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(588, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tools :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(588, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Saving Throws :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(588, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Skills :";
            // 
            // skillDesc
            // 
            this.skillDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillDesc.Location = new System.Drawing.Point(653, 467);
            this.skillDesc.Name = "skillDesc";
            this.skillDesc.Size = new System.Drawing.Size(149, 24);
            this.skillDesc.TabIndex = 17;
            // 
            // toolsDesc
            // 
            this.toolsDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsDesc.Location = new System.Drawing.Point(653, 267);
            this.toolsDesc.Name = "toolsDesc";
            this.toolsDesc.Size = new System.Drawing.Size(149, 24);
            this.toolsDesc.TabIndex = 18;
            // 
            // descriptions
            // 
            this.descriptions.AutoScroll = true;
            this.descriptions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptions.Location = new System.Drawing.Point(816, 31);
            this.descriptions.Name = "descriptions";
            this.descriptions.Size = new System.Drawing.Size(240, 531);
            this.descriptions.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(816, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Remove Panel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(945, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Add Panel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(132, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Class Name :";
            // 
            // className
            // 
            this.className.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.className.Location = new System.Drawing.Point(271, 12);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(151, 26);
            this.className.TabIndex = 22;
            this.className.TextChanged += new System.EventHandler(this.className_TextChanged);
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 573);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.className);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.descriptions);
            this.Controls.Add(this.toolsDesc);
            this.Controls.Add(this.skillDesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hitDie);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.topSpells);
            this.Controls.Add(this.mainSpells);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.mainDisplay);
            this.Name = "Classes";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.Classes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel mainDisplay;
        private System.Windows.Forms.FlowLayoutPanel topBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel topSpells;
        private System.Windows.Forms.FlowLayoutPanel mainSpells;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox hitDie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox skillDesc;
        private System.Windows.Forms.TextBox toolsDesc;
        private System.Windows.Forms.FlowLayoutPanel descriptions;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox className;
    }
}