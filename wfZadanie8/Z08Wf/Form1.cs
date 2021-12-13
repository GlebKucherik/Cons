using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Z08Wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StringBuilder sb = new StringBuilder();
        string[] words;
        void Main()
        {
            label2.Text = string.Empty;
            Regex r = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            sb.Append(textBox1.Text);
            words = sb.ToString().Split(' ');
            label2.Text = "Все IP: ";
            for (int i = 0; i < words.Length; i++)
            {
                if (r.IsMatch(words[i]))
                {
                    label2.Text +=words[i] + "\n";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }
    }
}
