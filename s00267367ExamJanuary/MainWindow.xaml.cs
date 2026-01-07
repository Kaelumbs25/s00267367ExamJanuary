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
    /// repository link :https://github.com/Kaelumbs25/s00267367ExamJanuary.git
    public partial class MainWindow : Window
    {
        public List<Robot> Robots = new List<Robot> { };

        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void CreateRobots()
        {
            HouseholdRobot HouseBot = new HouseholdRobot("HouseBot", 100, 10);
            Robots.Add(HouseBot);
            HouseholdRobot GardenMate = new HouseholdRobot("GardenMate", 100, 100);
            Robots.Add(GardenMate);
            HouseholdRobot Housemate3000 = new HouseholdRobot("Housemate 3000", 100, 70);
            Robots.Add(Housemate3000);
            DeliveryRobot DeliverBot = new DeliveryRobot("DeliverBot", 100,4);
            Robots.Add(DeliverBot);
            DeliveryRobot FlyBot = new DeliveryRobot("FlyBot", 100, 40);
            Robots.Add(FlyBot);
            DeliveryRobot Driver = new DeliveryRobot("Driver", 100, 100);
            Robots.Add(Driver);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CreateRobots();
            lbxRobots.ItemsSource = Robots;
        }

        private void lbxRobots_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Robot robot = lbxRobots.SelectedItem as Robot;
            tbxDetails.Text = robot.DescribeRobot();
        }

        private void rbtnAll_Checked(object sender, RoutedEventArgs e)
        {
            
            lbxRobots.ItemsSource = null;
            lbxRobots.ItemsSource = Robots;
        }

        private void rbtnHouse_Checked(object sender, RoutedEventArgs e)
        {
            List<Robot> filtered = new List<Robot>();
            foreach (Robot robot in Robots)
            {
                string test = robot.ToString();
                
                if (test.Contains("Household"))
                {
                    filtered.Add(robot);
                }
            }
            lbxRobots.ItemsSource = null;
            lbxRobots.ItemsSource = filtered;
        }

        private void rbtnDelivery_Checked(object sender, RoutedEventArgs e)
        {
            List<Robot> filtered = new List<Robot>();
            foreach (Robot robot in Robots)
            {
                string test = robot.ToString();

                if (test.Contains("Delivery"))
                {
                    filtered.Add(robot);
                }
            }
            lbxRobots.ItemsSource = null;
            lbxRobots.ItemsSource = filtered;
        }

        private void btnCharge_Click(object sender, RoutedEventArgs e)
        {
            Robot robot = lbxRobots.SelectedItem as Robot;

            double time = (100-robot.GetBatteryPercentage())*.5;

            if(robot.GetBatteryPercentage() < 100)
            {
                MessageBox.Show($"Robot fully charged! Time taken: {time} minutes");
            }
            else
            {
                MessageBox.Show("Robot is already fully charged.");
            }
        }
    }
}
