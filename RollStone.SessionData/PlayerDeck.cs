namespace RollStone.Session.Data;

public class PlayerDeck
{
    public IList<PlayerCard> MeleeCards { get; } = new List<PlayerCard>();

    public IList<PlayerCard> RangeCards { get; } = new List<PlayerCard>();

    public void PlayOut(PlayerCard card, int fieldType)
    {
        if (fieldType == 0)
            MeleeCards.Add(card);
        else if (fieldType == 1)
            RangeCards.Add(card);
    }

    public void PlayOut(PlayerCard card)
    {
        PlayOut(card, card.FieldType);
    }

    public int GetFullScore()
    {
        int result = 0;

        foreach (var item in MeleeCards)        
            result += item.CurrentDamage;

        foreach (var item in RangeCards)
            result += item.CurrentDamage;

        return result;
    }
}
