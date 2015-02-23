namespace SoftUniDash.CharacterClasses
{
    public class Character : Unit, IMovable
    {
        public Character(string name, string classType, int x, int y, int health, int currentHealth, int damage, int height, int width, int range)
            : base(x, y, health, currentHealth, damage, height, width, range)
        {
            this.Name = name;
            this.ClassType = classType;
        }

        public string ClassType { get; set; }

        public string Name { get; set; }

        public int[] Move(Moving movingUnit, int unitX, int unitY)
        {
            int velocity = 20;
            int[] coordinates = new int[2];
            if (movingUnit == Moving.Left)
            {
                unitX  = (unitX -= velocity);
            }

            else if (movingUnit == Moving.Right)
            {
                unitX = (unitX += velocity);
            }

            else if (movingUnit == Moving.Up)
            {
                unitY = (unitY -= velocity);
            }

            else if (movingUnit == Moving.Down)
            {
                unitY = (unitY += velocity);
            }

            else if (movingUnit == Moving.None)
            {
                velocity--;
            }

            if (velocity < 6)
            {
                velocity++;
            }

            coordinates[0] = unitX;
            coordinates[1] = unitY;

            return coordinates;
        }
    }
}
