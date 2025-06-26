namespace RollStone.Session.Data;

public class PlayerRoundState
{
    private Player _player;

    public int PlayerScore { get; set; }

    public PlayerDeck PlayerDeck { get; set; }

    public PlayerRoundState(Player player)
    {
        _player = player;

        PlayerDeck = new PlayerDeck();
        PlayerScore = 0;
    }

    public void PlayOut(int cardId)
    {
        var playerHandCards = _player.HandCards;
        var targetCard = playerHandCards.Single(x => x.AssignedId == cardId);

        PlayerDeck.PlayOut(targetCard);
        PlayerScore = PlayerDeck.GetFullScore();
    }
}
