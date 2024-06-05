using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProductList
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        TextBlock t1;
        TextBlock t2;
        public AddProduct(TextBlock t1,TextBlock t2)
        {
            InitializeComponent();
            this.t1 = t1;
            this.t2 = t2;   
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            t1.Text=textBox1.Text; 
            t2.Text=textBox2.Text;
            if (t1.Text == "" && t2.Text == "")
            {
                MessageBox.Show("Empty string");
            }
            else
            {
                this.Close();

            }
        }
    }
}
