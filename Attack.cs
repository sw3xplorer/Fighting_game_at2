
public class Attack
{
    public string name;
    public int effect;
    public int dotDuration;
    public int amount;
    public bool blockDmg;

    public virtual void Affect(Fighter attacker, Fighter target)
    {
        target.hp -= effect;
    }
}
