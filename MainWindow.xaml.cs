using GuideToSnilsPostgreSql.View;
using System;
using System.Windows;

namespace GuideToSnilsPostgreSql
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FirstTB.Text = "Здесь вы найдете исчерпывающую информацию о различных видах улиток, их особенностях и требониях к содержанию.";
            SecondTB.Text = "Наше приложение предназначено как для начинающих, так и для опытных любителей улиток. Мы постарались сделать его максимально удобным и информативным, чтобы каждый пользователь мог найти ответы на все свои вопросы.";
        }

        private void SnailsBtn_Click(object sender, RoutedEventArgs e) // открытие справочника
        {
            try
            {
                AllSnails allSnails = new AllSnails();
                this.Hide();
                allSnails.Show();
                this.Close();
                MessageBox.Show("Переход успешен","Система",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка\n"+ex, "Система", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void NotesBtn_Click(object sender, RoutedEventArgs e) // открытие статей
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка\n" + ex, "Система", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
