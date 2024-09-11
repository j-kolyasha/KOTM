using Common.Entities.Behaviours;
using UnityEngine.Events;

namespace Common.Entities
{
    public class Health
    {
        public readonly UnityEvent Death = new UnityEvent();
        
        private int _maxHealth;

        private const int MIN_HEALTH = 0;

        public int CurrentHealth { get; private set; }

        public Health(DamageBehaviour damageble, HealsBehaviour heals)
        {
            damageble.ChangeHealth.AddListener(ChangeHealth);
            heals.ChangeHealth.AddListener(ChangeHealth);
        }

        private void ChangeHealth(int newHealth)
        {
            if (newHealth <= MIN_HEALTH)
            {
                CurrentHealth = MIN_HEALTH;
                Death.Invoke();
                return;
            }

            if (newHealth >= _maxHealth)
            {
                CurrentHealth = _maxHealth;
                return;   
            }
            
            CurrentHealth = newHealth;
        }
    }
}