using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

//using UnityEngine.UI;

public class Score : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    private int numCoins;
    public int coinNeed;
    public TMP_Text coinLeft;
    public GameObject Door;

    // Start is called before the first frame update
    void Start()
    {
        coinLeft = GetComponent<TMP_Text>();
        numCoins = 0;
        Door.SetActive(true);
    }
    public virtual void OnMMEvent(PickableItemEvent e)
    {
        if (this.gameObject.tag == "coin")
        {
            MMEventManager.TriggerEvent(new MMGameEvent("coinEvent"));
            numCoins++;
            coinLeft.text = "" + numCoins;
            if (numCoins == coinNeed)
            {
                Debug.Log("la puerta esta abierta!!!");
                Door.SetActive(false);

            }
        }
    }
    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }
    /* private void OnTriggerEnter2D(Collider2D collision)
     {
         if (collision.gameObject.tag == "coin")
         {


         }
     }*/

    // Update is called once per frame
    void Update()
    {
       
    }

  
}
