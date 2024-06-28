namespace ProductCrudConnected
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
            this.HeadingMain = new System.Windows.Forms.Label();
            this.txtProPrice = new System.Windows.Forms.TextBox();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.txtProId = new System.Windows.Forms.TextBox();
            this.l_Price = new System.Windows.Forms.Label();
            this.l_ProductName = new System.Windows.Forms.Label();
            this.l_ProductId = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeadingMain
            // 
            this.HeadingMain.AutoSize = true;
            this.HeadingMain.Font = new System.Drawing.Font("Segoe Print", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingMain.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.HeadingMain.Location = new System.Drawing.Point(232, 31);
            this.HeadingMain.Name = "HeadingMain";
            this.HeadingMain.Size = new System.Drawing.Size(308, 64);
            this.HeadingMain.TabIndex = 29;
            this.HeadingMain.Text = "Product Datails";
            // 
            // txtProPrice
            // 
            this.txtProPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProPrice.Location = new System.Drawing.Point(348, 205);
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.Size = new System.Drawing.Size(202, 27);
            this.txtProPrice.TabIndex = 28;
            // 
            // txtProName
            // 
            this.txtProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProName.Location = new System.Drawing.Point(348, 165);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(202, 27);
            this.txtProName.TabIndex = 27;
            // 
            // txtProId
            // 
            this.txtProId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProId.Location = new System.Drawing.Point(348, 127);
            this.txtProId.Name = "txtProId";
            this.txtProId.Size = new System.Drawing.Size(202, 27);
            this.txtProId.TabIndex = 26;
            // 
            // l_Price
            // 
            this.l_Price.AutoSize = true;
            this.l_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Price.Location = new System.Drawing.Point(193, 205);
            this.l_Price.Name = "l_Price";
            this.l_Price.Size = new System.Drawing.Size(124, 20);
            this.l_Price.TabIndex = 25;
            this.l_Price.Text = "Product Price";
            // 
            // l_ProductName
            // 
            this.l_ProductName.AutoSize = true;
            this.l_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ProductName.Location = new System.Drawing.Point(193, 170);
            this.l_ProductName.Name = "l_ProductName";
            this.l_ProductName.Size = new System.Drawing.Size(128, 20);
            this.l_ProductName.TabIndex = 24;
            this.l_ProductName.Text = "Product Name";
            // 
            // l_ProductId
            // 
            this.l_ProductId.AutoSize = true;
            this.l_ProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ProductId.Location = new System.Drawing.Point(193, 130);
            this.l_ProductId.Name = "l_ProductId";
            this.l_ProductId.Size = new System.Drawing.Size(95, 20);
            this.l_ProductId.TabIndex = 23;
            this.l_ProductId.Text = "Product Id";
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Remove.Location = new System.Drawing.Point(548, 357);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(103, 62);
            this.btn_Remove.TabIndex = 22;
            this.btn_Remove.Text = "&Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Modify.Location = new System.Drawing.Point(422, 357);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(97, 62);
            this.btn_Modify.TabIndex = 21;
            this.btn_Modify.Text = "M&odify";
            this.btn_Modify.UseVisualStyleBackColor = false;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Save.Location = new System.Drawing.Point(297, 357);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 62);
            this.btn_Save.TabIndex = 20;
            this.btn_Save.Text = "&Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_New.Location = new System.Drawing.Point(149, 357);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(117, 62);
            this.btn_New.TabIndex = 19;
            this.btn_New.Text = "&New";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_last
            // 
            this.btn_last.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.Location = new System.Drawing.Point(548, 277);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(103, 54);
            this.btn_last.TabIndex = 18;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = false;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(423, 277);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(96, 54);
            this.btn_next.TabIndex = 17;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prev.Location = new System.Drawing.Point(297, 277);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(100, 53);
            this.btn_Prev.TabIndex = 16;
            this.btn_Prev.Text = "<";
            this.btn_Prev.UseVisualStyleBackColor = false;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_first
            // 
            this.btn_first.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.Location = new System.Drawing.Point(149, 277);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(117, 53);
            this.btn_first.TabIndex = 15;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = false;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HeadingMain);
            this.Controls.Add(this.txtProPrice);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.txtProId);
            this.Controls.Add(this.l_Price);
            this.Controls.Add(this.l_ProductName);
            this.Controls.Add(this.l_ProductId);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_first);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadingMain;
        private System.Windows.Forms.TextBox txtProPrice;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.TextBox txtProId;
        private System.Windows.Forms.Label l_Price;
        private System.Windows.Forms.Label l_ProductName;
        private System.Windows.Forms.Label l_ProductId;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_first;
    }
}

