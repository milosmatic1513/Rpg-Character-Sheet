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
            this.remove = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.s_name = new System.Windows.Forms.TextBox();
            this.c_time = new System.Windows.Forms.TextBox();
            this.s_comps = new System.Windows.Forms.TextBox();
            this.s_dur = new System.Windows.Forms.TextBox();
            this.rng = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(361, -1);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(30, 24);
            this.remove.TabIndex = 3;
            this.remove.Text = "x";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(313, -1);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(46, 24);
            this.edit.TabIndex = 2;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // s_name
            // 
            this.s_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_name.Location = new System.Drawing.Point(4, 1);
            this.s_name.Name = "s_name";
            this.s_name.ReadOnly = true;
            this.s_name.Size = new System.Drawing.Size(92, 20);
            this.s_name.TabIndex = 12;
            // 
            // c_time
            // 
            this.c_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_time.Location = new System.Drawing.Point(102, 1);
            this.c_time.Name = "c_time";
            this.c_time.ReadOnly = true;
            this.c_time.Size = new System.Drawing.Size(43, 20);
            this.c_time.TabIndex = 13;
            // 
            // s_comps
            // 
            this.s_comps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_comps.Location = new System.Drawing.Point(151, 1);
            this.s_comps.Name = "s_comps";
            this.s_comps.ReadOnly = true;
            this.s_comps.Size = new System.Drawing.Size(47, 20);
            this.s_comps.TabIndex = 14;
            // 
            // s_dur
            // 
            this.s_dur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_dur.Location = new System.Drawing.Point(204, 1);
            this.s_dur.Name = "s_dur";
            this.s_dur.ReadOnly = true;
            this.s_dur.Size = new System.Drawing.Size(47, 20);
            this.s_dur.TabIndex = 15;
            // 
            // rng
            // 
            this.rng.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rng.Location = new System.Drawing.Point(257, 1);
            this.rng.Name = "rng";
            this.rng.ReadOnly = true;
            this.rng.Size = new System.Drawing.Size(50, 20);
            this.rng.TabIndex = 16;
            // 
            // spell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rng);
            this.Controls.Add(this.s_dur);
            this.Controls.Add(this.s_comps);
            this.Controls.Add(this.c_time);
            this.Controls.Add(this.s_name);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.remove);
            this.Name = "spell";
            this.Size = new System.Drawing.Size(392, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.TextBox s_name;
        private System.Windows.Forms.TextBox c_time;
        private System.Windows.Forms.TextBox s_comps;
        private System.Windows.Forms.TextBox s_dur;
        private System.Windows.Forms.TextBox rng;
    }
}
