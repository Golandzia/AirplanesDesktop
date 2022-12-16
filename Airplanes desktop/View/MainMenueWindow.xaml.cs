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
using System.Windows.Shapes;

namespace Airplanes_desktop.View
{
    /// <summary>
    /// Логика взаимодействия для MainMenueWindow.xaml
    /// </summary>
    public partial class MainMenueWindow : Window
    {
        public MainMenueWindow()
        {
            InitializeComponent();
        }

        private void HandbookButton_Click(object sender, RoutedEventArgs e)
        {
            HandbookWindow handbookWindow = new HandbookWindow();
            handbookWindow.Show();
            this.Close();
        }

        private void GameButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AboutProgramButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
