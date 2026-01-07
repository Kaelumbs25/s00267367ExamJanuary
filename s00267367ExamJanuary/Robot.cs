using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s00267367ExamJanuary
{
    public enum HouseholdSkill { Cooking, Cleaning, Laundry, Gardening, ChildCare }
    public enum DeliveryMode { Walking, Driving, Flying }

    abstract class Robot
    {
        public string RobotName {  get; set; }
        public double PowerCapacityKWH { get; set; }
        public double CurrentPowerKWH { get; set; }

        public double GetBatteryPercentage()
        {

            return (CurrentPowerKWH/PowerCapacityKWH)*100;
        }

        public string DisplayBatteryInfo()
        {
            return $"Battery Info\nCapacity: {PowerCapacityKWH}\nCurrent Power: {CurrentPowerKWH}\nBattery Level: {GetBatteryPercentage()}%";
        }

        public virtual string DescribeRobot()
        {
            return DisplayBatteryInfo();
        }

        public override string ToString()
        {
            return $"{RobotName} - []";
        }
    }

    class HouseholdRobot : Robot
    {
        private List<HouseholdSkill> Skills { get; set; }

        public override string DescribeRobot()
        {
            string description = $"I am a household robot. I can help around the house with chores.\n Household skills:\n";

            for (int i = 0; i < Skills.Count(); i++) 
            {
                description.Insert(description.Length, $"{Skills[i]}\n");
            }

            return description + base.DescribeRobot();
        }
    }

    class DeliveryRobot : Robot
    {
        public DeliveryMode ModeOfDelivery {  get; set; }

        public double MaxLoadKG { get; set; }

        public override string DescribeRobot()
        {
            string description = $"I am a delivery robot.\n\nI specialise in delivery by {ModeOfDelivery}\n The maximum load I can carry is {MaxLoadKG} kg";

            return description + base.DescribeRobot();
        }
    }
}
