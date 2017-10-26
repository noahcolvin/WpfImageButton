using System;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.WPF;

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
            superButton1.IconBackgroundColor = Colors.Red;
            superButton1.Content = "Button One";
            superButton1.Icon = FontAwesomeIcon.Barcode;

            superButton2.IconBackgroundColor = Colors.Orange;
            superButton2.Content = "Button Two";
            superButton2.Icon = FontAwesomeIcon.Folder;

            superButton3.IconBackgroundColor = Colors.Yellow;
            superButton3.Content = "Button Three";
            superButton3.Icon = FontAwesomeIcon.FolderOpen;

            superButton4.IconBackgroundColor = Colors.Green;
            superButton4.Content = "Button Four";
            superButton4.Icon = FontAwesomeIcon.ShoppingCart;

            superButton5.IconBackgroundColor = Colors.Indigo;
            superButton5.Content = "Button Five";
            superButton5.Icon = FontAwesomeIcon.AddressBook;

            superButton6.IconBackgroundColor = Colors.Violet;
            superButton6.Content = "Button Six";
            superButton6.Icon = FontAwesomeIcon.Beer;

            superButton7.IconBackgroundColor = Colors.Cyan;
            superButton7.Content = "Button Seven";
            superButton7.Icon = FontAwesomeIcon.Cloud;

            superButton8.IconBackgroundColor = Colors.Magenta;
            superButton8.Content = "Button Eight";
            superButton8.Icon = FontAwesomeIcon.Map;

            superButton8.Click += (o, args) => MessageBox.Show("Clicked");
        }
    }
}
