using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{
    public class Scrabble
    {
        private string _word;
        public Dictionary<char, int> scoreMap = new Dictionary<char, int>
        {
            { 'A', 1 },
            { 'B', 3 },
            { 'C', 3 },
            { 'D', 2 },
            { 'E', 1 },
            { 'F', 4 },
            { 'G', 2 },
            { 'H', 4 },
            { 'I', 1 },
            { 'J', 8 },
            { 'K', 5 },
            { 'L', 1 },
            { 'M', 3 },
            { 'N', 1 },
            { 'O', 1 },
            { 'P', 3 },
            { 'Q', 10 },
            { 'R', 1 },
            { 'S', 1 },
            { 'T', 1 },
            { 'U', 1 },
            { 'V', 4 },
            { 'W', 4 },
            { 'X', 8 },
            { 'Y', 4 },
            { 'Z', 10 }
        };
        public Scrabble(string word)
        {            
            _word = word;
        }

        public int score()
        {
            if (_word == "")
            {
                return 0;
            }
            int score = 0;
            foreach (char letter in this._word)
            {
                if (!Char.IsLetter(letter))
                {
                    return 0;
                }

                int letterScore = scoreMap[Char.ToUpper(letter)];

                if (letterScore < 0)
                {
                    return 0;
                }
                score += letterScore;
            }
            
            return score;
        }
    }
}
