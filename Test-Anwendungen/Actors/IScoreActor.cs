namespace Actors
{
    class IScoreActor : IActor
    {
        Task<int> IncrementScoreAsync();
        Task<int> GetScoreAsync();
    }
}