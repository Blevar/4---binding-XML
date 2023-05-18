using System;
using System.Collections;
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
using System.Xml;

namespace _4___binding_XML
{
    /// <summary>
    /// Logika interakcji dla klasy CategoriesWindow.xaml
    /// </summary>
    public partial class CategoriesWindow : Window
    {
        ListBox listaPodkategorii;

        public CategoriesWindow(XmlElement kategoria)
        {
            DataContext = kategoria;
            InitializeComponent();
            listaPodkategorii = (ListBox)FindName("ListaPodkategorii");
        }

        private void WidokWybranejPodkategorii(object sender, RoutedEventArgs e)
        {
            XmlElement wybrany = (XmlElement)listaPodkategorii.SelectedItem;
            new VehicleView(wybrany).Show();
        }
    }
}

