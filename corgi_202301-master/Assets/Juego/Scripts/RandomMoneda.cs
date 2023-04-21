using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class RandomMoneda : MonoBehaviour
{
    [SerializeField]
    private GameObject game_object;

    public void Ocultar()
    {
        game_object.SetActive(false);
    }

    public void Mostrar()
    {
        game_object.SetActive(true);
    }
}
