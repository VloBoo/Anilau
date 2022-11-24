using UnityEngine;
public class Zombe : Enemy
{
    public Zombe(GameObject gameObject, int level, string name, int baseAttack, int baseHealth, int baseProtection, int basePower, float speed) : base(gameObject, level, name, baseAttack, baseHealth, baseProtection, basePower, speed)
    {
    }
    public override void PlayerNear(Vector3 direction)
    {
        base.PlayerNear(direction);
        if (direction.magnitude < 1)
        {
            //Mediator.Player.TakeDamage(10);
        }
    }
}