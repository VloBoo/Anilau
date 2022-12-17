using UnityEngine;
public class Goblin : Enemy
{
    public Goblin(GameObject gameObject, int level, string name, int baseAttack, int baseHealth, int baseProtection, int basePower, float speed) : base(gameObject, level, name, baseAttack, baseHealth, baseProtection, basePower, speed)
    {
    }
    public override void PlayerNear(Vector3 direction)
    {
        if (direction.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (direction.magnitude > 0.3f)
        {
            direction.Normalize();
            gameObject.GetComponent<Rigidbody2D>().MovePosition(gameObject.transform.position + direction * Time.deltaTime * speed);

        }
        if (direction.magnitude < 0.5f)
        {
            if (cooldown != 0)
            {
                cooldown--;
            }
            else
            {
                Mediator.Player.TakeDamage(MakeDamage());
                cooldown = 40;
            }
        }
    }
}