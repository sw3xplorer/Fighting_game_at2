
public class DotAttack : Attack
{

    public override void Affect(Fighter attacker, Fighter target)
    {
        target.doDot = true;
        target.DotAttacker = attacker;
        target.dotTimesLeft = dotDuration;
        target.DotDamage = effect;
    }
}
