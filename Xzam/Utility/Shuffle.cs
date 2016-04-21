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

			How to use: 
			
			QuestionCollection qlist = new QuestionCollection();
			qlist.AddQuestion(new Question( ... ));
			qlist.AddQuestion(new Question( ... ));
			Shuffle.Do (ref qlist);

		*/
        private static List<int> randomNums; 
		 
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
		public static void Do(ref QuestionCollection qcol)
		{
			Random random = new Random ();
			randomNums = new List<int>(qcol.Count);
			int counter = qcol.Count;

			int num = 0;
			int i;
			for (i = 1; i <= counter; i++)
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
			i=0;
			foreach (Question q in qcol) {
				temp = qcol.QuestionList[i];
				qcol.QuestionList[i] = qcol.QuestionList[randomNums[i] - 1];
				qcol.QuestionList[randomNums[i] - 1] = temp;
				i++;
			}

			temp = null;
			randomNums = null;
		}

    }
}
