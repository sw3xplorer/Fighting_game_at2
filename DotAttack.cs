
public class DotAttack : Attack
{

    public override void Affect(Fighter attacker, Fighter target)
    {
        target.DotAttacker = attacker;
        target.dotTimesLeft = dotDuration;
        target.DotDamage = effect;

        if (name == "Bowser")
        {
            attackRoll = generator.Next(100);
            if ((attackRoll+1) > 30)
            {
                target.hp -= 10;
                target.doDot = true;
            }
            else
            {
                target.doDot = false;
            }
        }


        attackRoll = generator.Next(100);
        if ((attackRoll+1) > 30)
        {
            target.doDot = true;
        }
        else
        {
            target.doDot = false;
        }


    }
}
