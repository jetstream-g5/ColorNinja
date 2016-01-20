using UnityEngine;
using System.Collections;

public class DeathSpike : MonoBehaviour {


     void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
        }
    }
}
