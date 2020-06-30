using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dark_Labyrinth_Game
{
    [Serializable]
    public class Progress
    {
        public bool [] progress { get; set; }

        public Progress()
        {
            progress = new bool[7];
            progress[0] = true;
            for (int i = 1; i < 7; i++)
                progress[i] = false;
        }
    }
}
