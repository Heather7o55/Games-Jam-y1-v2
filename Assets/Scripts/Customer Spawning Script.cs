using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CustomerSpawningScript : MonoBehaviour
{
    public struct Difficulty
    {
        // "low" and "high" defined the minimum and maximum amount of time in seconds that the player has to fulfill a customer request 
        public int low;
        public int high;
        public int maxRequests;
    }
    public static Difficulty difficulty;
    // This declaration is the global difficulty for the game
    // Update is called once per frame
    private bool timerActive = false;
    public GameObject customerGObj;
    public static int activeCustomers = 0;
    public static List<CustomerScript> customers = new List<CustomerScript>();
    public Transform[] spawnPoints;
    public TMP_Text text;
    void Start()
    {
        difficulty.low = 5;
        difficulty.high = 10;
        difficulty.maxRequests = 6;
    }
    
    void Update()
    {
        text.text = $"Score: {Score.currentScore}";
        if(timerActive || activeCustomers >= difficulty.maxRequests) return;
        else 
            StartCoroutine(SpawnCustomer(GenerateTimer()));
    }
    public void SpawnCustomer()
    {
        int tmp;
        while(true)
        {
            tmp = Random.Range(0,spawnPoints.Length);
            if(!customers.Any(CustomerScript => CustomerScript.pos == tmp)) break;
        }
        Debug.Log("spawned customer");
        GameObject customerTmp = Instantiate(customerGObj, spawnPoints[tmp]);
        customerTmp.GetComponent<CustomerScript>().pos = tmp;
        activeCustomers++;
    }
    private float GenerateTimer()
    {
        return Random.Range(difficulty.low ,difficulty.high);
    }
    private IEnumerator SpawnCustomer(float timer)
    {
        timerActive = true;
        yield return new WaitForSeconds(timer);
        SpawnCustomer();
        timerActive = false;
    }
}

