using System;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        public class TennisGame
        {
            private int _firstPlayerScore;
            private int _secondPlayerScore;
            private string player1 = "Summer";
            private string player2 = "CC";

            public string Score()
            {

                var scoreDic = new Dictionary<int, string>
                {
                    { 0,"Love"},
                    { 1,"Fiffteen"},
                    { 2,"Thirty"},
                    { 3,"Fourty"}
                };

                if ((this._firstPlayerScore >= 3 || this._secondPlayerScore >= 3) && (this._firstPlayerScore == this._secondPlayerScore)) { return "Deuce"; }

                if (this._firstPlayerScore >= 4 || this._secondPlayerScore >= 4)
                {

                    if (Math.Abs(this._firstPlayerScore - this._secondPlayerScore) >= 2)
                    {
                        var winner = this._firstPlayerScore > this._secondPlayerScore ? player1 : player2;

                        return $"{winner} Win";
                    }
                    else
                    {
                        var adver = this._firstPlayerScore > this._secondPlayerScore ? player1 : player2;
                        return $"{adver} Adv";
                    }
                }
                else
                {
                    if (this._firstPlayerScore == this._secondPlayerScore)
                    {
                        return $"{scoreDic[_firstPlayerScore]} All";
                    }
                    else
                    {
                        return $"{scoreDic[_firstPlayerScore]} {scoreDic[_secondPlayerScore]}";
                    }
                }
            }

            public void FirstPlayerScore()
            {
                this._firstPlayerScore++;
            }

            public void SecondPlayerScore()
            {
                this._secondPlayerScore++;
            }
        }

    }
}