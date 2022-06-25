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
using System.Xml;

namespace Zadanie_4
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Widok(object sender, RoutedEventArgs e)
        {
            ListBox lista = (ListBox)FindName("kategorie");
            XmlNode kategorie = (XmlNode)lista.SelectedItem;
            if (kategorie != null)
                new InterfejsGrupy(kategorie).Show();
        }
    }
}
