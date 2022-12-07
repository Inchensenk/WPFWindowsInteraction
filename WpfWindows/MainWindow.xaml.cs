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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Window1? Window1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnAboutButtonClick(object sender, RoutedEventArgs e)
        {
            /* Первый способ
            Window1 window1 = new Window1();
            window1.Show();
            */

            if(Window1==null)
            {
                Window1 = new Window1();
                Window1.Show();
            }
            else
            { 
                Window1.Activate(); 
            }
        }
    }
}
