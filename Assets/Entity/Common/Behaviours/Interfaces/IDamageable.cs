namespace Common.Entities.Behaviours.Interfaces
{
    public interface IDamageable
    {
        public void ApplyDamage(int currentHealth, int damage);
    }
}