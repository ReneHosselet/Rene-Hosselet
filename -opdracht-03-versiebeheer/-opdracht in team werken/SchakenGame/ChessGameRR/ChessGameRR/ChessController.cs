using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameRR
{
    public class ChessController
    {
        Chess mChess = new Chess();
        Chessboard board;
        ScoreBord hetScorebord;
        public void GameStart (Chessboard T)
        {
            //nieuw bord starten en controller meegeven
            mChess.NieuwBord(T, this);
            board = T;
        }
        public void TileClick(BoardSquare B)
        {
            //tile meegeven
            mChess.TileActivate(B);
        }
        public void UpdateUi(bool turn)
        {
            //text omzetten naar persoons beurt
            if (turn)
            {
                board.UpdateTurn("WHITE TURN");
            }
            else
            {
                board.UpdateTurn("BLACK TURN");
            }
        }       
        public void UpdateScore(string doodStuk, ScoreBord scoreBordje)
        {
            hetScorebord = scoreBordje;
            hetScorebord.addScore(doodStuk); 
        }
    }
}
