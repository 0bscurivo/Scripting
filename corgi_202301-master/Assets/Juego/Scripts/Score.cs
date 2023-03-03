using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int numCoins;
    public int coinNeed;
    public TMP_Text coinLeft;
    public GameObject Door;

    // Start is called before the first frame update
    void Start()
    {
        //coinLeft = GetComponent<TMP_Text>();
        numCoins = 0;
        Door.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            numCoins++;
            Debug.Log(numCoins);
            coinLeft.text = "" + numCoins;
            if (numCoins == 4)
            {
                Debug.Log("la puerta esta abierta!!!");
                Door.SetActive(false);
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
