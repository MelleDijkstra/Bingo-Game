using System;
using System.Windows.Forms;

namespace Bingol_Jingol
{
    public partial class GameScreenDrawn : Form
    {

        GameManager bingoGame;

        public GameScreenDrawn()
        {
            InitializeComponent();

            // bingoGame = new GameManager(); -- OLD

        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            // draw the bingoGame
            // bingoGame.DrawCards(e.Graphics); -- DELETED
            Console.WriteLine("Screen painted");
        }
    }
}
