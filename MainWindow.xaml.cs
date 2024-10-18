using GuideToSnilsPostgreSql.View;
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

        }
    }
}
