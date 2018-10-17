using System;

namespace KataTddBowling
{
    public class Game
    {
        private int totalScore;

        public void Roll(int numberOfPins)
        {
            totalScore += numberOfPins;
        }

        public int GetScore()
        {
            return totalScore;
        }
    }
}