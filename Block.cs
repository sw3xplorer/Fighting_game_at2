using System;

public class Block : Attack
{
    public override void Affect(Fighter attacker, Fighter target)
    {
        int succsess = generator.Next(101);
        if (succsess > 60)
        {
            blockDmg = true;
        }
        else
        {
            blockDmg = false;
        }
    }
}
