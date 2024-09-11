namespace Common.Entities.Behaviours
{
    public class RegularDamageBehaviour : DamageBehaviour
    {
        public override void ApplyDamage(int currentHeath, int damage)
        {
            if (damage <= 0)
                return;

            int newHealth = currentHeath - damage;
            ChangeHealth.Invoke(newHealth);
        }
    }
}