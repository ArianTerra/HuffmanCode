using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuffmanCode;

namespace HuffmanCode
{
    public partial class OutputForm : Form
    {
        public OutputForm()
        {
            InitializeComponent();
        }

        public OutputForm(HuffmanTree[] Huffmen) : this()
        {
            // Need to list views here.
            DataGridView[] views = new DataGridView[] { Grid1, Grid2, Grid3, Grid4 };

            for (int i = 0; i < Huffmen.Length; i++)
            {
                ShowHuffman(views[i], Huffmen[i]);
            }

            ShowStats(Grid5, Huffmen);
        }

        // Look up the tables in the exercise statement. 
        public void ShowHuffman(DataGridView Grid, HuffmanTree Huffman)
        {
            int roundLimit = 4;

            Grid.ColumnCount = 5;
            Grid.ColumnHeadersVisible = false;
            Grid.RowHeadersVisible = false;

            var input = Huffman.Result.ToList();

            for (int i = 0; i < input.Count; i++)
            {
                Grid.Rows.Add();

                double probability = Math.Round(input[i].Value.Item3, roundLimit);

                Grid[0, i].Value = input[i].Key;
                Grid[1, i].Value = input[i].Value.Item1;
                Grid[2, i].Value = probability;
                Grid[3, i].Value = input[i].Value.Item2;
                Grid[4, i].Value = input[i].Value.Item2.Length;
            }
        }

        public void ShowStats(DataGridView Grid, HuffmanTree[] Huffmen)
        {
            int roundLimit = 4;

            Grid.ColumnCount = 9;
            Grid.ColumnHeadersVisible = false;
            Grid.RowHeadersVisible = false;

            var limit = Huffmen.Length;

            for (int i = 0; i < Grid.ColumnCount; i++)
            {
                Grid.Columns[i].Width = 63;
            }

            for (int i = 0; i <= limit; i++)
            {
                Grid.Rows.Add();
            }

            Grid[0, 0].Value = "p(x_k)";
            Grid[1, 0].Value = "H(S)";
            Grid[2, 0].Value = "H_1(S)";
            Grid[3, 0].Value = "n_minc";
            Grid[4, 0].Value = "D_и";
            Grid[5, 0].Value = "avg_n";
            Grid[6, 0].Value = "avg_n_c";
            Grid[7, 0].Value = "n_minc/n_c";
            Grid[8, 0].Value = "D_к";
        }

        private void btnHuffman_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
