using System.Collections;
using MoreMountains.Tools;
using System.Collections.Generic;
using MoreMountains.InventoryEngine;
using MoreMountains.Feedbacks;
using UnityEngine;
using MoreMountains.CorgiEngine;
using TMPro;

public class ControlTiempo : GameManager
{
    private int tiempo;
    [SerializeField]
    private TMP_Text tempoLeft;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ContarTiempo(5));
    }

    private void Update()
    {
        tempoLeft.text = "0" + (5-tiempo);
    }
    private IEnumerator ContarTiempo(int tiempo_final)
    {
        if (tiempo < tiempo_final)
        {
            tiempo++;
            yield return new WaitForSecondsRealtime(1f);
            StartCoroutine(ContarTiempo(tiempo_final));
        }
        else
        {
            MMEventManager.TriggerEvent(new CorgiEngineEvent(CorgiEngineEventTypes.PlayerDeath));
            Debug.Log("DEAD");
        }
    }
}
