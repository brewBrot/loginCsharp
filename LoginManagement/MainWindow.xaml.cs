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
using MahApps.Metro.Controls;
using MahApps.Metro.SimpleChildWindow;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace LoginManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        MySqlConnection kon = koneksi.getConnection();  
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (login(text1.Text , pswdtxt2.Password))
            {
                MessageBox.Show("horeee");   
            }
            else
            {
                MessageBox.Show("coba lagi jangan nyerah");
            }
        }

        private Boolean login(string sUserName, string sPassword)
        {
            string SQL = "SELECT username,password FROM user";
            kon.Open();
            MySqlCommand cmd = new MySqlCommand(SQL, kon);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (sUserName==reader.GetString(0)&& (sPassword==reader.GetString(1)))
                {
                    return true;
                }
            }
            kon.Close();
            return false;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            signnUp muncul = new signnUp();
            muncul.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
