using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFPages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content =new ContactPage();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new HomePage();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new AboutPage();
        }
    }
}