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

            for (int i = 0; i < ransomNoteArray.Length; i++)
            {
                var val = ransomNoteArray[i];
                var exists = magazineArray.Contains(val);
                if (!exists)
                    return false;

                var countingRansom = ransomNoteArray.Count(e => e == val);

                var countintInMagazine = magazineArray.Count(e => e == val);
                if (countintInMagazine < countingRansom)
                {
                    return false;
                }
            }           

            return true;
        }
    }
}
