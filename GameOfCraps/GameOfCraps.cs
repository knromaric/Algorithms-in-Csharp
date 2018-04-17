using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfCraps
{
    class GameOfCraps
    {
        static void Main(string[] args)
        {
            CrapsGame crapGame = new CrapsGame();
            crapGame.Play();
        }
    }
}
