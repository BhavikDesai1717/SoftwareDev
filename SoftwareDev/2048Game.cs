using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDev
{
    public partial class _2048Game : Form
    {
        private Game oGame;

        private Graphics gGraphics, gG;
        private Bitmap bBackground;

        //private long lFPSTimer = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        //private int iNumOfFPS, nNumOfFPS;

        public _2048Game()
        {
            InitializeComponent();
            bBackground = new Bitmap(396, 600);

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            gGraphics = this.CreateGraphics();
            gG = Graphics.FromImage(bBackground);

            oGame = new Game();
            GameCFG.getInstance();
        }
        public void UpdateGame()
        {
            oGame.Update();
            /*CFG.getInstance().setTime(CFG.getInstance().getCurrentTime());

            if (CFG.getInstance().getTime() - 1000 >= lFPSTimer)
            {
                lFPSTimer = CFG.getInstance().getCurrentTime();
                iNumOfFPS = nNumOfFPS;
                nNumOfFPS = 0;
            }
            else
            {
                ++nNumOfFPS;
            }*/
        }
        public void Draw(Graphics g)
        {
            g.Clear(Color.FromArgb(251, 248, 239));

            oGame.Draw(g);
        }

        private void _2048Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                LoginPage mainWindow = new LoginPage();
                mainWindow.Show();
                this.Hide();
            }
            if (!oGame.kTOP && !oGame.kRIGHT && !oGame.kBOTTOM && (e.KeyCode == Keys.A || e.KeyCode == Keys.Left))
            {
                oGame.kLEFT = true;
                oGame.moveBoard(Game.Direction.eLEFT);
            }
            else if (!oGame.kLEFT && !oGame.kRIGHT && !oGame.kBOTTOM && (e.KeyCode == Keys.W || e.KeyCode == Keys.Up))
            {
                oGame.kTOP = true;
                oGame.moveBoard(Game.Direction.eTOP);
            }
            else if (!oGame.kTOP && !oGame.kLEFT && !oGame.kBOTTOM && (e.KeyCode == Keys.D || e.KeyCode == Keys.Right))
            {
                oGame.kRIGHT = true;
                oGame.moveBoard(Game.Direction.eRIGHT);
            }
            else if (!oGame.kTOP && !oGame.kRIGHT && !oGame.kLEFT && (e.KeyCode == Keys.S || e.KeyCode == Keys.Down))
            {
                oGame.kBOTTOM = true;
                oGame.moveBoard(Game.Direction.eBOTTOM);
            }
        }

        private void _2048Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (oGame.kLEFT && (e.KeyCode == Keys.A || e.KeyCode == Keys.Left))
            {
                oGame.kLEFT = false;
            }

            if (oGame.kTOP && (e.KeyCode == Keys.W || e.KeyCode == Keys.Up))
            {
                oGame.kTOP = false;
            }

            if (oGame.kRIGHT && (e.KeyCode == Keys.D || e.KeyCode == Keys.Right))
            {
                oGame.kRIGHT = false;
            }

            if (oGame.kBOTTOM && (e.KeyCode == Keys.S || e.KeyCode == Keys.Down))
            {
                oGame.kBOTTOM = false;
            }
        }

        private void _2048Game_MouseClick(object sender, MouseEventArgs e)
        {
            oGame.checkButton(e.X, e.Y);
        }

        private void _2048Game_Load(object sender, EventArgs e)
        {

        }

        private void _2048Game_Load_1(object sender, EventArgs e)
        {

        }

        /* ******************************************** */

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateGame();
            if (oGame.bRender)
            {
                Draw(gG);

                gGraphics.DrawImage(bBackground, new Point(0, 0));
            }
        }

    }
}
