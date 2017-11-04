namespace BowlingScoreCalculator.Logic
{
    public class BowlingCalculator
    {
        private const int MAX_PINS = 10;
        private string _frameSeparator = "|";
        private char[] _balls;


        public int Calculate(string input)
        {
            _balls = input.ToUpper().Replace('-', '0').Replace(_frameSeparator, string.Empty).ToCharArray();

            var total = 0;

            for (int i = 0; i < _balls.Length; i++)
            {
                if (_balls[i].Equals('X'))
                {
                    total += GetStrikeValue(i);
                }
                else if (_balls[i].Equals('/'))
                {
                    total += GetSpareValue(i);
                    if (i == _balls.Length - 2) break ;
                }
                else
                {
                    total += GetPinCount(i);
                }
            }

            return total;
        }

        private int GetStrikeValue(int index)
        {
            int ballOne = 0, ballTwo = 0;
            int ballOneIndex = index + 1;
            int ballTwoIndex = index + 2;

            if(ballTwoIndex < (_balls.Length -1))
            {
                ballOne = GetPinCount(ballOneIndex);
                ballTwo = GetPinCount(ballTwoIndex);
            }

            return MAX_PINS + ballOne + ballTwo;
        }

        private int GetSpareValue(int index)
        {            
            return GetPinCount(index) + GetPinCount(index + 1);
        }

        private int GetPinCount(int index)
        {
            char value = _balls[index];

            if (value.Equals('X'))
            {
                return 10;
            }

            if (value.Equals('/'))
            {
                return MAX_PINS - int.Parse(_balls[index - 1].ToString());
            }

            return int.Parse(value.ToString());
        }
    }
}
