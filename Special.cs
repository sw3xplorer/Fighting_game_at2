public class Special :Attack
{
    public override void Affect(Fighter attacker, Fighter target)
    {
        attackRoll = generator.Next(100);

        if ((attackRoll + 1 ) == 100)
        {
            target.hp -= effect*2;
        }

        else if ((attackRoll + 1) > 95)
        {
            target.hp -= effect;
        }

        else 
        {
            target.hp -= 0;
        }
    }
}
