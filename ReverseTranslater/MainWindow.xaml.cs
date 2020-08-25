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

namespace ReverseTranslater
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WorkClassWithWord WCWW = new WorkClassWithWord();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] TempBuffer = WCWW.InsertStringMass(TxtBox1_insert.Text);
            if (WCWW.TestStringCorrectValue(TempBuffer) == true)
            {
                string[] ResultedArray = WCWW.Decoder(TempBuffer);
                for (int i = 0; i < ResultedArray.Length; i++)
                {
                    TxtBox1_Result.Text += ResultedArray[i] + " ";
                }
            }
            else
            {
                MessageBox.Show("Введены некоректные данные для перевода");
            }
        }

        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TxtBox1_Result.Text = "";
            TxtBox1_insert.Text = "";
        }
    }
}
