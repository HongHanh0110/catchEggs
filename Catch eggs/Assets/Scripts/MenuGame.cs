using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGame : MonoBehaviour
{
    public void PlayGame()
    {
        Application.LoadLevel(" SampleScene");
    }

    public void HowPlayGame()
    {
        Application.LoadLevel("HowToPlay");
    }
    public void Back()
    {
        Application.LoadLevel("Menu");
    }
}
