using Common.Entities.Behaviours.Interfaces;
using Common.Entities.Interfaces;

namespace Units.Interfaces
{
    public interface IAttackableEntity : IEntity
    {
        public void Attack(IDamageable damageable);
    }
}