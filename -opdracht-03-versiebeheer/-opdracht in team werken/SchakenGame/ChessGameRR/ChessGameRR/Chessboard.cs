using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGameRR
{
    public partial class Chessboard : Form
    {
        ChessController controller = new ChessController();
        public Chessboard()
        {
            InitializeComponent();
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            //star spel en deactiveert knop
            controller.GameStart(this);
            btnStartGame.Enabled = false;
            lblTurn.Visible = true;
            Validate();
        }
        private void Chessboard_Load(object sender, EventArgs e)
        {
        }
        private void lblTurn_Click(object sender, EventArgs e)
        {
        }
        //geeft in label aan wie aan de beurt is
        public void UpdateTurn(string turn)
        {
            lblTurn.Text = turn;
        }
    }
}
