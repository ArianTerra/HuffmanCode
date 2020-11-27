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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.Grid1.Location = new System.Drawing.Point(17, 55);
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
            this.Grid2.Location = new System.Drawing.Point(16, 211);
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
            this.Grid3.Location = new System.Drawing.Point(17, 367);
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
            this.Grid4.Location = new System.Drawing.Point(16, 525);
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
            this.Grid5.Location = new System.Drawing.Point(16, 707);
            this.Grid5.Name = "Grid5";
            this.Grid5.Size = new System.Drawing.Size(573, 150);
            this.Grid5.TabIndex = 4;
            // 
            // btnHuffman
            // 
            this.btnHuffman.Location = new System.Drawing.Point(475, 863);
            this.btnHuffman.Name = "btnHuffman";
            this.btnHuffman.Size = new System.Drawing.Size(113, 23);
            this.btnHuffman.TabIndex = 5;
            this.btnHuffman.Text = "Calculate Huffman";
            this.btnHuffman.UseVisualStyleBackColor = true;
            this.btnHuffman.Click += new System.EventHandler(this.btnHuffman_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Алфавит источника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Обозначения \r\nкодовых \r\nслов\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вероятности p";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Код Хаффмана";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Число символов";
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 899);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.DataGridView Grid2;
        private System.Windows.Forms.DataGridView Grid3;
        private System.Windows.Forms.DataGridView Grid4;
        private System.Windows.Forms.DataGridView Grid5;
        private System.Windows.Forms.Button btnHuffman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}