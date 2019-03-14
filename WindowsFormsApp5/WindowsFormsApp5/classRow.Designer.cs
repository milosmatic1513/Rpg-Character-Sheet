namespace WindowsFormsApp5
{
    partial class classRow
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
            this.lvl = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.keyListener = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvl
            // 
            this.lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl.Location = new System.Drawing.Point(4, 4);
            this.lvl.Name = "lvl";
            this.lvl.ReadOnly = true;
            this.lvl.Size = new System.Drawing.Size(25, 24);
            this.lvl.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(35, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 24);
            this.textBox1.TabIndex = 3;
            // 
            // keyListener
            // 
            this.keyListener.Enabled = false;
            this.keyListener.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyListener.Location = new System.Drawing.Point(232, 3);
            this.keyListener.Name = "keyListener";
            this.keyListener.Size = new System.Drawing.Size(57, 24);
            this.keyListener.TabIndex = 4;
            this.keyListener.Visible = false;
            this.keyListener.TextChanged += new System.EventHandler(this.keyListener_TextChanged);
            this.keyListener.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyListener_KeyDown);
            // 
            // classRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.keyListener);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lvl);
            this.Name = "classRow";
            this.Size = new System.Drawing.Size(520, 30);
            this.Load += new System.EventHandler(this.classRow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lvl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox keyListener;
    }
}
