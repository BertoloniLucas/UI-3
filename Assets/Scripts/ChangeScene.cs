﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName; 
    // Start is called before the first frame update
    void Start()
    {
        sceneName = "EAC - Password";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CambiarEscena()
    {
        SceneManager.LoadScene(sceneName);
    }
}
