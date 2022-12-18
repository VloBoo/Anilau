using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    private Player me;
    void Start()
    {
        me = new Player(gameObject, 1, "Player", 10, 100, 10, 5000, 8);
        Mediator.player = me;
        Mediator.CameraTarget = transform;
    }
    void Update()
    {
        if (Mediator.GameMod == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                me.Attack1(mousePosition);
            }
            if (Input.GetMouseButtonDown(1))
            {
                if (me.CurrentlyPower > 1000)
                {
                    Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    me.Attack2(mousePosition);
                    me.CurrentlyPower -= 1000;
                }

            }
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Mediator.GameMod == 1)
        {
            Vector2 direction = new Vector2(0, 0);
            if (Input.GetKey(KeyCode.W))
            {
                direction += new Vector2(0, 1);
            }
            if (Input.GetKey(KeyCode.S))
            {
                direction += new Vector2(0, -1);
            }
            if (Input.GetKey(KeyCode.A))
            {
                direction += new Vector2(-1, 0);
                GetComponent<SpriteRenderer>().flipX = false;
            }
            if (Input.GetKey(KeyCode.D))
            {
                direction += new Vector2(1, 0);
                GetComponent<SpriteRenderer>().flipX = true;
            }
            if (direction.magnitude > 1)
            {
                direction.Normalize();
            }

            me.GameObject.GetComponent<Rigidbody2D>().MovePosition(me.GameObject.GetComponent<Rigidbody2D>().position + direction * Time.deltaTime * me.Speed);

            if (me.CurrentlyHealth <= 0)
            {
                me.Die();
            }
            if (me.CurrentlyPower <= me.BasePower)
            {
                me.CurrentlyPower += 1;
            }
        }
    }
}
