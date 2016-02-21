using System.Windows.Forms;

namespace Bingol_Jingol
{
    public partial class GameScreenWithControls : Form
    {
        GameManager bingoGame;

        public GameScreenWithControls()
        {
            InitializeComponent();
            bingoGame = new GameManager(this);
        }

        private void nextBtn_Click(object sender, System.EventArgs e)
        {
            bingoGame.nextTurn();
        }
    }
}
