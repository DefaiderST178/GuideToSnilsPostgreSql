using GuideToSnilsPostgreSql.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace GuideToSnilsPostgreSql.View
{
    /// <summary>
    /// Логика взаимодействия для AllNotes.xaml
    /// </summary>
    public partial class AllNotes : Window
    {
        private ObservableCollection<Notes> notes = new ObservableCollection<Notes>();
        public AllNotes()
        {
            InitializeComponent();

            using (NpgsqlConnection conn = new NpgsqlConnection("server=localhost;port=5432;database=SnailsDB;user id=postgres;password=12345"))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM Notes", conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            notes.Add(new Notes
                            {
                                ID_Notes = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Description = reader.GetString(2),
                                Images = reader.GetString(4),
                            });
                        }
                    }
                }
            }

            notesListView.ItemsSource = notes;
        }

        private void BookBtn_Click(object sender, RoutedEventArgs e) // открытие справочника
        {
            try
            {
                AllSnails allSnails = new AllSnails();
                this.Hide();
                allSnails.Show();
                this.Close();
                MessageBox.Show("Переход успешен", "Система", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка\n" + ex, "Система", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void notesListView_SelectionChanged(object sender, SelectionChangedEventArgs e) // открытие выбранной статьи
        {
            try
            {
                if (notesListView.SelectedItem != null)
                {
                    Notes selectedNotes = (Notes)notesListView.SelectedItem;
                    SelectedNote selectedNoteWindow = new SelectedNote(selectedNotes);
                    this.Hide();
                    selectedNoteWindow.Show();
                    this.Close();
                }
                MessageBox.Show("Переход успешен", "Система", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка\n" + ex, "Система", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e) // на главную
        {
            try
            {
                MainWindow mainWindow = new MainWindow();
                this.Hide();
                mainWindow.Show();
                this.Close();
                MessageBox.Show("Переход успешен", "Система", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка\n" + ex, "Система", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
