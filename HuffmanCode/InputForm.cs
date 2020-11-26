using System;
using System.Windows.Forms;

namespace HuffmanCode
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void btnHuffman_Click(object sender, EventArgs e)
        {
            var text = richTextBox.Text;

            int HuffmanLimit = 4;
            HuffmanTree[] Huffmen = new HuffmanTree[HuffmanLimit];

            for (int i = 1; i <= HuffmanLimit; i++)
            {
                Huffmen[i - 1] = new HuffmanTree();
                Huffmen[i - 1].Build(text, i);
            }

            HuffmanTree Huffman = Huffmen[0];

            string one = Huffman.EncodeString(text);

            OutputForm form = new OutputForm(Huffmen);
            form.ShowDialog();
        }
    }
}
