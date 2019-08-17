using System;
namespace warrior
{
    public class Battle
    {
        public Battle()
		{

		}

        public static void StartFight(Warrior a, Warrior b)
		{
			Console.WriteLine("Commence fight...");

            while(a.Health > 0 && b.Health > 0)
			{
				int a_attack = getAttackResult(a, b);
				b.Health -= a_attack;
				Console.WriteLine("{0} has {1} health.", b.name, b.Health);
                

                //check if the fight is over
                if (b.Health <= 0)
				{
					break;
				}

				int b_attack = getAttackResult(b, a);
				a.Health -= b_attack;
				Console.WriteLine("{0} has {1} health.", a.name, a.Health);
			}

            if(a.Health <= 0)
			{
				Console.WriteLine("{0} has died and {1} is victorious!", a.name, b.name);
			}
			else
			{
				Console.WriteLine("{0} has died and {1} is victorious!", b.name, a.name);
			}
		}

        public static int getAttackResult(Warrior attacker, Warrior defender)
		{
			//A fights B
			int a_attack = attacker.Attack();
			int b_block = defender.Block();

			if (a_attack - b_block > 0)
			{
				//deal damage to b
				Console.WriteLine("{0} attacks {1} and deals {2} damage.", attacker.name, defender.name, a_attack - b_block);

				return (a_attack - b_block);
			}
			else
			{
				Console.WriteLine("{0} blocked {1}'s attack!", defender.name, attacker.name);
			}

			//else
			return 0;
		}
    }
}
