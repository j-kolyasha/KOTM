using Common.Entities.Behaviours.Interfaces;

namespace Common.Entities.Behaviours
{
    public class IgnoreHealsBehaviour : HealsBehaviour
    {
        public override void ApplyHealing(int currentHealth, int value)
        {
            return;
        }
    }
}