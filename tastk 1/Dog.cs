using System;
using System.Collections.Generic;
using System.Text;

namespace tastk_1
{
   public class Dog
    {

        public string name;
        public string race;
        public string color;

        public Dog(string aName, string aRace, string aColor)
        {
            name = aName;
            race = aRace;
            color = aColor;

        }

       public  string Eat()
        {
          return ("The dog is now eating. (dog)Mjom,mjom....");
        }


        public string Play()
        {
           return(" The dog is now playing.(dog)Wuf,wuf...!");
        }


        public string ChaseTail()
        {
            return(" Dog is now chasing its tail.(dog)Grrrrrrr..");
        }


    }


}




