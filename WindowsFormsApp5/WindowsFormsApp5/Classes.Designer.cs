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
            this.SuspendLayout();
            // 
            // mainDisplay
            // 
            this.mainDisplay.AutoScroll = true;
            this.mainDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainDisplay.Location = new System.Drawing.Point(12, 68);
            this.mainDisplay.Name = "mainDisplay";
            this.mainDisplay.Size = new System.Drawing.Size(543, 149);
            this.mainDisplay.TabIndex = 1;
            // 
            // topBar
            // 
            this.topBar.AutoScroll = true;
            this.topBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topBar.Location = new System.Drawing.Point(12, 31);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(543, 38);
            this.topBar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Column";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove Column";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 438);
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
            this.topSpells.Location = new System.Drawing.Point(12, 235);
            this.topSpells.Name = "topSpells";
            this.topSpells.Size = new System.Drawing.Size(543, 38);
            this.topSpells.TabIndex = 7;
            // 
            // mainSpells
            // 
            this.mainSpells.AutoScroll = true;
            this.mainSpells.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainSpells.Location = new System.Drawing.Point(12, 272);
            this.mainSpells.Name = "mainSpells";
            this.mainSpells.Size = new System.Drawing.Size(543, 149);
            this.mainSpells.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(122, 438);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 37);
            this.button4.TabIndex = 8;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 487);
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
    }
}