using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PresionarJugar()
    {
        SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
    }
    public void PresionarOpciones()
    {
        SceneManager.LoadScene("Opciones", LoadSceneMode.Single);
    }

}
