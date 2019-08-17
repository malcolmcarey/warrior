using System;
namespace warrior
{
    public class Warrior
    {
		public string name { get; set; } = "No Name";
		public int Health { get; set; } = 0;
		public int maxAttack { get; set; } = 0;
		public int maxBlock { get; set; } = 0;

		private Random rand = new Random();

		public Warrior()
			: this("No Name", 0, 0, 0) { }

		public Warrior(string name = "No Name")
			: this(name, 0, 0, 0) { }

        public Warrior(string name = "No Name",
            int h = 0,
            int a = 0,
            int b = 0)
		{
			this.name = name;
			Health = h;
			maxAttack = a;
			maxBlock = b;
		}

        public int Attack()
		{
			return rand.Next(1, maxAttack);
		}

        public int Block()
		{
			return rand.Next(1, maxBlock);
		}
	}
}
