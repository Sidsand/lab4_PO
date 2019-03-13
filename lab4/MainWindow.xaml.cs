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

namespace lab4
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

        public bool Ostatok(int ch)
        {
            if (ch < 0)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < ch; i++)
                {
                    int z = ch % i;
                    if (z == 0)
                    {
                        return false;
                    }

                }

                return true;
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                bool k = Ostatok(int.Parse(chis.Text));
                if (k == false)
                {
                    Console.WriteLine("Error: Число не простое");
                }
                else
                {
                    spis.Items.Add(int.Parse(chis.Text));
                    chis.Text = "";
                }
              

            }
            catch (FormatException) //реакция на неверный ввод
            {
                Console.WriteLine("Error: Введите число");
            }
        }
    }
}
