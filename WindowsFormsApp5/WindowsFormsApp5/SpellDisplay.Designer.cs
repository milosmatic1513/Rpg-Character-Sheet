namespace WindowsFormsApp5
{
    partial class SpellDisplay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.durSearch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.compSearch = new System.Windows.Forms.ComboBox();
            this.castingSearch = new System.Windows.Forms.ComboBox();
            this.nameSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(613, 259);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Duration";
            // 
            // durSearch
            // 
            this.durSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.durSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.durSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durSearch.FormattingEnabled = true;
            this.durSearch.Items.AddRange(new object[] {
            "Instantaneous",
            "Concentration",
            "Round",
            "Minute",
            "Hour",
            "Day",
            "Other",
            "Any"});
            this.durSearch.Location = new System.Drawing.Point(432, 29);
            this.durSearch.Name = "durSearch";
            this.durSearch.Size = new System.Drawing.Size(108, 26);
            this.durSearch.TabIndex = 27;
            this.durSearch.Text = "Any";
            this.durSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Components";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Casting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name";
            // 
            // compSearch
            // 
            this.compSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.compSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.compSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compSearch.FormattingEnabled = true;
            this.compSearch.Items.AddRange(new object[] {
            "V",
            "S",
            "M",
            "Any"});
            this.compSearch.Location = new System.Drawing.Point(332, 29);
            this.compSearch.Name = "compSearch";
            this.compSearch.Size = new System.Drawing.Size(79, 26);
            this.compSearch.TabIndex = 21;
            this.compSearch.Text = "Any";
            this.compSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // castingSearch
            // 
            this.castingSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.castingSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.castingSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castingSearch.FormattingEnabled = true;
            this.castingSearch.Items.AddRange(new object[] {
            "1 action",
            "1 bonus",
            "Other",
            "Any"});
            this.castingSearch.Location = new System.Drawing.Point(240, 29);
            this.castingSearch.Name = "castingSearch";
            this.castingSearch.Size = new System.Drawing.Size(78, 26);
            this.castingSearch.TabIndex = 20;
            this.castingSearch.Text = "Any";
            this.castingSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nameSearch
            // 
            this.nameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSearch.Location = new System.Drawing.Point(124, 31);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(100, 24);
            this.nameSearch.TabIndex = 17;
            this.nameSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SpellDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 331);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.durSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compSearch);
            this.Controls.Add(this.castingSearch);
            this.Controls.Add(this.nameSearch);
            this.Name = "SpellDisplay";
            this.Text = "SpellDisplay";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox durSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox compSearch;
        private System.Windows.Forms.ComboBox castingSearch;
        private System.Windows.Forms.TextBox nameSearch;
    }
}