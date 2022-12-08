public class CritUp : Attack
{
    public override void Affect(Fighter attacker, Fighter target)
    {
        if (!attacker.stun)
        {
            attacker.critBonus += effect;
        }
    }
}
