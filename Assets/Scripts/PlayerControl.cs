using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    private Player me;
    void Start()
    {
        me = new Player(gameObject, 1, "Player", 10, 100, 10, 10, 8);
        Mediator.Player = me;
        Mediator.CameraTarget = transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Mediator.GameMod == 1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 1, 0) * Time.deltaTime * me.Speed;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, -1, 0) * Time.deltaTime * me.Speed;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * me.Speed;
                GetComponent<SpriteRenderer>().flipX = false;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(1, 0, 0) * Time.deltaTime * me.Speed;
                GetComponent<SpriteRenderer>().flipX = true;
            }

            if (Input.GetKey(KeyCode.Alpha1))
            {
                me.Attack1();
            }

            if (me.CurrentlyHealth <= 0)
            {
                me.Die();
            }
        }
    }
}
