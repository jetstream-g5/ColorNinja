using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCheckPlatform : MonoBehaviour {

    private Text _deadText;

    void Start()
    {
        _deadText = GameObject.Find("DeadText").GetComponent<Text>();
        _deadText.enabled = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "PlatformBlue")
        {
            if(gameObject.GetComponent<PlayerColor>()._isBlue == false)
            {
                StartCoroutine(Death(3f));
            }
        }

        if(col.tag == "PlatformOrange")
        {
            if(gameObject.GetComponent<PlayerColor>()._isBlue == true)
            {
                StartCoroutine(Death(3f));
            }
        }
    }

    IEnumerator Death(float waitForSeconds)
    {
        _deadText.enabled = true;
        GameObject.Find("ChunkManager").GetComponent<ChunkManager>().chunkSpeed = 0;
        yield return new WaitForSeconds(waitForSeconds);
        _deadText.enabled = false;
        Application.LoadLevel(0);
    }
}
