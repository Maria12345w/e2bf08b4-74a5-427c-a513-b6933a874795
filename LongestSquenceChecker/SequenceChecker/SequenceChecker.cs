using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SequenceChecker
{
    public class SequenceChecker : ISequenceChecker
    {
        public string CheckLongestSequence(string inputString)
        {
            List<string> list = inputString.Split(' ').ToList();

            var item = inputString.Split(' ');
            StringBuilder ascendingSeq = new StringBuilder();
            List<string> seq = new List<string>();

            for (int i = 0; i < item.Length; i++)
            {
                if (i == 0)
                {
                    if (item.Length > 1 && int.Parse(item[i]) < int.Parse(item[i + 1]))
                    {
                        ascendingSeq.Append(item[i] + " ");

                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    if (item.Length != i + 1 && int.Parse(item[i + 1]) > int.Parse(item[i]))
                    {
                        //If the previous one is less than current, and if ascendingSeq is empty then it's a new seq
                        // hence we need to add that to the begining of the list.
                        if (string.IsNullOrEmpty(ascendingSeq.ToString()))
                        {
                            ascendingSeq.Append(item[i] + " ");
                        }
                    }

                    if (item.Length != i + 1 && (int.Parse(item[i]) < int.Parse(item[i + 1])))
                    {
                        ascendingSeq.Append(item[i + 1] + " ");
                    }

                    else
                    {
                        seq.Add(ascendingSeq.ToString());
                        ascendingSeq.Clear();
                        
                        continue;
                    }
                }
            }

            seq.Add(ascendingSeq.ToString());
            seq.Reverse();
            var longestSequence = seq.Aggregate("", (longest, item2) => longest.Split(' ').Count() > item2.Split(' ').Count() ? longest : item2);
            //var longestSequence = seq.OrderBy(x => x.Trim().Length).FirstOrDefault();
            return longestSequence.ToString().Trim();
        }
    }
}
