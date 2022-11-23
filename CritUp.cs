using System;

public class CritUp : Attack
{
    public override void Affect(Fighter attacker, Fighter target)
    {
        attacker.critBonus += effect;
    }
}
