using GuideToSnilsPostgreSql.Model;
using Npgsql;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;

namespace GuideToSnilsPostgreSql.View
{
    /// <summary>
    /// Логика взаимодействия для AllSnails.xaml
    /// </summary>
    public partial class AllSnails : Window
    {
        private ObservableCollection<Snail> snails = new ObservableCollection<Snail>();
        public AllSnails()
        {
            InitializeComponent();
            using (NpgsqlConnection conn = new NpgsqlConnection("server=localhost;port=5432;database=SnailsDB;user id=postgres;password=12345"))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM Snails", conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            snails.Add(new Snail
                            {
                                ID_snail = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                ScientificName = reader.GetString(2),
                                Description = reader.GetString(3),
                                Images = reader.GetString(4),
                                AverageShellSize = reader.GetString(5),
                                ShellColor = reader.GetString(6),
                                BodyColor = reader.GetString(7),
                                LifeSpanInYears = reader.GetString(8)
                            });
                        }
                    }
                }
            }

            snailListView.ItemsSource = snails;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e) // назад
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка\n" + ex, "Система", MessageBoxButton.OK, MessageBoxImage.Error);
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

        private void SnailsList_SelectionChanged(object sender, SelectionChangedEventArgs e) // выбор улитки
        {
            try
            {
                if (snailListView.SelectedItem != null)
                {
                    Snail selectedSnail = (Snail)snailListView.SelectedItem; 
                    SelectedSnail snailDetailsWindow = new SelectedSnail(selectedSnail);
                    this.Hide();
                    snailDetailsWindow.Show();
                    this.Close();
                }

                
                MessageBox.Show("Переход успешен", "Система", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка\n" + ex, "Система", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
