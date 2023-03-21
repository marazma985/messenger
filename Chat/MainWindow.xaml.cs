using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Chat
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }
       
        [Obsolete]
        private double[] CalculateSizeText(string text) 
        {
           
            Typeface myTypeface = new Typeface("Arial");
            FormattedText ft = new FormattedText(text, CultureInfo.CurrentCulture,
                    FlowDirection.LeftToRight, myTypeface, 24, Brushes.Red);
            
            double[] array = { ft.Width, ft.Height };
            return array;
        }

        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            DateTime datetimenow = DateTime.Now;
            string username = App.Current.Properties["username"].ToString();
            string message = MessageInput.Text.Trim();
            if (string.IsNullOrEmpty(message)) {
                MessageInput.Text = string.Empty;
                return;
            }
                

            message = $"{username}: {message}    {datetimenow}";


            TextBlock block = new TextBlock();
            block.Background = Brushes.Aqua;
            block.FontSize = 20;
            block.Height = CalculateSizeText(message)[1];
            block.HorizontalAlignment = HorizontalAlignment.Left;
            block.Margin = new Thickness(0, 10, 0, 0);

            
            block.Text = message;
            StackPanelMessage.Children.Insert(0, block);
            


            MessageInput.Text = string.Empty;

        }
    }
}
