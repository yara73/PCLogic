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

namespace PCLogic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numbInt = 0;
        double numbDouble = 0;
        public MainWindow()
        {
            InitializeComponent();
            outputText.Text = "Here is some output";
        }

        private void inverseButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                numbInt = Convert.ToInt32(intTextBox.Text);
                numbDouble = Convert.ToDouble(floatTextBox.Text);
            

                if(numbInt != 0)
                {
                    string finalString = Inversion(numbInt);
                    outputText.Text = "Inverted numb is: "+finalString;
                }
                if(numbDouble != 0)
                {
                    MessageBox.Show(numbDouble.ToString());
                }
            }

            catch
            {
                MessageBox.Show("Введите допустимое число!");
            }
        }
        private string Inversion(int numb)
        {
            char[] numbChar = numb.ToString().ToCharArray();
            string numbString = "";
            for (int i = 0; i < numbChar.Length; i++)
            {
                numbChar[i] = (numbChar[i] > '0') ? '0' : '1';
                numbString += numbChar[i];
            }

            return numbString;
        }
        private string Inversion(double numb)
        {
            char[] numbChar = numb.ToString().ToCharArray();
            string numbString = "";
            for (int i = 0; i < numbChar.Length; i++)
            {
                numbChar[i] = (numbChar[i] > '0') ? '1' : '0';
                numbString += numbChar[i];
            }

            return numbString;
        }

        private void plus_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("+");
        }

        private void minus_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("-");
        }

        private void star_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("*");
        }

        private void slash_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("/");
        }

        private void straightCode_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void reversCode_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void addCode_Selected(object sender, RoutedEventArgs e)
        {

        }
        

    }
}
