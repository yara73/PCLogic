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
        int numbInt = 0;//top Text box, here store it`s value
        double numbDouble = 0;//bottom textbox, again store value here
        Algorithme alg = new Algorithme();
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
                    string finalString = alg.Inversion(numbInt);
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
        
        private void plus_Selected(object sender, RoutedEventArgs e)
        {
            try
            {
                numbInt = Convert.ToInt32(intTextBox.Text);
                numbDouble = Convert.ToDouble(floatTextBox.Text);
                double res = numbInt + numbDouble;                               
                outputText.Text = "" + alg.convertNumSys(numbInt.ToString(),10,2)+"\n"+alg.convertNumSys(numbDouble.ToString(), 10, 2)  + "\n"+alg.convertNumSys(res.ToString(),10,2);

            }
            catch
            {
                MessageBox.Show("Введите допустимое число!");
            }
        }

        private void minus_Selected(object sender, RoutedEventArgs e)
        {
            try
            {
                numbInt = Convert.ToInt32(intTextBox.Text);
                numbDouble = Convert.ToDouble(floatTextBox.Text);
                double res = numbInt - numbDouble;
                outputText.Text = "" + alg.convertNumSys(numbInt.ToString(), 10, 2) + "\n" + alg.convertNumSys(numbDouble.ToString(), 10, 2) + "\n" + alg.convertNumSys(res.ToString(), 10, 2);

            }
            catch
            {
                MessageBox.Show("Введите допустимое число!");
            }
        }

        private void star_Selected(object sender, RoutedEventArgs e)
        {
            try
            {
                numbInt = Convert.ToInt32(intTextBox.Text);
                numbDouble = Convert.ToDouble(floatTextBox.Text);
                double res = numbInt * numbDouble;
                outputText.Text = "" + alg.convertNumSys(numbInt.ToString(), 10, 2) + "\n" + alg.convertNumSys(numbDouble.ToString(), 10, 2) + "\n" + alg.convertNumSys(res.ToString(), 10, 2);

            }
            catch
            {
                MessageBox.Show("Введите допустимое число!");
            }
        }

        private void slash_Selected(object sender, RoutedEventArgs e)
        {
            try
            {
                numbInt = Convert.ToInt32(intTextBox.Text);
                numbDouble = Convert.ToDouble(floatTextBox.Text);
                double res = numbInt / numbDouble;
                outputText.Text = "" + alg.convertNumSys(numbInt.ToString(), 10, 2) + "\n" + alg.convertNumSys(numbDouble.ToString(), 10, 2) + "\n" + alg.convertNumSys(res.ToString(), 10, 2);

            }
            catch
            {
                MessageBox.Show("Введите допустимое число!");
            }
        }

        private void straightCode_Selected(object sender, RoutedEventArgs e)
        {
            try
            {
                numbInt = Convert.ToInt32(intTextBox.Text);
                numbDouble = Convert.ToDouble(floatTextBox.Text);               
                if(numbInt > 0)
                {
                    outputText.Text = "Straight code is: 00," + alg.convertNumSys(numbInt.ToString(), 10, 2);
                }
                else
                {

                    outputText.Text = "Straight code is: 11," + alg.convertNumSys(Math.Abs(numbInt).ToString(), 10, 2);
                }

            }
            catch
            {
                MessageBox.Show("Введите допустимое число!");
            }
        }

        private void reversCode_Selected(object sender, RoutedEventArgs e)
        {
            try
            {
                numbInt = Convert.ToInt32(intTextBox.Text);
                numbDouble = Convert.ToDouble(floatTextBox.Text);
                if (numbInt > 0)
                {
                    outputText.Text = "Reverse code is: 00," + alg.convertNumSys(numbInt.ToString(), 10, 2);
                }
                else
                {

                    outputText.Text = "Reverse code is: 11," + alg.Inversion(Convert.ToInt32(alg.convertNumSys(Math.Abs(numbInt).ToString(), 10, 2)));
                }

            }
            catch
            {
                MessageBox.Show("Введите допустимое число!");
            }
        }

        private void addCode_Selected(object sender, RoutedEventArgs e)
        {
            try
            {
                numbInt = Convert.ToInt32(intTextBox.Text);
                numbDouble = Convert.ToDouble(floatTextBox.Text);
                if (numbInt > 0)
                {
                    outputText.Text = "Additional code is: 00," + alg.convertNumSys(numbInt.ToString(), 10, 2);
                }
                else
                {
                    int res = Convert.ToInt32(alg.convertNumSys(alg.Inversion(Convert.ToInt32(alg.convertNumSys(Math.Abs(numbInt).ToString(), 10, 2))), 2, 10));
                    res++;
                    outputText.Text = "Additional code is: 11,"+alg.convertNumSys(res.ToString(), 10, 2);
                }

            }
            catch
            {
                MessageBox.Show("Введите допустимое число!");
            }
        }
        

    }
}
