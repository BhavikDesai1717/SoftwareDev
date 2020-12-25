using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SoftwareDev
{
    class GameButton
    {
        private int iXPos, iYPos;
        private int iWidth, iHeight;
        private int imgID;

        private Boolean clickable;

        public GameButton(int iXPos, int iYPos, int iWidth, int iHeight, int imgID, Boolean clickable)
        {
            this.iXPos = iXPos;
            this.iYPos = iYPos;
            this.iWidth = iWidth;
            this.iHeight = iHeight;
            this.imgID = imgID;
            this.clickable = clickable;
        }

        /* ******************************************** */

        public void Draw(Graphics g, Bitmap oB)
        {
            g.DrawImage(oB, new Point(iXPos, iYPos));
        }

        /* ******************************************** */

        public int getXpos()
        {
            return iXPos;
        }

        public int getYPos()
        {
            return iYPos;
        }

        public int getWidth()
        {
            return iWidth;
        }

        public int getHeight()
        {
            return iHeight;
        }

        public int getIMGID()
        {
            return imgID;
        }

        public Boolean getClickable()
        {
            return clickable;
        }
    }
}
