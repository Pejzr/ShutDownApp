using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ShutDownApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int delay;
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            BtnShutDown.IsEnabled = false;
        }

        private void Startclock()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,1);
            timer.Tick += Timer_Tick;
            timer.Start();
            BtnHalfHour.IsEnabled = false;
            BtnHour.IsEnabled = false;
            Btn2Hours.IsEnabled = false;
            BtnShutDown.IsEnabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            delay--;
            datelbl.Text = string.Format("{0:00}:{1:00}:{2:00}", delay / 3600, (delay / 60) % 60, delay % 60);
            if (delay == 0)
            {
                timer.Stop();
                Process.Start("shutdown", "/p");
            }
        }

        private void Btn_Click_ShutDownHour(object sender, RoutedEventArgs e)
        {
            delay = 3600;
            Startclock();
        }

        private void Btn_Click_ShutDownHalfHour(object sender, RoutedEventArgs e)
        {
            delay = 1800;
            Startclock();
        }

        private void Btn_Click_ShutDown2Hours(object sender, RoutedEventArgs e)
        {
            delay = 7200;
            Startclock();
        }

        private void CancelShutDown(object sender, RoutedEventArgs e)
        {
            Process.Start("shutdown", "/a");
            BtnHalfHour.IsEnabled = true;
            BtnHour.IsEnabled = true;
            Btn2Hours.IsEnabled = true;
            BtnShutDown.IsEnabled = false;
            timer.Stop();
            datelbl.Text = String.Empty;
        }

        private void spustOdpocet_Click(object sender, RoutedEventArgs e)
        {
            string textToCount = "";

            foreach (char c in dobaVypnuti.Text)
            {
                textToCount += c;
            }

            if (Int32.Parse(textToCount.Substring(3, 2)) > 59)
            {
                string message = "Nelze zadat počet minut větší než 59!";
                string title = "Chyba zadání!";
                MessageBox.Show(message, title);
                dobaVypnuti.Text = "00:00";
                return;
            }

            delay = (Int32.Parse(textToCount.Substring(0, 2)) * 3600) + (Int32.Parse(textToCount.Substring(3, 2)) * 60);

            dobaVypnuti.Text = "00:00";
            Startclock();
        }
    }
}