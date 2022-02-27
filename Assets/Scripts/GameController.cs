using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private Button button;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(Exit);
    }
    
    // Start is called before the first frame update
    public void Exit()
    {
        Application.Quit();
    } 
}
