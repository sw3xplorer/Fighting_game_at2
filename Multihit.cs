public class Multihit : Attack
{
    int hit;
    public override void Affect(Fighter attacker, Fighter target)
    {

        target.MultiAttacker = attacker;
        target.Hits = amount;
        target.MultiDamage = effect;

        for (int i = 0; i < amount; i++)
        {
            if (name == "Sephitorh" && attacker.hp < 105)
            {
                attackRoll = generator.Next(100);

                if ((attackRoll + 1) > 95)
                {
                    target.hp -= (effect + 20)*2;
                }
                else if ((attackRoll+1) > 30)
                {
                    target.hp -= effect+20;
                }
                else 
                {
                    target.hp -= 0;
                }
            }


            else 
            {
                attackRoll = generator.Next(100);
                if ((attackRoll+1) > 95)
                {
                    target.hp -= effect*2;
                }
                else if ((attackRoll+1) > 30 )
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
}
