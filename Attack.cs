
public class Attack
{
    public Random generator = new Random();
    public string name;
    public int effect;
    public int dotDuration;
    public int amount;
    public bool blockDmg;
    public int attackRoll;
    public int stunDuration;

    public virtual void Affect(Fighter attacker, Fighter target)
    {
        if (!attacker.stun)
        {
            if (target.name == "Tuba Knight" && target.blockDmg == true)
            {
                target.hp -= 0;
                target.blockDmg = false;    
            }

            if (attacker.name == "Sans")
            {
                attackRoll = generator.Next(100);
                if ((attackRoll + 1) > 85)
                {
                    target.hp -= effect*2;
                }   
                else if ((attackRoll+1) > 10)
                {
                    target.hp -= effect;
                }
                else
                {
                    target.hp -= 0;
                }
            }

            else if (attacker.name == "Sephitorh" && attacker.hp < 105)
            {
                attackRoll = generator.Next(100);

                if ((attackRoll + 1) > 95)
                {
                    target.hp -= (effect + 20)*2;
                }
                else if ((attackRoll+1) > 10)
                {
                    target.hp -= effect+20;
                }
                else 
                {
                    target.hp -= 0;
                }
            }

            else if (attacker.name == "Tuba Knight")
            {
                attackRoll = generator.Next(100);

                if ((attackRoll + 1) > (95-attacker.critBonus))
                {
                    target.hp -= effect*2;
                }
                else if ((attackRoll+1) > 10)
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

                if ((attackRoll + 1) > 95)
                {
                    target.hp -= effect*2;
                }
                else if ((attackRoll+1) > 10)
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
