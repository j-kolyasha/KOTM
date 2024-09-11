using Common.Entities.Behaviours.Interfaces;

namespace Common.Entities.Behaviours
{
    public class IgnoreDamageBehaviour : DamageBehaviour
    {
        public override void ApplyDamage(int currentHealth, int damage)
        {
            return;
        }
    }
}