using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.BowlingGame
{
    public class Game
    {
        List<int> _rollsPinsHit = new List<int>(21);
      
        public void Roll(int pinsHit)
        {
            _rollsPinsHit.Add(pinsHit);
        }

        public int Score
        {
            get
            {
                int score = 0;
                int frameIndex = 0;
                for (int frame = 0; frame < 10; frame++)
                {
                    if (IsStrike(frameIndex))
                    {
                    score+=10 + StrikeBonus(frameIndex);
                        frameIndex ++;
                    }
                    else if (IsSpare(frameIndex))
                    {
                        score += 10 + SpareBonus(frameIndex);
                        frameIndex += 2;
                    }
                    else
                    {
                        score += NormalFrameBonus(frameIndex);
                        frameIndex += 2;
                    }
                }

                return score;


            }
        }

        private int NormalFrameBonus(int frameIndex)
        {
            return _rollsPinsHit[frameIndex] + _rollsPinsHit[frameIndex + 1];
        }

        private int SpareBonus(int frameIndex)
        {
            return _rollsPinsHit[frameIndex + 2];
        }

        private int StrikeBonus(int frameIndex)
        {
            return _rollsPinsHit[frameIndex + 1] + _rollsPinsHit[frameIndex + 2];
        }

        private bool IsStrike(int frameIndex)
        {
            return _rollsPinsHit[frameIndex] == 10;
        }
        private bool IsSpare(int frameIndex)
        {
            return _rollsPinsHit[frameIndex] + _rollsPinsHit[frameIndex + 1] == 10;
        }
    }
}
