using System;
using System.Windows.Forms;
using System.Windows.Media;

namespace UIPlayground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.wpfImageButton1.IconBackgroundColor = Brushes.BlueViolet;
            this.superButton1.IconBackgroundColor = Brushes.BlueViolet;
        }
    }
}
