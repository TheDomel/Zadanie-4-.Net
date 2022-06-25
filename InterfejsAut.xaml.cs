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
    /// Logika interakcji dla klasy InterfejsAut.xaml
    /// </summary>
    public partial class InterfejsAut : Window
    {
        public InterfejsAut(XmlNode auto)
        {
            DataContext = auto;
            InitializeComponent();
        }
    }
}
