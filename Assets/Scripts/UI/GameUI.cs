using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Image _healthBar;
    public Image _manaBar;
    public Text _healthText;
    public Text _manaText;
    public Text _scoreText;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        _scoreText.text = Mediator.score.ToString();
        float h = Mediator.player.CurrentlyHealth;
        if(h < 0)
        {
            h = 0;
        }
        float m = Mediator.player.CurrentlyPower;
        if(m < 0)
        {
            m = 0;
        }
        _healthText.text = h + "/" + Mediator.player.BaseHealth.ToString();
        _manaText.text = m + "/" + Mediator.player.BasePower.ToString();
        _healthBar.transform.localScale = new Vector3(h / (float)Mediator.player.BaseHealth, 1, 1);
        _manaBar.transform.localScale = new Vector3(m / (float)Mediator.player.BasePower, 1, 1);
    }
}
