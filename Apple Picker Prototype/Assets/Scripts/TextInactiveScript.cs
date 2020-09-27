using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextInactiveScript : MonoBehaviour
{ 
    public GameObject textInstructions;
    // Start is called before the first frame update
    void Start()
    {
       
        
        textInstructions = GameObject.Find("/Canvas/settingsMenu/infoText");
        textInstructions.gameObject.SetActive(false);
    }

}
