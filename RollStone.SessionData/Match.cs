namespace RollStone.Session.Data;

public class Match
{
    public Dictionary<int, Player> Players { get; }

    public Round? CurrentRound { get; private set; }

    private Stack<Round> _rounds;

    public Match(Player firstPlayer, Player secondPlayer)
    {
        Players = new Dictionary<int, Player>()
        {
            [firstPlayer.ClientId] = firstPlayer,
            [secondPlayer.ClientId] = secondPlayer
        };

        _rounds = new Stack<Round>();
    }

    public void SetupNextRound()
    {
        _rounds.Push(new Round(Players));

        CurrentRound = _rounds.Peek();
    }
}
