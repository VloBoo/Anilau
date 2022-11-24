using UnityEngine;

public class Player : Entity
{
    public Player(GameObject gameObject, int level, string name, int baseAttack, int baseHealth, int baseProtection, int basePower, float speed) : base(gameObject, level, name, baseAttack, baseHealth, baseProtection, basePower, speed)
    {

    }

    public override void Die()
    {
        Mediator.GameEnd();
    }

}