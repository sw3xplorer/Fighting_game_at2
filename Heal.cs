public class Heal : Attack
{
    public override void Affect(Fighter attacker, Fighter target)
    {
        if (!attacker.stun)
        {
            if ((attacker.hp+effect) > attacker.maxHp)
            {
                attacker.hp += (attacker.maxHp-attacker.hp);
            }
            else 
            {
                attacker.hp += effect;
            }
        }
    }
}
