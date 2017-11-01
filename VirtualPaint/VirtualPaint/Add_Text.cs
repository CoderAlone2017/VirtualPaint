using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPaint
{
    public partial class Add_Text : Form
    {
        FontDialog fontDialog1 = new FontDialog();
        public Add_Text(Font font, string text)
        {
            InitializeComponent();
            textBox1.Font = fontDialog1.Font = font;
            textBox1.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VirtualPaint f = this.Tag as VirtualPaint;
            f.font = fontDialog1.Font;
            f.text = textBox1.Text;
            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            VirtualPaint f = new VirtualPaint();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) button3_Click(button3, e);
        }
    }
}
