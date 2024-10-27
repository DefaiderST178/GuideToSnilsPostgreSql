using GuideToSnilsPostgreSql.Model;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace GuideToSnilsPostgreSql.View
{
    /// <summary>
    /// Логика взаимодействия для SelectedNote.xaml
    /// </summary>
    public partial class SelectedNote : Window
    {
        public SelectedNote(Notes selectedNotes)
        {
            InitializeComponent();
            NoteTB.Text = NoteTB.Text + Convert.ToInt32(selectedNotes.ID_Notes);

            TitleTB.Text = selectedNotes.Title;
            DescriptionTB.Text = selectedNotes.Description;

            string path = "/Image/" + selectedNotes.Images;
            ImageTB.Source = new BitmapImage(new Uri(path, UriKind.Relative));
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e) // открытие статей
        {
            try 
            {
                AllNotes allNotes = new AllNotes();
                this.Hide();
                allNotes.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка\n" + ex, "Система", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SnailsBtn_Click(object sender, RoutedEventArgs e) // открытие справочника
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
    }
}
