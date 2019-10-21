using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingExample.Models
{
    /// <summary>
    /// SimpleGame tracks four optional gamescores from 0 - 300 and a total score
    /// </summary>
    public class SimpleGame
    {
        private int? _game1;
        private int? _game2;
        private int? _game3;
        private int? _game4;

        public void Test()
        {

        }

        //private void ValidateGameScore(int? value, out int game)
        //{
        //    if (!value.HasValue || value < 0 || value > 300)
        //    {
        //        throw new ArgumentOutOfRangeException("Game scores must be between 0 and 300 inclusive");
        //    }
        //    game = value.Value;
        //}

        public int? Game1
        {
            get
            {
                return _game1;
            }
            set
            {
                if (value < 0 || value > 300)
                {
                    throw new ArgumentOutOfRangeException("Game scores must be between 0 and 300 inclusive");
                }
                _game1 = value;
            }
        }

        public int? Game2
        {
            get
            {
                return _game2;
            }
            set
            {
                if (value < 0 || value > 300)
                {
                    throw new ArgumentOutOfRangeException("Game scores must be between 0 and 300 inclusive");
                }
                _game2 = value;
            }
        }

        public int? Game3
        {
            get
            {
                return _game3;
            }
            set
            {
                if (value < 0 || value > 300)
                {
                    throw new ArgumentOutOfRangeException("Game scores must be between 0 and 300 inclusive");
                }
                _game3 = value;
            }
        }

        public int? Game4
        {
            get
            {
                return _game4;
            }
            set
            {
                if (value < 0 || value > 300)
                {
                    throw new ArgumentOutOfRangeException("Game scores must be between 0 and 300 inclusive");
                }
                _game4 = value;
            }
        }

        public int TotalScore
        {
            get { return Game1.GetValueOrDefault() + Game2.GetValueOrDefault() + Game3.GetValueOrDefault() + Game4.GetValueOrDefault(); }
        }



    }
}
