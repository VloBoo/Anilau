using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    // Start is called before the first frame update
    private Enemy me;
    public bool isSource = true;
    void Start()
    {
        if (isSource)
        {
            me = new Zombe(gameObject, 1, "Zombe", 10, 100, 10, 10, 3);
            Mediator.Enemies.Add(me);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Mediator.Player != null)
        {
            Vector3 playerPosition = Mediator.Player.GameObject.transform.position;
            Vector3 enemyPosition = transform.position;
            Vector3 direction = playerPosition - enemyPosition;
            if (direction.magnitude < 100)
            {
                me.PlayerNear(direction);
            }
        }
    }
}
