using System;

public class Block : Attack
{
    public override void Affect(Fighter attacker, Fighter target)
    {
        if (!attacker.stun)
        {
            int succsess = generator.Next(100);
            if (succsess + 1 >= 60)
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
