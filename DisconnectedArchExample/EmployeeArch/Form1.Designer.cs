namespace EmployeeArch
{
    partial class GetEmployee
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
            this.dataGridView_Emp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Emp
            // 
            this.dataGridView_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Emp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Emp.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Emp.Name = "dataGridView_Emp";
            this.dataGridView_Emp.RowHeadersWidth = 47;
            this.dataGridView_Emp.Size = new System.Drawing.Size(800, 450);
            this.dataGridView_Emp.TabIndex = 0;
            // 
            // GetEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Emp);
            this.Name = "GetEmployee";
            this.Text = "Show Employees";
            this.Load += new System.EventHandler(this.GetEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Emp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Emp;
    }
}

