using System.Collections.Generic;
using SnakeProgram.Game.Casting;
using SnakeProgram.Game.Services;


namespace SnakeProgram.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Action
    {
        private VideoService videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            Snake player1 = (Player1)cast.GetFirstActor("player1");
            List<Actor> segments1 = player1.GetSegments();
            Snake player2 = (Player2)cast.GetFirstActor("player2");
            List<Actor> segments2 = player2.GetSegments();
            List<Actor> messages = cast.GetActors("messages");
            List<Actor> scores = cast.GetActors("score");

            
            videoService.ClearBuffer();
            videoService.DrawActors(segments1);
            videoService.DrawActors(segments2);
            videoService.DrawActors(messages);
            videoService.DrawActors(scores);
            videoService.FlushBuffer();
            
        }
    }
}