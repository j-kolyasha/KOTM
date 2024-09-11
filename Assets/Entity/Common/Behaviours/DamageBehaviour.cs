using Common.Entities.Behaviours.Interfaces;
using UnityEngine.Events;

namespace Common.Entities.Behaviours
{
    public abstract class DamageBehaviour : IDamageable
    {
        public readonly UnityEvent<int> ChangeHealth = new UnityEvent<int>();
        
        public abstract void ApplyDamage(int currentHealth, int damage);
    }
}