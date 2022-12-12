namespace Coding.PerWeek.Challenge.Challenges._2022.November
{
    public class RomanToInt
    {
        /// <summary>
        /// s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
        //It is guaranteed that s is a valid roman numeral in the range[1, 3999].
        //I             1
        //V             5
        //X             10
        //L             50
        //C             100
        //D             500
        //M             1000
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int RomanToIntSolution(string s)
        {

            int total = 0;
            var arrayS = s.ToCharArray();
            bool continueAgain = false;

            for (int i = 0; i < arrayS.Length; i++)
            {
                var hasNext = i + 1 < arrayS.Length;

                if (continueAgain)
                {
                    continueAgain = false;
                    continue;
                }

                if (arrayS[i].Equals('I'))
                {
                    if (hasNext)
                    {
                        if (arrayS[i + 1].Equals('V'))
                        {
                            total += 4;
                            continueAgain = true;
                            continue;
                        }
                        if (arrayS[i + 1].Equals('X'))
                        {
                            total += 9;
                            continueAgain = true;
                            continue;
                        }
                    }
                    total += 1;
                    continue;
                }

                if (arrayS[i].Equals('V'))
                {
                    total += 5;
                    continue;
                }

                if (arrayS[i].Equals('X'))
                {
                    if (hasNext)
                    {
                        if (arrayS[i + 1].Equals('L'))
                        {
                            total += 40;
                            continueAgain = true;
                            continue;
                        }
                        if (arrayS[i + 1].Equals('C'))
                        {
                            total += 90;
                            continueAgain = true;
                            continue;
                        }
                    }
                    total += 10;
                    continue;
                }

                if (arrayS[i].Equals('L'))
                {
                    total += 50;
                    continue;
                }
                if (arrayS[i].Equals('C'))
                {
                    if (hasNext)
                    {
                        if (arrayS[i + 1].Equals('D'))
                        {
                            total += 400;
                            continueAgain = true;
                            continue;
                        }
                        if (arrayS[i + 1].Equals('M'))
                        {
                            total += 900;
                            continueAgain = true;
                            continue;
                        }
                    }
                    total += 100;
                    continue;
                }

                if (arrayS[i].Equals('D'))
                {
                    total += 500;
                    continue;
                }

                if (arrayS[i].Equals('M'))
                {
                    total += 1000;
                    continue;
                }
            }

            return total;
        }
    }
}
