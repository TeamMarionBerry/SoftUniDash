namespace SoftUniDash.CharacterClasses
{
    public abstract class Unit
    {
        private int x;
        private int y;

        public Unit(int x, int y, int health, int currentHealth, int damage, int height, int width, int range)
        {
            this.X = x;
            this.Y = y;
            this.Health = health;
            this.CurrentHealth = currentHealth;
            this.Damage = damage;
            this.Height = height;
            this.Width = width;
            this.Range = range;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Health { get; set; }
        public int CurrentHealth { get; set; }
        public int Damage { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Range { get; set; }
    }
}