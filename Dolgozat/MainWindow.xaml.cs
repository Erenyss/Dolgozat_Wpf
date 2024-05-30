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

namespace Dolgozat
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
        private void StackPanel0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ShowContent(UserControl control)
        {
            ContentArea.Content = control;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowContent(new UserControl1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ShowContent((UserControl2)sender);
        }
    }
}