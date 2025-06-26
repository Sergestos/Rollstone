namespace RollStone.Session.Data;

public class Round
{
    public Dictionary<int, PlayerRoundState> PlayerRoundState { get; private set; }

    public Round(Dictionary<int, Player> players)
    {
        PlayerRoundState = new Dictionary<int, PlayerRoundState>();

        foreach (var player in players)
        {
            PlayerRoundState[player.Key] = new PlayerRoundState(player.Value);
        }        
    }        

    public void PlayOut(int playerId, int cardId)
    {
        PlayerRoundState[playerId].PlayOut(cardId);
    }
}
