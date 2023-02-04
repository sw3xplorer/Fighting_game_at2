public class Multihit : Attack
{
    int hit;
    public override void Affect(Fighter attacker, Fighter target)
    {

        attacker.MultiAttacker = attacker;
        attacker.Hits = amount;
        attacker.MultiDamage = effect;

        if (!attacker.stun && !target.blockDmg)
        {
            for (int i = 0; i < amount; i++)
            {
                if (name == "Sephitorh" && attacker.hp < 105)
                {
                    attackRoll = generator.Next(100);

                    if ((attackRoll + 1) >= 95)
                    {
                        target.hp -= (effect + 20)*2;
                    }
                    else if ((attackRoll+1) >= 30)
                    {
                        target.hp -= effect+20;
                    }
                    else 
                    {
                        target.hp -= 0;
                    }
                }
                else if (name == "Cloud")
                {
                    attackRoll = generator.Next(100);

                    if ((attackRoll+1) >=95)
                    {
                        target.hp -= effect*2;
                    }
                    else if ((attackRoll+1 > 50))
                    {
                        target.hp -= effect;
                    }
                    else
                    {
                        target.hp -= 0;
                    }
                }

                else 
                {
                    attackRoll = generator.Next(100);
                    if ((attackRoll+1) >= 95)
                    {
                        target.hp -= effect*2;
                    }
                    else if ((attackRoll+1) >= 30 )
                    {
                        target.hp -= effect;
                    }
                    else
                    {
                        target.hp -= 0;
                    }
                }
            }
        }
        else 
        {
            target.blockDmg = false;
        }
    }
}
