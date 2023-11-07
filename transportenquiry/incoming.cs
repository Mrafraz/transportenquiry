using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transportenquiry
{
    public partial class incoming : UserControl
    {
        public incoming()
        {
            InitializeComponent();
        }
        public String Message
        {
            get
            {
                return richTextBox1.Text;
            }
            set
            {
                richTextBox1.Text = value;
                AdjustHeight();
            }
        }
        void AdjustHeight()
        {
            pictureBox1.Location = new Point(4, 3);
            richTextBox1.Height = Utils.GetTextHeight(richTextBox1) + 10;
            this.Height = richTextBox1.Height + 10;



        }
        public Image Avatar { get => pictureBox1.Image; set => pictureBox1.Image = value; }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void incoming_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
