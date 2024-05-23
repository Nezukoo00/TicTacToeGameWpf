using System;


namespace TicTacToeGame
{
    public class GameState
    {
        public Player[,] GameGrid { get; private set; } 
        public Player CurrentPlayer { get; private set; }
        public int TurnsPassed { get; private set; }
        public bool GameOver { get; private set; }

        public event Action<int, int> MoveMade;
        public event Action<GameResult> GameEnded;
        public event Action GameRestarted;

        public GameState()
        {
            GameGrid = new Player[3, 3];
            CurrentPlayer = Player.X;
            TurnsPassed = 0;
            GameOver = false;


        }
        private bool CanMakeMove (int r, int c)
        {
            return !GameOver && GameGrid[r, c] == Player.None;


        }
        private bool IsGridFull ()
        {
            return TurnsPassed == 9;
        }
        private void SwitchPlayer ()
        {
            if (CurrentPlayer == Player.X)
            {
                CurrentPlayer == Player.O;
            }
            else
            {
                CurrentPlayer == Player.X;
            }
        }
        private bool AreSquaresMarked((int,int)[] squares, Player player)
        {
            foreach ()
        }
    }
}
