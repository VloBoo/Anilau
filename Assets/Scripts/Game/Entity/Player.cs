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

    public void Attack1()
    {
        foreach (Enemy enemy in Mediator.Enemies){
            if (Vector3.Distance(gameObject.transform.position, enemy.GameObject.transform.position) < 1)
            {
                enemy.TakeDamage(MakeDamage());
            }
        }
    }

}