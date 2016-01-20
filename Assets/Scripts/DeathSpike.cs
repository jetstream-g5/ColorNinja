using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DeathSpike : MonoBehaviour {

    private Text _deadText;

    void Start()
    {
        _deadText = GameObject.Find("DeadText").GetComponent<Text>();
        _deadText.enabled = false;
    }

     void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            StartCoroutine(Death(3f));
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
