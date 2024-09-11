using Common.Entities.Behaviours.Interfaces;
using UnityEngine.Events;

namespace Common.Entities.Behaviours
{
    public abstract class HealsBehaviour : IHealeable
    {
        public readonly UnityEvent<int> ChangeHealth = new UnityEvent<int>();
        
        public abstract void ApplyHealing(int currentHealth, int value);
    }
}