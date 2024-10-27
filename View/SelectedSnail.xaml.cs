using GuideToSnilsPostgreSql.Model;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace GuideToSnilsPostgreSql.View
{
    /// <summary>
    /// Логика взаимодействия для SelectedSnail.xaml
    /// </summary>
    public partial class SelectedSnail : Window
    {
        private int ID {  get; set; }
        public SelectedSnail(Snail selectedSnail)
        {
            InitializeComponent();
            ID = Convert.ToInt32(selectedSnail.ID_snail)+1;
            IdTB.Text = ID.ToString();
            NameTB.Text = selectedSnail.Name;
            ScientificNameTB.Text = selectedSnail.ScientificName;
            DescriptionTB.Text = selectedSnail.Description;

            AverageShellSizeTB.Text = selectedSnail.AverageShellSize;
            ShellColorTB.Text = selectedSnail.ShellColor;
            BodyColorTB.Text = selectedSnail.BodyColor;
            LifeSpanInYearsTB.Text = selectedSnail.LifeSpanInYears;

            string path = "/Image/" + selectedSnail.Images;
            ImageTB.Source = new BitmapImage(new Uri(path, UriKind.Relative));
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e) // открытие справочника
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

        private void NotesBtn_Click(object sender, RoutedEventArgs e)  // открытие статей
        {
            try
            {
                AllNotes allNotes = new AllNotes();
                this.Hide();
                allNotes.Show();
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
