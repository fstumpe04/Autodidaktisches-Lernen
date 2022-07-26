using Dapr.Actors;

namespace Actors
{
    class ScoreActor : Actor, IScoreActor
    {
        public ScoreActor(ActorHost host) : base (host)
        {
            
        }
    }
}