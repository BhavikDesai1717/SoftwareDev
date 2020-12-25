using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDev
{
    class GameCFG
    {
        private static GameCFG oCFG;

        private GameCFG() { }

        public static GameCFG getInstance()
        {
            if (oCFG == null)
            {
                oCFG = new GameCFG();
            }

            return oCFG;
        }

        /* ******************************************** */

        private const int iWidth = 396, iHeight = 640;

        private static long lTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

        /* ******************************************** */

        public int getWidth()
        {
            return iWidth;
        }

        public int getHeight()
        {
            return iHeight;
        }

        public long getCurrentTime()
        {
            return DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        }

        public long getTime()
        {
            return lTime;
        }

        public void setTime(long lTime)
        {
            GameCFG.lTime = lTime;
        }
    }
}
