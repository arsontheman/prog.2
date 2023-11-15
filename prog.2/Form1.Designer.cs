namespace prog._2
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SearchLetterTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.роботаЗМасивамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двовимірніМасивиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Вивести прізвище";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(43, 232);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 20);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Click += new System.EventHandler(this.ResultLabel_Click);
            // 
            // SearchLetterTextBox
            // 
            this.SearchLetterTextBox.Location = new System.Drawing.Point(47, 81);
            this.SearchLetterTextBox.Name = "SearchLetterTextBox";
            this.SearchLetterTextBox.Size = new System.Drawing.Size(100, 26);
            this.SearchLetterTextBox.TabIndex = 7;
            this.SearchLetterTextBox.TextChanged += new System.EventHandler(this.SearchLetterTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurnameColumn});
            this.dataGridView1.Location = new System.Drawing.Point(250, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(406, 316);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Прізвище";
            this.SurnameColumn.MinimumWidth = 8;
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.роботаЗМасивамиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // роботаЗМасивамиToolStripMenuItem
            // 
            this.роботаЗМасивамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.двовимірніМасивиToolStripMenuItem});
            this.роботаЗМасивамиToolStripMenuItem.Name = "роботаЗМасивамиToolStripMenuItem";
            this.роботаЗМасивамиToolStripMenuItem.Size = new System.Drawing.Size(186, 29);
            this.роботаЗМасивамиToolStripMenuItem.Text = "Робота з масивами";
            // 
            // двовимірніМасивиToolStripMenuItem
            // 
            this.двовимірніМасивиToolStripMenuItem.Name = "двовимірніМасивиToolStripMenuItem";
            this.двовимірніМасивиToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.двовимірніМасивиToolStripMenuItem.Text = "Двовимірні масиви";
            this.двовимірніМасивиToolStripMenuItem.Click += new System.EventHandler(this.двовимірніМасивиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.SearchLetterTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox SearchLetterTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem роботаЗМасивамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двовимірніМасивиToolStripMenuItem;
    }
}

