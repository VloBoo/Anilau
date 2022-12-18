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

    public void Attack1(Vector2 mousePosition)
    {
        Vector2 direction = mousePosition - (Vector2)gameObject.transform.position;
        direction.Normalize();
        GameObject hit = GameObject.Instantiate(Resources.Load("Prefabs/Hit") as GameObject);
        hit.transform.position = gameObject.transform.position + (Vector3)direction * 0.9f;
        hit.GetComponent<HitController>().attack = baseAttack;
        //rotate
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        hit.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

    }
    public void Attack2(Vector2 mousePosition)
    {
        Vector2 direction = mousePosition - (Vector2)gameObject.transform.position;
        direction.Normalize();
        GameObject hit = GameObject.Instantiate(Resources.Load("Prefabs/Hit") as GameObject);
        hit.transform.position = gameObject.transform.position + (Vector3)direction * 1.3f;
        hit.GetComponent<HitController>().attack = baseAttack * 2;
        //rotate
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        hit.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        hit.transform.localScale = new Vector3(3, 3, 3);

    }


}