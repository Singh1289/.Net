namespace ProductArch
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
            this.proV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.proV)).BeginInit();
            this.SuspendLayout();
            // 
            // proV
            // 
            this.proV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proV.Location = new System.Drawing.Point(0, 0);
            this.proV.Name = "proV";
            this.proV.RowHeadersWidth = 47;
            this.proV.Size = new System.Drawing.Size(800, 450);
            this.proV.TabIndex = 0;
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.proV);
            this.Name = "Form1";
            this.Text = "Products Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView proV;
    }
}

