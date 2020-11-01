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

namespace WpfApp3
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

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string allText = tb_text.Text;

        

            while (tb_text.Text.Contains("  "))
            {
                allText = tb_text.Text.Replace("  ", " ");
                tb_text.Text = tb_text.Text.Replace("  ", " ");
            }

            if (tb_text.Text.Contains(", ") || tb_text.Text.Contains(" ,"))
            {
                tb_text.Text = tb_text.Text.Replace(", ", ",");
                tb_text.Text = tb_text.Text.Replace(" ,", ",");
            }

            if(tb_text.Text.Contains(" - "))
            {
                tb_text.Text = tb_text.Text.Replace(" - ", "- ");
            }

            if(tb_text.Text.Contains(" ."))
            {
                tb_text.Text = tb_text.Text.Replace(" .", ".");

            }
           
            char[] allChar;
            allChar = allText.ToCharArray();
            char[] allChar_1 = new char[allChar.Length - 1];


            if (Char.IsWhiteSpace(allChar[0]) && (Char.IsWhiteSpace(allChar[allChar.Length - 1])))
            {
                tb_text.Text = tb_text.Text.Trim();
              
            }
            else if (Char.IsWhiteSpace(allChar[allChar.Length - 1]))
            {
                tb_text.Text = tb_text.Text.TrimEnd();
            }
            else if (Char.IsWhiteSpace(allChar[0]))
            {
                tb_text.Text = tb_text.Text.TrimStart();
            }


            string[] textArray =tb_text.Text.Split(new char[] { ' ', ',' });


            tb_word.Text = Convert.ToString(textArray.Length);



        }
    }
}
