using System;

namespace HowToWriteCleanCodeInCSharp
{
    class GiveName
    {
        public void NumberWithoutName()
        {
            var myAge = 18;

            if (myAge > 50)
            {
                Console.WriteLine("I should retire.");
            }
        }

        public void NumberWithName()
        {
            var myAge = 18;

            var retiredAge = 50;

            if (myAge > retiredAge)
            {
                Console.WriteLine("I should retire.");
            }
        }

        public void ConditionsWithoutName()
        {
            var myAge = 18;

            if (20 <= myAge && myAge <= 50)
            {
                Console.WriteLine("I need to work.");
            }
        }

        public void ConditionsWithName()
        {
            var myAge = 18;

            var isWorkingAge = myAge >= 20 
                            && myAge <= 50;

            if (isWorkingAge)
            {
                Console.WriteLine("I need to work.");
            }
        }

        public void LogicWithoutName()
        {

        }

        public void LogicWithName()
        {

        }
    }
}
