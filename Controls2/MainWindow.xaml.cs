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
using System.Windows.Threading;

namespace Controls2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //if (myprbar.Value <myprbar.Maximum)
            //{
            //    myprbar.Value += 20;
            //}
            //else
            //{
            //    timer.Stop();
            //    MessageBox.Show("Downloading Completed");
            //}
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            mygrid.Background = Brushes.Red;


        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            mygrid.Background = Brushes.Yellow;
        }
        public int Count { get; set; } = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //normalBtn.Content = (++Count).ToString();
        }

        private void repeatBtn_Click(object sender, RoutedEventArgs e)
        {
            //repeatBtn.Content = (++Count).ToString();
        }

        private void toogleBtn_Click(object sender, RoutedEventArgs e)
        {
           // toogleBtn.Content = (++Count).ToString();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
           // myframe.Source = new Uri($"https://www.google.com/search?q={searchTextBox.Text}");
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["maincolor"] = Application.Current.Resources["specialColor"];
          
        }
    }
}
