using System;
using Xunit;

namespace KataTddBowling
{
    public class GameTests
    {
        private Game game;

        public GameTests()
        {
            game = new Game();
        }

        [Fact]
        public void Gutter_Game()
        {
            Roll(0,0,  0,0,  0,0,  0,0,  0,0,  0,0,  0,0,  0,0,  0,0,  0,0);

            var score = game.GetScore();

            Assert.Equal(0, score);
        }

        [Fact]
        public void All_Ones()
        {
            Roll(1,1,  1,1,  1,1,  1,1,  1,1,  1,1,  1,1,  1,1,  1,1,  1,1);

            var score = game.GetScore();

            Assert.Equal(20, score);
        }


        [Fact]
        public void Single_Spare()
        {
            Roll(7,3,  1,0,  0,0,  0,0,  0,0,  0,0,  0,0,  0,0,  0,0,  0,0);

            var score = game.GetScore();

            Assert.Equal(12, score);
        }

        private void Roll(params int[] rolls)
        {
            foreach (var roll in rolls)
            {
                var pinsKnockedDown = roll;
                game.Roll(pinsKnockedDown);
            }
        }
    }
}
