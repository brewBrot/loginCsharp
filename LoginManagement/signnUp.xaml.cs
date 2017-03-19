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
using MahApps.Metro.Controls;
using MahApps.Metro.SimpleChildWindow;

namespace LoginManagement
{
    /// <summary>
    /// Interaction logic for signnUp.xaml
    /// </summary>
    public partial class signnUp : MetroWindow
    {
        public signnUp()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow balik = new MainWindow();
            balik.Show();
            this.Close();
        }
    }
}
