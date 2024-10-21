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

namespace GuideToSnilsPostgreSql.View
{
    /// <summary>
    /// Логика взаимодействия для AllNotes.xaml
    /// </summary>
    public partial class AllNotes : Window
    {
        public AllNotes()
        {
            InitializeComponent();
        }

        private void BookBtn_Click(object sender, RoutedEventArgs e) // справочник
        {

        }

        private void notesListView_SelectionChanged(object sender, SelectionChangedEventArgs e) // к выбранной статье
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e) // на главную
        {

        }
    }
}
