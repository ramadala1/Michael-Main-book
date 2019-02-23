using System;
using System.Collections.Generic;

namespace RandomNumberGenerator
{
    class Program
    {

        static void Main(string[] args)
        {
            RandomNumberGenerator _generate = new RandomNumberGenerator(1, 40, 3641, 729);

            // call the random number generator to print next 10 random integers 

            for(int i = 1; i <= 10; i++)
            {
               var rndNumber = _generate.GenerateRandomNumber();
                // change the seed value 
                _generate.ChangeSeed(rndNumber);
                Console.WriteLine(rndNumber);
            }

            Console.WriteLine("Next 10 Random integers");
            //set the random number seed to 44
            _generate.ChangeSeed(44);

            // call the random number generator to print next 10 random integers 
            for (int i = 1; i <= 10; i++)
            {
                var rndNumber = _generate.GenerateRandomNumber();
                // change the seed value 
                _generate.ChangeSeed(rndNumber);
                Console.WriteLine(rndNumber);
            }

            //set the random number seed to 36
            _generate.ChangeSeed(36);


            Console.WriteLine("Press Any Key to run test 2 , this would generate 729 different Numbers");
            Console.ReadLine();
            // Test 2 

            // hash set ensure uniqueness of elements in the collection , 
            // hence we can generate 729 diff random numbers .
            HashSet<int> randomNumbers = new HashSet<int>();

            // just resetting the seed value .
            _generate.ChangeSeed(1);
            for (int i = 1; i <= 729; i++)
            {
                // invoke Generate Random Number Method , that would return a Random Number
                int rndNumber = _generate.GenerateRandomNumber();

                // add the number to collectin 
                randomNumbers.Add(rndNumber);

                // change the seed value 
                _generate.ChangeSeed(rndNumber);

                // finally , print the number on the console 
                Console.WriteLine(rndNumber);

            }


            Console.ReadKey();
        }
    }
}
