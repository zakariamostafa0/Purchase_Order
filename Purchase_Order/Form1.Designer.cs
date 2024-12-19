namespace Purchase_Order
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
            this.txtFilePath = new System.Windows.Forms.Button();
            this.dgvPOData = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtPOType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(24, 13);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(75, 23);
            this.txtFilePath.TabIndex = 0;
            this.txtFilePath.Text = "Load File";
            this.txtFilePath.UseVisualStyleBackColor = true;
            this.txtFilePath.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // dgvPOData
            // 
            this.dgvPOData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOData.Location = new System.Drawing.Point(24, 69);
            this.dgvPOData.Name = "dgvPOData";
            this.dgvPOData.Size = new System.Drawing.Size(747, 280);
            this.dgvPOData.TabIndex = 1;
            this.dgvPOData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPOData_CellContentClick);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(137, 13);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "Show Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(298, 15);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(79, 20);
            this.txtYear.TabIndex = 3;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(443, 15);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(78, 20);
            this.txtMonth.TabIndex = 4;
            // 
            // txtPOType
            // 
            this.txtPOType.Location = new System.Drawing.Point(598, 15);
            this.txtPOType.Name = "txtPOType";
            this.txtPOType.Size = new System.Drawing.Size(81, 20);
            this.txtPOType.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(263, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Year";
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Month.Location = new System.Drawing.Point(402, 18);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(37, 13);
            this.Month.TabIndex = 7;
            this.Month.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(548, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PoType";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPOType);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dgvPOData);
            this.Controls.Add(this.txtFilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtFilePath;
        private System.Windows.Forms.DataGridView dgvPOData;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtPOType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Month;
        private System.Windows.Forms.Label label3;
    }
}

