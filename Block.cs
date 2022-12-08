using System;

public class Block : Attack
{
    public override void Affect(Fighter attacker, Fighter target)
    {
        if (!attacker.stun)
        {
            int succsess = generator.Next(101);
            if (succsess > 60)
            {
                attacker.blockDmg = true;
            }
            else
            {
                attacker.blockDmg = false;
            }
        }
    }
}
