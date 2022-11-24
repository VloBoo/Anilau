using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Mediator.Menu();
        }
    }
}
