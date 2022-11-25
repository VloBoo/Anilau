using UnityEngine;
public class Enemy : Entity
{
    public Enemy(GameObject gameObject, int level, string name, int baseAttack, int baseHealth, int baseProtection, int basePower, float speed) : base(gameObject, level, name, baseAttack, baseHealth, baseProtection, basePower, speed)
    {
    }
    public virtual void PlayerNear(Vector3 direction)
    {
        if (direction.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (direction.magnitude > 1)
        {
            direction = new Vector3(direction.x, direction.y, 0);
            direction.Normalize();
            gameObject.transform.position += direction * Time.deltaTime * speed;

        }
    }
    public override void Die()
    {
        Mediator.Enemies.Remove(this);
        GameObject.Destroy(gameObject);
    }
}