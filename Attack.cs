
public class Attack
{
    public string name;
    public int effect;
    public int dotDuration;
    public int amount;
    public bool blockDmg;

    public virtual void Affect(Fighter attacker, Fighter target)
    {
        if (name == "Sephitorh" && attacker.hp < 105)
        {
            target.hp -= effect+20;
        }
        else
        {
            target.hp -= effect;
        }
    }
}
