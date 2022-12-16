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
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        short nowYoureOnThisQuestion = 1;
        short balls;
        string[] questions = new string[10] { "Первый пассажирский самолёт, преодолевший скорость звука - ",
            "Самая старая компания-авиапроизводитель в мире - ",
            "Самый большой в мире пассажирский самолёт – ",
            "С помощью чего в ручном режиме управляются современные самолёты Boeing и Airbus",
            "Что у Конкорда и Ту-144 заменяет закрылки и интерцепторы",
            "Сколько двигателей у Ил – 96 – 400М?",
            "Почему Airbus A350 так популярен?",
            "Почему Ту-144 и Конкорд так быстро сняли с производства",
            "Сколько палуб у Boeing 747-400?",
            "В каком году началась эксплуатация Ту-204"};
        string[,] answers = new string[10, 3] { { "Concorde", "Ту - 144", "Ил - 96" }, {"Airbis", "Boeing", "Ту (Туполев)"},{ "Airbus A380", "Boeing 747", "Ил - 114" },
                {"Штурал", "Джойстик (Side-stick)", "Сила мысли" }, {"Аэродинамический тормоз", "Механизм изменяемой геометрии носа", "Элероны" }, {"2", "3", "4" }, {"Из за своей надёжности", "Из за малого расхода топлива и большого количества пассажирских мест", "Из за лёгкости в обслуживании*" },
            {"Эксплуатация была невыгодна", "Малое количество пассажирских мест", "Ошибки проектирования, повлёкшие за собой катастрофы" }, {"2", "1", "6" }, {"1989", "2001", "1996" } };
        short[] rightAnswers = new short[10] { 2, 2, 1, 2, 2, 3, 2, 3, 1, 3 };
        public GameWindow()
        {
            InitializeComponent();
            question.Text = questions[0];
            firstAnswer.Content = answers[0, 0];
            secondAnswer.Content = answers[0, 1];
            thirdAnswer.Content = answers[0, 2];


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(firstAnswer.IsChecked == true || secondAnswer.IsChecked == true || thirdAnswer.IsChecked == true)
            {

                if((firstAnswer.IsChecked == false && secondAnswer.IsChecked == false) ||
                    (firstAnswer.IsChecked == false && secondAnswer.IsChecked == false) || (firstAnswer.IsChecked == false && thirdAnswer.IsChecked == false) ||
                    (secondAnswer.IsChecked == false && thirdAnswer.IsChecked == false))
                {

                    if(firstAnswer.IsChecked == true)
                    {
                        if (rightAnswers[nowYoureOnThisQuestion - 1] == 1)
                            balls++;
                    }
                    if(secondAnswer.IsChecked == true)
                    {
                        if (rightAnswers[nowYoureOnThisQuestion - 1] == 2)
                                balls++;
                    }
                    if(thirdAnswer.IsChecked == true)
                    {
                        if (rightAnswers[nowYoureOnThisQuestion - 1] == 3)
                            balls++;
                    }

                    if (nowYoureOnThisQuestion <= 9)
                    {
                        firstAnswer.IsChecked = false;
                        secondAnswer.IsChecked = false;
                        thirdAnswer.IsChecked = false;
                        nowYoureOnThisQuestion++;
                        question.Text = questions[nowYoureOnThisQuestion - 1];
                        firstAnswer.Content = answers[nowYoureOnThisQuestion - 1, 0];
                        secondAnswer.Content = answers[nowYoureOnThisQuestion - 1, 1];
                        thirdAnswer.Content = answers[nowYoureOnThisQuestion - 1, 2];
                    }
                    else
                    {
                        MessageBox.Show("Поздравляем, вы набрали " + balls + " очков из 10!", "Конец игры", MessageBoxButton.OK, MessageBoxImage.Information);
                        MainMenueWindow mainMenueWindow = new MainMenueWindow();
                        mainMenueWindow.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Выберите только 1 ответ!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    firstAnswer.IsChecked = false;
                    secondAnswer.IsChecked = false;
                    thirdAnswer.IsChecked = false;
                }
            }
            else
            {
                MessageBox.Show("Выберите 1 вариант ответа", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
