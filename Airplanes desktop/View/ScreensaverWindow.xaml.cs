using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Navigation;
using System.Threading;
using Airplanes_desktop.View;

namespace Airplanes_desktop
{

    public partial class ScreensaverWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        public ScreensaverWindow()
        {
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            timer.Stop();
            InitializeComponent();
            timer.Tick += new EventHandler(GoToMainWindow);
            timer.Interval = new TimeSpan(0, 0, 9);
            timer.Start();
        }
        public void GoToMainWindow(object sender, EventArgs e)
        {
            MainMenueWindow mainMenueWindow = new MainMenueWindow();
            mainMenueWindow.Show();
            this.Close();
            timer.Stop();
        }
    }
}
