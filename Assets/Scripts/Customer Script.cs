using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class CustomerScript : MonoBehaviour
{
    private float timerMax;
    private float timerActive;
    public Image timerImage;
    public int pos;
    public Sprite[] sprites;
    public SpriteRenderer body;
    void Start()
    {
        body.sprite = sprites[Random.Range(0, sprites.Length)];
        timerMax = Random.Range(CustomerSpawningScript.difficulty.low, CustomerSpawningScript.difficulty.high);
    }
    void Update()
    {
        timerActive += Time.deltaTime;
        timerImage.fillAmount = timerActive / timerMax;
        if(timerActive >= timerMax)
        {
            Score.TakeLives(1);
            Destroy(gameObject);
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude == 0f)
        {
            Score.AddScore(50);
            CustomerSpawningScript.activeCustomers--;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
