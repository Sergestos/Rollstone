using RollStone.Session.Data;

namespace RollStone.SessionState;

public class MatchState
{
    public static Match Match { get; set; }

    static MatchState()
    {
        IList<PlayerCard> cards1 = new List<PlayerCard>()
        {
            new PlayerCard()
            {
                CurrentDamage = 2,
                CurrentHealth = 2,
                FieldType = 0,
                __Name = "Fighter"
            },
            new PlayerCard()
            {
                CurrentDamage = 3,
                CurrentHealth = 1,
                FieldType = 1,
                __Name = "Mage"
            }
        };

        IList<PlayerCard> cards2 = new List<PlayerCard>()
        {
            new PlayerCard()
            {
                CurrentDamage = 2,
                CurrentHealth = 2,
                FieldType = 0,
                __Name = "Fighter"
            },
            new PlayerCard()
            {
                CurrentDamage = 3,
                CurrentHealth = 1,
                FieldType = 1,
                __Name = "Mage"
            }
        };

        Match = new Match(new Player(1, cards1), new Player(2, cards2));
    }

    public static Match GetMatch()
    {
        return Match;
    }

    //public static void Play(int playerId, )
}
