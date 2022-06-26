using System;


namespace SnakeProgram.Game.Casting
{
    /// <summary>
    /// <para>A tasty item that snakes like to eat.</para>
    /// <para>
    /// The responsibility of Food is to select a random position and points that it's worth.
    /// </para>
    /// </summary>
    public class Score : Actor
    {
        private int points = 0;
        public string player{
            get;
            private set;
        }

        /// <summary>
        /// Constructs a new instance of an Food.
        /// </summary>
        public Score(int x, string player) : base()
        {
            this.player = player;
            SetText($"Player {player}");
            this.SetPosition(new Point(x, 0));
            this.SetColor(player == "1" ? Constants.GREEN : Constants.RED);
        }

        public void setWinner(bool isWinner)
        {
           SetText($"Player {player} " + (isWinner?"won":"lost"));
        }
        

        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="points">The points to add.</param>
        public void AddPoints(int points)
        {
            this.points += points;
            SetText($"Player {player} Score: {this.points}");
        }
    }
}