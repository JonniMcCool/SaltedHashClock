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
            var date = System.DateTime.Now;
            var dateString = date.ToString(SaltAndHash.Encryption.dateFormat);
            textBox2.Text = SaltAndHash.Encryption.Execute(date, textBox1.Text);
            textBox3.Text = dateString;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = SaltAndHash.Validation.Execute(textBox5.Text, dateTimePicker1.Value, textBox4.Text);
        }
    }
}
