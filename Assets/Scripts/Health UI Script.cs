using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUIScript : MonoBehaviour
{
    public Sprite lostHealth;
    public Image[] healthUIs;

    // Update is called once per frame
    void Update()
    {
        if(Score.currentLives < 3)
        healthUIs[Score.currentLives].sprite = lostHealth;
    }
}
