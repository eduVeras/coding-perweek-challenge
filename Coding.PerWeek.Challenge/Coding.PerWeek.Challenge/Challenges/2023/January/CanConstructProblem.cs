using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.PerWeek.Challenge.Challenges._2023.January
{
    public class CanConstructProblem
    {

        /// <summary>
        /// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
        ///Each letter in magazine can only be used once in ransomNote.
        /// </summary>
        /// <param name="ransomNote"></param>
        /// <param name="magazine"></param>
        /// <returns></returns>
        public bool CanConstruct(string ransomNote, string magazine)
        {

            var magazineArray = magazine.ToCharArray();
            var ransomNoteArray = ransomNote.ToCharArray();
            foreach (char c in ransomNoteArray)
            {
                var exists = magazineArray.Contains(c);
                if(!exists)
                    return false;

                var countingRansom = ransomNoteArray.Count(e=> e==c);

                var countintInMagazine = magazineArray.Count(e=> e==c);
                if(countintInMagazine < countingRansom)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
