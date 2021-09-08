using System;

namespace Lekcija2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 15; // vesels skaitlis
            char myFavouriteLetter = 'A'; // simbols
            bool isCar = true; // loģiskais true/false
            double myConstant = 4.58; // decimālskaitlis
            float myChangingNum = 2.46f; // mazāk ciparu aiz komata decimālskaitlis
            string name = "Artis dsfdsg sgdfsg nsfkj "; // teksts

            Console.WriteLine(myNumber);
            Console.WriteLine(myFavouriteLetter);
            Console.WriteLine(isCar);
            Console.WriteLine(myConstant);
            Console.WriteLine(myChangingNum);
            Console.WriteLine(name);

            Console.WriteLine(myConstant + myChangingNum);

            //-----------------------------------------------------------------------------------------

            int myNumber1 = 4;
            int myNumber2 = 6;

            int sum1 = myNumber1 + myNumber2;

            Console.WriteLine(sum1);

            string name1 = "Helli";
            string name2 = "from code";

            string namesTogether = name1 + " " + name2;

            Console.WriteLine(namesTogether);

            int withPluses = 4;
            withPluses++;

            Console.WriteLine(withPluses);

            int divisionReminder1 = 49;
            int divisionReminder2 = 10;

            int divisionReminderResult = divisionReminder1 % divisionReminder2;

            Console.WriteLine(divisionReminderResult);

            //---------------------------------------------------------------------





        }
    }
}
