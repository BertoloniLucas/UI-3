using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class LoginManager : MonoBehaviour
{
    public InputField passwordUser; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LeerPassword ()
    {
        if (passwordUser.text == "Unity2024")
        {
            Debug.Log("Acces Granted"); 
        }
        else
        {
            Debug.Log("Acces Denied");
        }
    }
}
