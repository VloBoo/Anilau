using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitController : MonoBehaviour
{
    public int attack;
    public int time = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //color
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1 - (50 - time) / 50f);
    }
    void FixedUpdate()
    {
        if (time > 0)
        {
            time--;
        }
        else
        {
            GameObject.Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyControl>().me.TakeDamage(attack);
        }
    }
}
