using System;
using System.Collections.Generic;

namespace Oisann {
    class First {
        static void Main(string[] args) {
            string line;
            int frequency = 0;
            List<int> numbers = new List<int>();
            int counter = 0;

            while(counter >= 0) {
                System.IO.StreamReader file = new System.IO.StreamReader(@System.Environment.CurrentDirectory + "/input.txt");
                while((line = file.ReadLine()) != null) {
                    frequency += int.Parse(line);

                    if(numbers.Contains(frequency)) {
                        System.Console.WriteLine("Answer for the second puzzle: {0}.", frequency);
                        counter = -1;
                        file.Close();
                        return;
                    }

                    numbers.Add(frequency);
                }
                file.Close();
                if(counter == 0)
                    System.Console.WriteLine("Answer for the first puzzle: {0}.", frequency);
                counter++;
            }
        }
    }
}
