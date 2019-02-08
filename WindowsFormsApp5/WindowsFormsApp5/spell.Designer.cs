namespace WindowsFormsApp5
{
    partial class spell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.s_comps = new System.Windows.Forms.Label();
            this.c_time = new System.Windows.Forms.Label();
            this.s_name = new System.Windows.Forms.Label();
            this.s_dur = new System.Windows.Forms.Label();
            this.rng = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // s_comps
            // 
            this.s_comps.AutoSize = true;
            this.s_comps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_comps.Location = new System.Drawing.Point(143, 5);
            this.s_comps.Name = "s_comps";
            this.s_comps.Size = new System.Drawing.Size(43, 13);
            this.s_comps.TabIndex = 4;
            this.s_comps.Text = "comps";
            // 
            // c_time
            // 
            this.c_time.AutoSize = true;
            this.c_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_time.Location = new System.Drawing.Point(93, 5);
            this.c_time.Name = "c_time";
            this.c_time.Size = new System.Drawing.Size(44, 13);
            this.c_time.TabIndex = 5;
            this.c_time.Text = "c_time";
            // 
            // s_name
            // 
            this.s_name.AutoSize = true;
            this.s_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_name.Location = new System.Drawing.Point(3, 5);
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(84, 13);
            this.s_name.TabIndex = 6;
            this.s_name.Text = "SPELL NAME";
            // 
            // s_dur
            // 
            this.s_dur.AutoSize = true;
            this.s_dur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_dur.Location = new System.Drawing.Point(193, 5);
            this.s_dur.Name = "s_dur";
            this.s_dur.Size = new System.Drawing.Size(25, 13);
            this.s_dur.TabIndex = 7;
            this.s_dur.Text = "dur";
            // 
            // rng
            // 
            this.rng.AutoSize = true;
            this.rng.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rng.Location = new System.Drawing.Point(230, 5);
            this.rng.Name = "rng";
            this.rng.Size = new System.Drawing.Size(39, 13);
            this.rng.TabIndex = 8;
            this.rng.Text = "range";
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(351, 0);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(30, 24);
            this.remove.TabIndex = 9;
            this.remove.Text = "x";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(299, 0);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(46, 24);
            this.edit.TabIndex = 10;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // spell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.edit);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.rng);
            this.Controls.Add(this.s_dur);
            this.Controls.Add(this.s_name);
            this.Controls.Add(this.c_time);
            this.Controls.Add(this.s_comps);
            this.Name = "spell";
            this.Size = new System.Drawing.Size(380, 25);
            this.Load += new System.EventHandler(this.spell_Load);
            this.MouseHover += new System.EventHandler(this.spell_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label s_comps;
        private System.Windows.Forms.Label c_time;
        private System.Windows.Forms.Label s_name;
        private System.Windows.Forms.Label s_dur;
        private System.Windows.Forms.Label rng;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button edit;
    }
}
