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

        private void dobaVypnuti_TextChanged(object sender, TextChangedEventArgs e)
        {
            if((dobaVypnuti.Text.Length == 2) || (dobaVypnuti.Text.Length == 5))
            {
                dobaVypnuti.Text = ":" + dobaVypnuti.Text;
            }
        }

        private void spustOdpocet_Click(object sender, RoutedEventArgs e)
        {
            List<char> delayValue = new List<char>();
            //int realDelay = 0;
            string textToCount = "";

            foreach (char c in dobaVypnuti.Text)
            {
                textToCount += c;
            }

            textToCount = String.Join("", textToCount.Split(':'));

            // evenodd určuje, zda poslední číslice času je lichá nebo sudá, a podle toho se následně provádí výpočet delay
            int evenodd = textToCount.Length % 2 == 0 ? 2 : 1;
            delay = 0;
            if (textToCount.Length <= 2)
            {
                delay = Int32.Parse(textToCount);
            }
            else if (textToCount.Length <= 4)
            {
                //delay = textToCount.Length;
                delay = (Int32.Parse(textToCount.Substring(0, evenodd)) * 60) + (Int32.Parse(textToCount.Substring(evenodd, 2)));
                //delay = 60 * Int32.Parse(textToCount.Substring(0, 2));
            }
            else
            {
                delay = (Int32.Parse(textToCount.Substring(0, evenodd)) * 3600) + (Int32.Parse(textToCount.Substring(evenodd, 2)) * 60) + (Int32.Parse(textToCount.Substring((2 + evenodd),2)));
            }
            

            //textToCount = "";
            //datelbl.Text = delay.ToString();
            //datelbl.Text = textToCount;
            dobaVypnuti.Text = null;
            Startclock();
        }
    }
}