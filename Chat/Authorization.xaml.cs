using System;
using System.Collections.Generic;
using System.IO;
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

namespace Chat
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
            string file = @"D:\Nickname.txt";
            if (!(File.Exists(@"D:\Nickname.txt")))
            {
                

            }
            else
            {
                string nick = File.ReadAllText(file);

            }
        }

       


        public void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = Nickname.Text;
            App.Current.Properties["username"] = username;
            System.IO.File.WriteAllText(@"D:\Nickname.txt", username);
            Window Main = new MainWindow();
            (Main as MainWindow).Start.Text = $"Вы вошли в чат {username}";
       
            Main.Show();
            Close();
            
        }
    }
}
