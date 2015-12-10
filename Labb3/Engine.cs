using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    public class Engine
    {
        private double speed;
        private double horsepowers;
        //private double fuelconsumtion;

        public void SetSpeed(double speed)
        {       
                this.speed = speed;    
        }
        public double GetSpeed()
        {
            return speed;
        }
        public void SetHorsepowers(double horsepowers)
        {
            this.horsepowers = horsepowers;
        }
        public double GetHorsepowers()
        {
            return horsepowers;
        }
        //public void SetFuelConsumption(double fuelconsumption)
        //{
        //    this.fuelconsumtion = (fuelconsumtion + horsepowers) * speed;

        //    }
        public double GetFuelConsumptionCar()
        {
            if (speed > 150 && horsepowers > 200)
                return 2;
            else if (speed > 50 && speed < 140 || horsepowers > 100 && horsepowers < 180)
                return 1.5;
            else
                return 1;

            }
        public double GetFuelConsumptionMc()
        {
            if (speed > 150 && horsepowers > 200)
                return 1;
            else if (speed > 50 && speed < 140 || horsepowers > 100 && horsepowers < 180)
                return 0.55;
            else
                return 0.3;

        }
    }
    }

