namespace RollStone.Session.Data;

public class PlayerCard
{
    // original card instance 

    public int AssignedId { get; set; } = new Random().Next(10000);

    public int CurrentDamage { get; set; }

    public int CurrentHealth { get; set; }

    public int FieldType { get; set; }

    public string __Name { get; set; }
}
