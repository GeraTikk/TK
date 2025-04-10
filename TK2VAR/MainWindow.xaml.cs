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

namespace TK2VAR
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

        private void Ans_Click(object sender, RoutedEventArgs e)
        {
            Test(TextBox_1.Text, TextBox_2.Text, TextBox_3.Text);
        }

        public bool Test(String t1, String t2, String t3)
        {
            if (string.IsNullOrEmpty(t1) || string.IsNullOrEmpty(t2) || string.IsNullOrEmpty(t3))
            {
                MessageBox.Show("Введите все баллы");
                return false;
            }
            if (!double.TryParse(t1, out double result1) || !double.TryParse(t2, out double result2) || !double.TryParse(t3, out double result3))
            {
                MessageBox.Show("Введите числовые значения");
                return false;
            }
            if (result1 < 0 || result1 > 22 || result2 < 0 || result2 > 38 || result3 < 0 || result3 > 20) 
            {
                MessageBox.Show("Введите корректные баллы");
                return false;
            }
            double balls = result1 + result2 + result3;
            Ans_1.Text = balls.ToString();
            string grade = GetBalls(balls);
            Ans_2.Text = grade;
            MessageBox.Show("Вв молодец!");
            return true;
        }

        private string GetBalls(double totalScore)
        {
            if (totalScore >= 56 && totalScore <= 80)
            {
                return "5";
            }
            else if (totalScore >= 32 && totalScore < 56)
            {
                return "4";
            }
            else if (totalScore >= 16 && totalScore < 32)
            {
                return "3";
            }
            else
            {
                return "2";
            }
        } 
    }
}
