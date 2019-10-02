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

namespace WpfApplication6
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

        private void Phepcong_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(Sothu1.Text);

            int b = int.Parse(Sothu2.Text);

            int outcome = 0;

            outcome = a + b;

            Ketqua.Text = Sothu1.Text + " + " + Sothu2.Text;

            Ketqua.Text = outcome.ToString();
        }

        private void Pheptru_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(Sothu1.Text);

            int b = int.Parse(Sothu2.Text);

            int outcome = 0;

            outcome = a - b;

            Ketqua.Text = Sothu1.Text + " - " + Sothu2.Text;

            Ketqua.Text = outcome.ToString();
        }

        private void Phepnhan_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(Sothu1.Text);

            int b = int.Parse(Sothu2.Text);

            int outcome = 0;

            outcome = a * b;

            Ketqua.Text = Sothu1.Text + " * " + Sothu2.Text;

            Ketqua.Text = outcome.ToString();
        }

        private void Phepchia_Click(object sender, RoutedEventArgs e)
        {
            float a, b, c;
            a = float.Parse(Sothu1.Text);

            b = float.Parse(Sothu2.Text);
            if (b == 0)
            {
                MessageBox.Show("Khong duoc");
            }
            else
            {
                c = a / b;
                //Ketqua.Text = c.ToString();
                Ketqua.Text = string.Format("{0:0.0}", c);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
