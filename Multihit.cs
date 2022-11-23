

public class Multihit : Attack
{
    public override void Affect(Fighter attacker, Fighter target)
    {
        target.MultiAttacker = attacker;
        target.Hits = amount;
        target.MultiDamage = effect;
    }
}
