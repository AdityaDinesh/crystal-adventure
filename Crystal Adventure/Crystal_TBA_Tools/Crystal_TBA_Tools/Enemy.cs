using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crystal_TBA_Tools
{
    public class Enemy
    {
        public string name;

        public int health = 0;
        public int damage = 0;

        public Enemy(int h, int d, string n)
        {
            name = n;
            health = h;
            damage = d;
        }
    }
}
