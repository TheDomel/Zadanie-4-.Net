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
using System.Xml;

namespace Zadanie_4
{
    /// <summary>
    /// Logika interakcji dla klasy InterfejsGrupy.xaml
    /// </summary>
    public partial class InterfejsGrupy : Window
    {
        public InterfejsGrupy(XmlNode kategorie)
        {
            DataContext = kategorie;
            InitializeComponent();
        }
        private void Widok(object sender, RoutedEventArgs e)
        {
            ListBox lista = (ListBox)FindName("Pojazdy");
            XmlNode blok = (XmlNode)lista.SelectedItem;
            if (blok != null)
                new InterfejsAut(blok).Show();
        }
    }
}