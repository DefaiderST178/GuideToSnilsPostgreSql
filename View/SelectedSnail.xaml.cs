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

    }
}
