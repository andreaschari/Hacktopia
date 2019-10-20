using System;
using System.Collections.Generic;
using System.Text;

namespace Hacktopia
{
    class Player
    {
        public string name;
        public int health;
        public int sanity;
        public int score;

        public int Health { get; set; } = 100;
        public string Name { get; set; }
        public int Sanity { get; set; } = 100;
        public int Score { get; set; } = 0;

    }
}
