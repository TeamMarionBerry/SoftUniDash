namespace SoftUniDash.CharacterClasses
{
    public class Warrior : Character
    {
        public Warrior(string name, string classType, int x, int y,
                int health, int currentHealth, int damage, int height, int width, int range)
            : base(name, classType, x, y, health, currentHealth, damage, height, width, range)
        {
        }
    }
}
