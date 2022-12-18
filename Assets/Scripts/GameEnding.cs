using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnding : MonoBehaviour
{
    public SpriteRenderer background;
    public GameObject UI;
    private int textTimer = 150;
    public Text text = null;
    public Text scoreText = null;
    void Start()
    {
        Mediator.EndScene = gameObject;
        Mediator.EndScene.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
            background.color = new Color(0, 0, 0, 0);
            text.text = "";
            textTimer = 150;
            Mediator.Menu();
        }
        UI.SetActive(false);
    }
    void FixedUpdate()
    {
        background.color = new Color(0, 0, 0, background.color.a + 0.01f);
        if (textTimer > 0)
        {
            textTimer--;
            if (textTimer == 0)
            {
                text.text = "You Died";
                scoreText.text = "Your score: " + Mediator.score;
            }
        }
    }
}
