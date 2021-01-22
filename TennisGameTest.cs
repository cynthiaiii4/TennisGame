using System;
using NUnit.Framework;
using static Tests.Tests;

namespace Tests
{
    public class TennisTest
    {
        

        [SetUp]
        public void Setup()
        {
            _tennisGame = new TennisGame();
        }

        private TennisGame _tennisGame;

        private void ScoreShouldBe(string expected) {
            Assert.AreEqual(expected, _tennisGame.Score());
        }
        [Test]
        public void when_game_start_should_be_love_all()
        {
            GivenPlayerScore(0, 0);
            ScoreShouldBe("Love All");
        }

        [Test]
        public void Fiffteen_love()
        {
            GivenPlayerScore(1,0);
            ScoreShouldBe("Fiffteen Love");
        }

        [Test]
        public void Thirty_love()
        {
            GivenPlayerScore(2,0);
            ScoreShouldBe("Thirty Love");
        }

        [Test]
        public void Fourty_love()
        {
            GivenPlayerScore(3, 0);
            ScoreShouldBe("Fourty Love");
        }

        [Test]
        public void Player1Win_4vs0()
        {
            GivenPlayerScore(4, 0);
            ScoreShouldBe("Summer Win");
        }
        [Test]
        public void Love_Fiffteen()
        {
            GivenPlayerScore(0, 1);
            ScoreShouldBe("Love Fiffteen");
        }
        [Test]
        public void Fiffteen_All()
        {
            GivenPlayerScore(1, 1);
            ScoreShouldBe("Fiffteen All");
        }
        [Test]
        public void Thirty_Fiffteen()
        {
            GivenPlayerScore(2, 1); 
            ScoreShouldBe("Thirty Fiffteen");
        }

        [Test]
        public void Fourty_Fiffteen()
        {
            GivenPlayerScore(3, 1);
            ScoreShouldBe("Fourty Fiffteen");
        }

        [Test]
        public void Love_Thirty()
        {
            GivenPlayerScore(0, 2);
            ScoreShouldBe("Love Thirty");
        }
        [Test]
        public void Fiffteen_Thirty()
        {
            GivenPlayerScore(1, 2);
            ScoreShouldBe("Fiffteen Thirty");
        }

        [Test]
        public void Thirty_All()
        {
            GivenPlayerScore(2, 2);
            ScoreShouldBe("Thirty All");
        }

        [Test]
        public void Fourty_Thirty()
        {
            GivenPlayerScore(3, 2);
            ScoreShouldBe("Fourty Thirty");
        }

        [Test]
        public void Love_Fourty()
        {
            GivenPlayerScore(0, 3);
            ScoreShouldBe("Love Fourty");
        }

        [Test]
        public void Fiffteen_Fourty()
        {
            GivenPlayerScore(1, 3);
            ScoreShouldBe("Fiffteen Fourty");
        }
        [Test]
        public void Thirty_Fourty()
        {
            GivenPlayerScore(2, 3);
            ScoreShouldBe("Thirty Fourty");
        }

        [Test]
        public void Deuce3vs3()
        {
            GivenPlayerScore(3, 3);
            ScoreShouldBe("Deuce");
        }
        [Test]
        public void Deuce4vs4()
        {
            GivenPlayerScore(4, 4);
            ScoreShouldBe("Deuce");
        }

        [Test]
        public void Deuce5vs5()
        {
            GivenPlayerScore(5, 5);
            ScoreShouldBe("Deuce");
        }

        [Test]
        public void Player1_Adv_4vs3()
        {
            GivenPlayerScore(4, 3);
            ScoreShouldBe("Summer Adv");
        }

        [Test]
        public void Player1_Adv_5vs4()
        {
            GivenPlayerScore(5, 4);
            ScoreShouldBe("Summer Adv");
        }

        [Test]
        public void Player1Win_morethan4()
        {
            GivenPlayerScore(5, 3);
            ScoreShouldBe("Summer Win");
        }

        [Test]
        public void Player2_Adv_3vs4()
        {
            GivenPlayerScore(3, 4);
            ScoreShouldBe("CC Adv");
        }

        [Test]
        public void Player2_Adv_4vs5()
        {
            GivenPlayerScore(4, 5);
            ScoreShouldBe("CC Adv");
        }

        [Test]
        public void Player2Win_morethan4()
        {
            GivenPlayerScore(3, 5);
            ScoreShouldBe("CC Win");
        }

        private void GivenPlayerScore(int player1, int player2) {
            for (int i = 0; i < player1; i++) {
                _tennisGame.FirstPlayerScore();
            }
            for (int j = 0; j < player2; j++)
            {
                _tennisGame.SecondPlayerScore();
            }
        }
    }


}