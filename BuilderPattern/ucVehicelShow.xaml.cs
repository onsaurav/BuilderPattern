using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace BuilderPattern
{
    /// <summary>
    /// Interaction logic for ucVehicelShow.xaml
    /// </summary>
    public partial class ucVehicelShow : UserControl
    {
        public ucVehicelShow(List<string> list)
        {
            InitializeComponent();

            txtType.Text = list[0];
            txtEngin.Text = list[1];
            txtWheels.Text = list[2];
            txtDoors.Text = list[3];

            if (list[0].Equals("Motor Cycle"))
            {
                var uriSource = new Uri(@"/BuilderPattern;component/images/motorcycle.ico", UriKind.Relative);
                imgOutlook.Source = new BitmapImage(uriSource);
            }
            else if (list[0].Equals("Scooter"))
            {
                var uriSource = new Uri(@"/BuilderPattern;component/images/car.ico", UriKind.Relative);
                imgOutlook.Source = new BitmapImage(uriSource);
            }
            else if (list[0].Equals("CAR"))
            {
                var uriSource = new Uri(@"/BuilderPattern;component/images/chrysler.ico", UriKind.Relative);
                imgOutlook.Source = new BitmapImage(uriSource);
            }
        }
    }
}
