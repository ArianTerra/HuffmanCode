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
    public partial class EncodedForm : Form
    {
        string code = null;

        public EncodedForm()
        {
            InitializeComponent();
        }

        public EncodedForm(string sourse)
        {
            int aggregation = 1;
            HuffmanTree encoder = new HuffmanTree();
            encoder.Build(sourse, aggregation);
            code = encoder.EncodeBits(sourse);
        }

        private void EncodedForm_Load(object sender, EventArgs e)
        {
            Basinga.Text = "Bang";
        }
    }
}
