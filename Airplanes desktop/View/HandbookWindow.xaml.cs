using Airplanes_desktop.Properties;
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
    /// Логика взаимодействия для HandbookWindow.xaml
    /// </summary>
    public partial class HandbookWindow : Window
    {
        public HandbookWindow()
        {
            InitializeComponent();
        }

        private void AirbusA380_Button_Click(object sender, RoutedEventArgs e)
        {
            PersonalAirplaneWindow personalAirplaneWindow = new PersonalAirplaneWindow();
            personalAirplaneWindow.AirplaneName.Text = "AIBUS A380";
            personalAirplaneWindow.mainAirplanePhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosMainAirplane/main_photo_a380.png"));
            personalAirplaneWindow.characteristics.Text = Properties.Resources.AirbusA380Characteristics;
            personalAirplaneWindow.firstFlight.Text = Properties.Resources.AirbusA380FirstFlight;
            personalAirplaneWindow.inFlightPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosInFlight/in_flight_a380.png"));
            personalAirplaneWindow.designPiculiarity.Text = Properties.Resources.AirbusA380DesignPeculiarity;
            personalAirplaneWindow.designPiculiarityPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosConstruction/construction_а380.png"));
            personalAirplaneWindow.technicalInovations.Text = Properties.Resources.AirbusA380TechnicalInovations;
            personalAirplaneWindow.technicalInovationsPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosCrewCabine/crew_cabine_a380.png"));
            personalAirplaneWindow.comfort.Text = Properties.Resources.AirbusA380Comfort;
            personalAirplaneWindow.comfortPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosComfort/comfort_a380.png"));
            personalAirplaneWindow.Show();
            this.Close();
        }

        private void AirbusA350_Button_Click(object sender, RoutedEventArgs e)
        {
            PersonalAirplaneWindow personalAirplaneWindow = new PersonalAirplaneWindow();
            personalAirplaneWindow.AirplaneName.Text = "AIBUS A350";
            personalAirplaneWindow.mainAirplanePhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosMainAirplane/main_photo_a350.png"));
            personalAirplaneWindow.characteristics.Text = Properties.Resources.AirbusA350Characteristics;
            personalAirplaneWindow.firstFlight.Text = Properties.Resources.AirbusA350FirstFlight;
            personalAirplaneWindow.inFlightPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosInFlight/in_flight_a350.png"));
            personalAirplaneWindow.designPiculiarity.Text = Properties.Resources.AirbusA350DesignPeculiarity;
            personalAirplaneWindow.designPiculiarityPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosConstruction/construction_а350.png"));
            personalAirplaneWindow.technicalInovations.Text = Properties.Resources.AirbusA350TechnicalInovations;
            personalAirplaneWindow.technicalInovationsPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosCrewCabine/crew_cabine_a350.png"));
            personalAirplaneWindow.comfort.Text = Properties.Resources.AirbusA350Comfort;
            personalAirplaneWindow.comfortPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosComfort/comfort_a350.png"));
            personalAirplaneWindow.Show();
            this.Close();
        }

        private void Boeing747_Button_Click(object sender, RoutedEventArgs e)
        {
            PersonalAirplaneWindow personalAirplaneWindow = new PersonalAirplaneWindow();
            personalAirplaneWindow.AirplaneName.Text = "BOEING 747-400";
            personalAirplaneWindow.mainAirplanePhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosMainAirplane/main_photo_747.png"));
            personalAirplaneWindow.characteristics.Text = Properties.Resources.Boeing747Characteristics;
            personalAirplaneWindow.firstFlight.Text = Properties.Resources.Boeing747FirstFlight;
            personalAirplaneWindow.inFlightPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosInFlight/in_flight_747.png"));
            personalAirplaneWindow.designPiculiarity.Text = Properties.Resources.Boeing747DesignPeculiarity;
            personalAirplaneWindow.designPiculiarityPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosConstruction/construction_747.png"));
            personalAirplaneWindow.technicalInovations.Text = Properties.Resources.Boeing747TechnicalInovations;
            personalAirplaneWindow.technicalInovationsPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosCrewCabine/crew_cabine_747.png"));
            personalAirplaneWindow.comfort.Text = Properties.Resources.Boeing747Comfort;
            personalAirplaneWindow.comfortPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosComfort/comfort_747.png"));
            personalAirplaneWindow.Show();
            this.Close();
        }

        private void Boeing777_Button_Click(object sender, RoutedEventArgs e)
        {
            PersonalAirplaneWindow personalAirplaneWindow = new PersonalAirplaneWindow();
            personalAirplaneWindow.AirplaneName.Text = "BOEING 777-200LR";
            personalAirplaneWindow.mainAirplanePhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosMainAirplane/main_photo_777.png"));
            personalAirplaneWindow.characteristics.Text = Properties.Resources.Boeing777Characteristics;
            personalAirplaneWindow.firstFlight.Text = Properties.Resources.Boeing777FirstFlight;
            personalAirplaneWindow.inFlightPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosInFlight/in_flight_777.png"));
            personalAirplaneWindow.designPiculiarity.Text = Properties.Resources.Boeing777DesignPeculiarity;
            personalAirplaneWindow.designPiculiarityPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosConstruction/construction_777.png"));
            personalAirplaneWindow.technicalInovations.Text = Properties.Resources.Boeing777TechnicalInovations;
            personalAirplaneWindow.technicalInovationsPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosCrewCabine/crew_cabine_777.png"));
            personalAirplaneWindow.comfort.Text = Properties.Resources.Boeing777Comfort;
            personalAirplaneWindow.comfortPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosComfort/comfort_777.png"));
            personalAirplaneWindow.Show();
            this.Close();
        }

        private void Concorde_Button_Click(object sender, RoutedEventArgs e)
        {
            PersonalAirplaneWindow personalAirplaneWindow = new PersonalAirplaneWindow();
            personalAirplaneWindow.AirplaneName.Text = "CONCORDE";
            personalAirplaneWindow.mainAirplanePhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosMainAirplane/main_photo_concorde.png"));
            personalAirplaneWindow.characteristics.Text = Properties.Resources.ConcordeCharacteristics;
            personalAirplaneWindow.firstFlight.Text = Properties.Resources.Boeing777FirstFlight;
            personalAirplaneWindow.inFlightPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosInFlight/in_flight_Concorde.png"));
            personalAirplaneWindow.designPiculiarity.Text = Properties.Resources.ConcordeDesignPeculiarity;
            personalAirplaneWindow.designPiculiarityPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosConstruction/construction_Concorde.png"));
            personalAirplaneWindow.technicalInovations.Text = Properties.Resources.ConcordeTechnicalInovations;
            personalAirplaneWindow.technicalInovationsPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosCrewCabine/crew_cabine_Concorde.png"));
            personalAirplaneWindow.comfort.Text = Properties.Resources.ConcordeComfort;
            personalAirplaneWindow.comfortPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosComfort/comfort_Concorde.png"));
            personalAirplaneWindow.Show();
            this.Close();
        }

        private void IL114_Button_Click(object sender, RoutedEventArgs e)
        {
            PersonalAirplaneWindow personalAirplaneWindow = new PersonalAirplaneWindow();
            personalAirplaneWindow.AirplaneName.Text = "ИЛ - 114";
            personalAirplaneWindow.mainAirplanePhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosMainAirplane/main_photo_IL114.png"));
            personalAirplaneWindow.characteristics.Text = Properties.Resources.IL114Characteristics;
            personalAirplaneWindow.firstFlight.Text = Properties.Resources.IL114FirstFlight;
            personalAirplaneWindow.inFlightPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosInFlight/in_flight_IL114.png"));
            personalAirplaneWindow.designPiculiarity.Text = Properties.Resources.IL114DesignPeculiarity;
            personalAirplaneWindow.designPiculiarityPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosConstruction/construction_IL114.png"));
            personalAirplaneWindow.technicalInovations.Text = Properties.Resources.IL114TechnicalInovations;
            personalAirplaneWindow.technicalInovationsPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosCrewCabine/crew_cabine_IL114.png"));
            personalAirplaneWindow.comfort.Text = Properties.Resources.IL114Comfort;
            personalAirplaneWindow.comfortPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosComfort/comfort_IL114.png"));
            personalAirplaneWindow.Show();
            this.Close();
        }

        private void IL96_Button_Click(object sender, RoutedEventArgs e)
        {
            PersonalAirplaneWindow personalAirplaneWindow = new PersonalAirplaneWindow();
            personalAirplaneWindow.AirplaneName.Text = "ИЛ - 96";
            personalAirplaneWindow.mainAirplanePhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosMainAirplane/main_photo_IL96.png"));
            personalAirplaneWindow.characteristics.Text = Properties.Resources.IL96Characteristics;
            personalAirplaneWindow.firstFlight.Text = Properties.Resources.IL96FirstFlight;
            personalAirplaneWindow.inFlightPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosInFlight/in_flight_IL96.png"));
            personalAirplaneWindow.designPiculiarity.Text = Properties.Resources.IL96DesignPeculiarity;
            personalAirplaneWindow.designPiculiarityPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosConstruction/construction_IL96.png"));
            personalAirplaneWindow.technicalInovations.Text = Properties.Resources.IL96TechnicalInovations;
            personalAirplaneWindow.technicalInovationsPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosCrewCabine/crew_cabine_IL96.png"));
            personalAirplaneWindow.comfort.Text = Properties.Resources.IL96Comfort;
            personalAirplaneWindow.comfortPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosComfort/comfort_IL96.png"));
            personalAirplaneWindow.Show();
            this.Close();
        }

        private void TU144_Button_Click(object sender, RoutedEventArgs e)
        {
            PersonalAirplaneWindow personalAirplaneWindow = new PersonalAirplaneWindow();
            personalAirplaneWindow.AirplaneName.Text = "ТУ - 144";
            personalAirplaneWindow.mainAirplanePhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosMainAirplane/main_photo_TU144.png"));
            personalAirplaneWindow.characteristics.Text = Properties.Resources.TU144Characteristics;
            personalAirplaneWindow.firstFlight.Text = Properties.Resources.TU144FirstFlight;
            personalAirplaneWindow.inFlightPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosInFlight/in_flight_TU144.png"));
            personalAirplaneWindow.designPiculiarity.Text = Properties.Resources.TU144DesignPeculiarity;
            personalAirplaneWindow.designPiculiarityPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosConstruction/construction_TU144.png"));
            personalAirplaneWindow.technicalInovations.Text = Properties.Resources.TU144TechnicalInovations;
            personalAirplaneWindow.technicalInovationsPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosCrewCabine/crew_cabine_TU144.png"));
            personalAirplaneWindow.comfort.Text = Properties.Resources.TU144Comfort;
            personalAirplaneWindow.comfortPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosComfort/comfort_TU144.png"));
            personalAirplaneWindow.Show();
            this.Close();
        }

        private void TU204_Button_Click(object sender, RoutedEventArgs e)
        {
            PersonalAirplaneWindow personalAirplaneWindow = new PersonalAirplaneWindow();
            personalAirplaneWindow.AirplaneName.Text = "ТУ - 204";
            personalAirplaneWindow.mainAirplanePhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosMainAirplane/main_photo_TU204.png"));
            personalAirplaneWindow.characteristics.Text = Properties.Resources.TU204Characteristics;
            personalAirplaneWindow.firstFlight.Text = Properties.Resources.TU204FirstFlight;
            personalAirplaneWindow.inFlightPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosInFlight/in_flight_TU204.png"));
            personalAirplaneWindow.designPiculiarity.Text = Properties.Resources.TU204DesignPeculiarity;
            personalAirplaneWindow.designPiculiarityPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosConstruction/construction_TU204.png"));
            personalAirplaneWindow.technicalInovations.Text = Properties.Resources.TU204TechnicalInovations;
            personalAirplaneWindow.technicalInovationsPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosCrewCabine/crew_cabine_TU204.png"));
            personalAirplaneWindow.comfort.Text = Properties.Resources.TU204Comfort;
            personalAirplaneWindow.comfortPhoto.Source = BitmapFrame.Create(new Uri(
                @"pack://application:,,,/Resources/Pictures/PhotosComfort/comfort_TU204.png"));
            personalAirplaneWindow.Show();
            this.Close();
        }
    }
}
