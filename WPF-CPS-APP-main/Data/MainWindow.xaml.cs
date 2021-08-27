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
using System.Diagnostics;
using System.Windows.Threading;

namespace AYOOO_WINDOWS_APP

{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<DateTime> clicks = new List<DateTime>(); 
        public MainWindow()
        {
         
            InitializeComponent();
            //timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds (1) };
            //timer.Start();
            //timer.Tick += timer_Tick;
            //SW.Start();


           
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            clicks.Add(DateTime.Now);
            List<DateTime> timevariable = clicks.Where(click => (DateTime.Now - click).TotalSeconds <= 2).ToList();
            lbltxt.Content = "clicked: " + clicks.Count.ToString();
            lblCPS.Content = (double) timevariable.Count / 2.498157;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
