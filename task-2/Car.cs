using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
  public class Car
    {
        public string Model;
        public int Speed;
        public int Driver;


        public Car(string aModel, int aSpeed, int aDriver)
        {
            Model = aModel;
            Speed = aSpeed;
            Driver = aDriver;
        }

            
        public int CalculateSpeed(Driver driverObject,Car carObject)
        {
            int res = driverObject.Skill * carObject.Speed;
            return res;
        }

        

    }

  

}
