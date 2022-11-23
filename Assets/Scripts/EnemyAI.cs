using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Mediator.Player != null)
        {
            Vector3 playerPosition = Mediator.Player.transform.position;
            Vector3 enemyPosition = transform.position;
            Vector3 direction = playerPosition - enemyPosition;
            if (direction.x > 0)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            if (direction.magnitude > 1)
            {
                direction.Normalize();
                transform.position += direction * Time.deltaTime * 3;

            }
        }
    }
}
