using System;
using System.Data;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach(UIElement el in MainRoot.Children)
            {
                if(el is Button)
                {
                    ((Button)el).Click += ButtonClick;
                }
            }

        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            string text = ((Button)e.OriginalSource).Content.ToString();
            if (text == "AC")
                textLable1.Text = "";
            else if(text=="=")
            {
                string val = new DataTable().Compute(textLable1.Text,null).ToString();
                textLable1.Text= val;
            }
            else 
                textLable1.Text += text;
        }
    }
}
