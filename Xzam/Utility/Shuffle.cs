using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xzam.Models;
namespace Xzam.Utility
{
    public class Shuffle
    {
        /*
			Created by Luja Manandhar 
			Purpose: Shuffles the list of questions randomly sent as parameter for Do method
		*/
        private static List<int> randomNums; 
		public Shuffle(){ 
		}
        public static void Do(ref List<Question> list)
        {
			Random random = new Random ();
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
                 
                temp = list[i];
                list[i] = list[randomNums[i] - 1];
                list[randomNums[i] - 1] = temp;
            }
			temp = null;
			randomNums = null;
        }

    }
}
