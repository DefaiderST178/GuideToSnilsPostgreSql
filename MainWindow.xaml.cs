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
