namespace WindowsFormsApp5
{
    partial class AbilitySkill
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
            this.skill = new System.Windows.Forms.Label();
            this.mod = new System.Windows.Forms.Label();
            this.prof = new System.Windows.Forms.CheckBox();
            this.doubleProf = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // skill
            // 
            this.skill.AutoSize = true;
            this.skill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skill.Location = new System.Drawing.Point(54, 2);
            this.skill.Name = "skill";
            this.skill.Size = new System.Drawing.Size(39, 13);
            this.skill.TabIndex = 0;
            this.skill.Text = "Name";
            // 
            // mod
            // 
            this.mod.AutoSize = true;
            this.mod.Location = new System.Drawing.Point(24, 2);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(27, 13);
            this.mod.TabIndex = 1;
            this.mod.Text = "mod";
            // 
            // prof
            // 
            this.prof.AutoSize = true;
            this.prof.Location = new System.Drawing.Point(3, 2);
            this.prof.Name = "prof";
            this.prof.Size = new System.Drawing.Size(15, 14);
            this.prof.TabIndex = 2;
            this.prof.UseVisualStyleBackColor = true;
            this.prof.CheckedChanged += new System.EventHandler(this.prof_CheckedChanged);
            // 
            // doubleProf
            // 
            this.doubleProf.AutoSize = true;
            this.doubleProf.Enabled = false;
            this.doubleProf.Location = new System.Drawing.Point(98, 2);
            this.doubleProf.Name = "doubleProf";
            this.doubleProf.Size = new System.Drawing.Size(15, 14);
            this.doubleProf.TabIndex = 3;
            this.doubleProf.UseVisualStyleBackColor = true;
            this.doubleProf.CheckedChanged += new System.EventHandler(this.doubleProf_CheckedChanged);
            // 
            // AbilitySkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.doubleProf);
            this.Controls.Add(this.prof);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.skill);
            this.Name = "AbilitySkill";
            this.Size = new System.Drawing.Size(208, 18);
            this.Load += new System.EventHandler(this.AbilitySkill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label skill;
        private System.Windows.Forms.Label mod;
        private System.Windows.Forms.CheckBox prof;
        private System.Windows.Forms.CheckBox doubleProf;
    }
}
