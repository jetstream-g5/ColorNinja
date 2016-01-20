using UnityEngine;
using System.Collections;

public class PlayerCheckPlatform : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "PlatformBlue")
        {
            if(gameObject.GetComponent<PlayerColor>()._isBlue == false)
            {
                Debug.Log("You died!");
            }
        }

        if(col.tag == "PlatformOrange")
        {
            if(gameObject.GetComponent<PlayerColor>()._isBlue == true)
            {
                Debug.Log("You died!");
            }
        }
    }
}
