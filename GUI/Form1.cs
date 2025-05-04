using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = SaltAndHash.Say.hello(@"Hashed");
        }
    }
}
