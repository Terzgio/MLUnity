using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartCollectorPPO()
    {
        SceneManager.LoadScene("MLCollectPPO");
    }

    public void StartCollectorSAC()
    {
        SceneManager.LoadScene("MLCollectSAC");
    }

    /*
    public void StartTMP()
    {
        SceneManager.LoadScene("TMP");
    }

    public void StartFireEscape()
    {
        SceneManager.LoadScene("FireEscape");
    }

    */

    public void Quit()
    {
        Debug.Log("Quit game");
        Application.Quit();
    }
}
