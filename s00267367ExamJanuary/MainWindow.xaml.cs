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

namespace s00267367ExamJanuary
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

        public void CreateRobots()
        {
            HouseholdRobot HouseBot = new HouseholdRobot("HouseBot", 100, 100);
            HouseholdRobot GardenMate = new HouseholdRobot("GardenMate", 100, 100);
            HouseholdRobot Housemate3000 = new HouseholdRobot("Housemate 3000", 100, 100);
            DeliveryRobot DeliverBot = new DeliveryRobot("DeliverBot", 100, 100);
            DeliveryRobot FlyBot = new DeliveryRobot("FlyBot", 100, 100);
            DeliveryRobot Driver = new DeliveryRobot("Driver", 100, 100);

        }
    }
}
