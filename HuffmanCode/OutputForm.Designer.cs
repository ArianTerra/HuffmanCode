namespace HuffmanCode
{
    partial class OutputForm
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
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.Grid2 = new System.Windows.Forms.DataGridView();
            this.Grid3 = new System.Windows.Forms.DataGridView();
            this.Grid4 = new System.Windows.Forms.DataGridView();
            this.Grid5 = new System.Windows.Forms.DataGridView();
            this.btnHuffman = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid5)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid1
            // 
            this.Grid1.AllowUserToAddRows = false;
            this.Grid1.AllowUserToDeleteRows = false;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Location = new System.Drawing.Point(13, 13);
            this.Grid1.Name = "Grid1";
            this.Grid1.ReadOnly = true;
            this.Grid1.Size = new System.Drawing.Size(572, 150);
            this.Grid1.TabIndex = 0;
            // 
            // Grid2
            // 
            this.Grid2.AllowUserToAddRows = false;
            this.Grid2.AllowUserToDeleteRows = false;
            this.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid2.Location = new System.Drawing.Point(12, 169);
            this.Grid2.Name = "Grid2";
            this.Grid2.ReadOnly = true;
            this.Grid2.Size = new System.Drawing.Size(573, 150);
            this.Grid2.TabIndex = 1;
            // 
            // Grid3
            // 
            this.Grid3.AllowUserToAddRows = false;
            this.Grid3.AllowUserToDeleteRows = false;
            this.Grid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid3.Location = new System.Drawing.Point(13, 325);
            this.Grid3.Name = "Grid3";
            this.Grid3.ReadOnly = true;
            this.Grid3.Size = new System.Drawing.Size(572, 150);
            this.Grid3.TabIndex = 2;
            // 
            // Grid4
            // 
            this.Grid4.AllowUserToAddRows = false;
            this.Grid4.AllowUserToDeleteRows = false;
            this.Grid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid4.Location = new System.Drawing.Point(12, 483);
            this.Grid4.Name = "Grid4";
            this.Grid4.ReadOnly = true;
            this.Grid4.Size = new System.Drawing.Size(573, 150);
            this.Grid4.TabIndex = 3;
            // 
            // Grid5
            // 
            this.Grid5.AllowUserToAddRows = false;
            this.Grid5.AllowUserToDeleteRows = false;
            this.Grid5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid5.Location = new System.Drawing.Point(13, 639);
            this.Grid5.Name = "Grid5";
            this.Grid5.ReadOnly = true;
            this.Grid5.Size = new System.Drawing.Size(573, 150);
            this.Grid5.TabIndex = 4;
            // 
            // btnHuffman
            // 
            this.btnHuffman.Location = new System.Drawing.Point(472, 795);
            this.btnHuffman.Name = "btnHuffman";
            this.btnHuffman.Size = new System.Drawing.Size(113, 23);
            this.btnHuffman.TabIndex = 5;
            this.btnHuffman.Text = "Calculate Huffman";
            this.btnHuffman.UseVisualStyleBackColor = true;
            this.btnHuffman.Click += new System.EventHandler(this.btnHuffman_Click);
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 830);
            this.Controls.Add(this.btnHuffman);
            this.Controls.Add(this.Grid5);
            this.Controls.Add(this.Grid4);
            this.Controls.Add(this.Grid3);
            this.Controls.Add(this.Grid2);
            this.Controls.Add(this.Grid1);
            this.Name = "OutputForm";
            this.Text = "OutputForm";
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.DataGridView Grid2;
        private System.Windows.Forms.DataGridView Grid3;
        private System.Windows.Forms.DataGridView Grid4;
        private System.Windows.Forms.DataGridView Grid5;
        private System.Windows.Forms.Button btnHuffman;
    }
}