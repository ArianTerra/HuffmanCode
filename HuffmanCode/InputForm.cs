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
            HuffmanTree tree = new HuffmanTree();
            tree.Build(text, 2);
            var one = tree.EncodeString(text); //TODO
            MessageBox.Show(one);
        }
    }
}
