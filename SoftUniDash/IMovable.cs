namespace SoftUniDash
{
    using SoftUniDash.CharacterClasses;

    public interface IMovable
    {
        int[] Move(Moving movingUnit, int unitX, int unitY);
    }
}
