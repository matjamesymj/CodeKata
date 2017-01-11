using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.TennisKata
{
    public class TennisGame
    {

        public string Player1 { get; set; }
        public string Player2 { get; set; }

        public int Player1Score { get; set; }
        public int Player2Score { get; set; }

        public string Score()
        {
            var score = "";
            if (IsGameDraw())
            {
                score = GetDrawScore(score);

            }
            else
            {
                if (BothPlayersScoredMoreThan3())
                {
                    if (Player1Won())
                    {
                        score = string.Format("{0} - Won", Player1);
                    }
                    if (Player2Won())
                    {
                        score = string.Format("{0} - Won", Player2);
                    }
                    if (IsPlayer1Leading())
                    {
                        score = string.Format("Advantage - {0}", Player1);

                    }
                    if (IsPlayer2Leading())
                    {
                        score = string.Format("Advantage - {0}", Player2);
                    }
                }
                else
                {
                    score = GetNonAdvantageNotDrawScore(score);
                }


            }



            return score;
        }

        private string GetNonAdvantageNotDrawScore(string score)
        {
            var player1ScoreString = GetScoreBoardStringForPlayer(Player1Score);
            var player2ScoreString = GetScoreBoardStringForPlayer(Player2Score);
            score = string.Format("{0}-{1}", player1ScoreString, player2ScoreString);
            return score;
        }

        private bool IsPlayer2Leading()
        {
            return Player2Score - Player1Score == 1;
        }

        private bool IsPlayer1Leading()
        {
            return Player1Score - Player2Score == 1;
        }

        private bool BothPlayersScoredMoreThan3()
        {
            return Player1Score > 3 || Player2Score > 3;
        }

        private bool Player1Won()
        {
            return (Player1Score > 3 || Player2Score > 3) & Player1Score - Player2Score >= 2;
        }
        private bool Player2Won()
        {
            return (Player1Score > 3 || Player2Score > 3) & Player2Score - Player1Score >= 2;
        }

        private bool IsGameDraw()
        {
            return Player1Score == Player2Score;
        }

        private string GetDrawScore(string score)
        {
            switch (Player1Score)
            {
                case 0:
                    score = "Love-All";
                    break;
                case 1:
                    score = "Fifteen-All";
                    break;

                case 2:
                    score = "Thirty-All";
                    break;
                case 3:
                    score = "Deuce";
                    break;
                default:
                    score = "Love-All";
                    break;
            }
            return score;
        }

        private string GetScoreBoardStringForPlayer(int scoreAsInt)
        {
            string returnScoreString;
            switch (scoreAsInt)
            {
                case 0:
                    returnScoreString = "Love";
                    break;
                case 1:
                    returnScoreString = "Fifteen";
                    break;

                case 2:
                    returnScoreString = "Thirty";
                    break;
                case 3:
                    returnScoreString = "Fourty";
                    break;
                default:
                    returnScoreString = "Love";
                    break;
            }
            return returnScoreString;
        }

        public TennisGame(string player1, string player2)
        {
            Player1 = player1;
            Player2 = player2;
        }


        public void PointScored(string PlayerName)
        {
            if (PlayerName == "James")
            {
                Player1Score += 1;
            }
            if (PlayerName == "Edwards")
            {
                Player2Score += 1;
            }
        }


    }
}
