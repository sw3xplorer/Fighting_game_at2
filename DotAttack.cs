
public class DotAttack : Attack
{

    public override void Affect(Fighter attacker, Fighter target)
    {
        attacker.DotAttacker = attacker;
        attacker.dotTimesLeft = dotDuration;
        attacker.dotDamage = effect;
        if (!attacker.stun)
        {
            if (name == "Bowser")
            {
                attackRoll = generator.Next(100);
                if ((attackRoll+1) > 70)
                {
                    target.hp -= 10;
                    target.doDot = true;
                }
                else
                {
                    target.doDot = false;
                }
            }

            else if (name == "Sephitorh" && attacker.hp < 105)
            {
                attacker.dotDamage = effect + 20;
                attackRoll = generator.Next(100);
                if ((attackRoll+1) > 70)
                {
                    target.doDot = true;
                }
                else 
                {
                    target.doDot = false;
                }
            }
            else 
            {
                attackRoll = generator.Next(100);
                if ((attackRoll+1) > 70)
                {
                    target.doDot = true;
                }
                else
                {
                    target.doDot = false;
                }
            }
        }


    }
}
