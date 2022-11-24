using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class HealthBar : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = "Health: " + Mediator.Player.CurrentlyHealth.ToString();
    }
}
