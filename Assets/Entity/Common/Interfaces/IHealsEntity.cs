namespace Common.Entities.Interfaces
{
    public interface IHealsEntity : IEntity
    {
        public void ApplyHealing(int value);
    }
}