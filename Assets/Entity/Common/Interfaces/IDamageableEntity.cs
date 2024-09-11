namespace Common.Entities.Interfaces
{
    public interface IDamageableEntity : IEntity
    {
        public void ApplyDamage(int damage);
    }
}