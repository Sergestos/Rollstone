namespace RollStone.Session.Data;

public class Player
{
    public int ClientId { get; }

    public IList<PlayerCard> InitialCards { get; }

    public IList<PlayerCard> HandCards { get; set; }

    public IList<PlayerCard> ReleaseCards { get; set; }

    public Player(int clientId, IList<PlayerCard> initialCards)
    {
        ClientId = clientId;
        InitialCards = initialCards;

        HandCards = InitialCards;

        ReleaseCards = new List<PlayerCard>();
    }
}
