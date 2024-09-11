namespace Common.Entities.Behaviours.Interfaces
{
    public interface IHealeable
    {
        public void ApplyHealing(int currentHealth, int value);
    }
}