public class Heal : Attack
{
    public override void Affect(Fighter attacker, Fighter target)
    {
        attacker.hp += effect;
    }
}
