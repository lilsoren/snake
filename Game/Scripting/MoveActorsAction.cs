using System.Collections.Generic;
using Unit05.Game.Casting;
using Unit05.Game.Services;



namespace Unit05.Game.Scripting
{


     /// <summary>
    /// <para>An update action that moves all the actors.</para>
    /// <para>
    /// The responsibility of MoveActorsAction is to move all the actors.
    /// </para>
    /// </summary>

    // TODO: Implement the MoveActorsAction class here

    // 1) Add the class declaration. Use the following class comment. Make sure you
    //    inherit from the Action class.
    public class MoveActorsAction : Action
    {
        /// <summary>
        /// Constructs a new instance of MoveActorsAction.
        /// </summary>
        public MoveActorsAction()
        {

        }

        public void Execute(Cast cast, Script script)
        {
            foreach (Actor a in cast.GetAllActors())
            {
                a.MoveNext();
            }
        }

    }

    /// <summary>
    /// <para>An update action that moves all the actors.</para>
    /// <para>
    /// The responsibility of MoveActorsAction is to move all the actors.
    /// </para>
    /// </summary>

    // 2) Create the class constructor. Use the following method comment.

    

    // 3) Override the Execute(Cast cast, Script script) method. Use the following 
    //    method comment. You custom implementation should do the following:
    //    a) get all the actors from the cast
    //    b) loop through all the actors
    //    c) call the MoveNext() method on each actor.

}