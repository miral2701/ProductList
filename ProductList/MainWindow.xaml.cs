using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListBox a=new ListBox();
       
        public MainWindow()
        {
            InitializeComponent();

            stackPanel.Children.Add(a);




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBlock a1 = new TextBlock();
            TextBlock a2 = new TextBlock();
            AddProduct p = new AddProduct(a1,a2);
          
            p.Show();
            
          

            Expander exp = new Expander();

            //Create Bullet Panel for Expander Header
            BulletDecorator bp = new BulletDecorator();
            
            a1.Margin = new Thickness(20, 0, 0, 0);
            bp.Child = a1;
            exp.Header = bp;

            //Create TextBlock with ScrollViewer for Expander Content
            StackPanel spScroll = new StackPanel();
            
            a2.TextWrapping = TextWrapping.Wrap;

            spScroll.Children.Add(a2);
            ScrollViewer scr = new ScrollViewer();
            scr.Content = spScroll;
            scr.Height = 50;
            exp.Content = scr;

            exp.Width = 200;
            exp.HorizontalContentAlignment = HorizontalAlignment.Stretch;
            //Insert Expander into the StackPanel and add it to the
            //Grid
           
            a.Items.Add(exp);
          
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            a.Items.Remove(a.SelectedItem);
        }
    }
}