using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using TMPro;

public class RandomMoneda : MonoBehaviour, MMEventListener<CorgiEngineEvent>
{
    [SerializeField]
    private List<GameObject> Monedas;
    [SerializeField]
    private  TMP_Text coinLeft;
    [SerializeField]
    private GameObject Puerta;

    private int MonedasPuerta;
    private int Contador_Monedas;

    private void Start()
    {
        MonedasPuerta = Monedas.Count;
    }
    public virtual void OnMMEvent(CorgiEngineEvent e)
    {
        if (e.EventType == CorgiEngineEventTypes.LevelStart)
        {
            if(MonedasPuerta== 0)
            {
                Monedas[MonedasPuerta].SetActive(true);
            }
        }
        if (e.EventType == CorgiEngineEventTypes.StarPicked)
        {
            Contador_Monedas++;
            coinLeft.text = "" + Contador_Monedas;
            if (Contador_Monedas == 4)
            {
                Puerta.SetActive(false);
            }
        }
        if (e.EventType == CorgiEngineEventTypes.PlayerDeath)
        {
            Contador_Monedas=0;
            coinLeft.text = "" + Contador_Monedas;
            Puerta.SetActive(true);
        }


    }

    void OnEnable()
    {
        this.MMEventStartListening<CorgiEngineEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<CorgiEngineEvent>();
    }

}
