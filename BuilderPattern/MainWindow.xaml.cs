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
using BuilderPattern.Builder;

namespace BuilderPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> list = new List<string>();

            VehicleBuilder builder;
            WorkShop _WorkShop = new WorkShop();
            


            builder = new ScooterBuilder();
            _WorkShop.Construct(builder);

            list = new List<string>();
            list = builder.Vehicle.Show();

            ucVehicelShow _ucVehicelShow = new ucVehicelShow(list);
            stkMain.Children.Add(_ucVehicelShow);
                        
            builder = new MotorCycleBuilder();
            _WorkShop.Construct(builder);

            list = new List<string>();
            list = builder.Vehicle.Show();
            ucVehicelShow _ucVehicelShow1 = new ucVehicelShow(list);
            stkMain.Children.Add(_ucVehicelShow1);



            builder = new CarBuilder();
            _WorkShop.Construct(builder);

            list = new List<string>();
            list = builder.Vehicle.Show();
            ucVehicelShow _ucVehicelShow2 = new ucVehicelShow(list);
            stkMain.Children.Add(_ucVehicelShow2);
        }
    }
}
