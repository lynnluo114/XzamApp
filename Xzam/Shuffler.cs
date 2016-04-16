using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xzam.Models;
namespace Xzam
{
    public class Shuffler
    {
        private Random random = new Random();
        private List<int> randomNums;
        private int max;
        public Shuffler(int max)
        {
            this.max = max;
        }

        public void Shuffle(ref List<Question> list)
        {
            randomNums = new List<int>(list.Count);
            int counter = list.Count;

            int num = 0;
            for (int i = 1; i <= counter; i++)
            {

                num = random.Next(1, counter);
                if (randomNums.Count != 0)
                {
                    while (randomNums.Contains(num))
                    {
                        num = random.Next(counter) + 1;
                    }
                }
                randomNums.Add(num);
            }
            // now proceed towards shuffling
            Question temp;
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(randomNums[i]);
                temp = list[i];
                list[i] = list[randomNums[i] - 1];
                list[randomNums[i] - 1] = temp;
            }
        }
        public int GetRandomNumber(List<int> excepted)
        {

            int counter = max;

            int num = 0;

            num = random.Next(1, counter);
            if (excepted.Count != 0)
            {
                while (excepted.Contains(num))
                {
                    num = random.Next(counter) + 1;
                }
            }

            return num;
        }
    }
}
