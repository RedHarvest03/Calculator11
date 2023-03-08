using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement item in groupbutton.Children)
            {
                if (item is Button)
                {
                    ((Button)item).Click += Button_Click;
                }
            }

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string? textbutton = ((Button)e.OriginalSource).Content.ToString();
            if (textbutton == "C")
            {
                text.Clear();
            }
            else if (textbutton == "X")
            {
                text.Text = text.Text.Substring(text.Text.Length - 1);
            }
            else if (textbutton == "=")
            {
                text.Text = new DataTable().Compute(text.Text, null).ToString();
            }
            else text.Text += textbutton;
        }
    }
}
