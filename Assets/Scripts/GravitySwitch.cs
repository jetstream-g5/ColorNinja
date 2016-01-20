using UnityEngine;
using System.Collections;

public class GravitySwitch : MonoBehaviour
{

    private Rigidbody rb;
    private int Gravity = 10;
    private bool isUp;

    private bool _canMove = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isUp = false;
        StartCoroutine(WaitBeforeStart(5f));
    }
    
    void Update()
    {
        if (_canMove)
        {
            rb.velocity = new Vector3(0, GravityStatus(), 0);
        }

        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isUp = !isUp;
        }

    }
    

    int GravityStatus() 
    {
        if (isUp)
        {
            Gravity = 10;
        }
        else 
        {
            Gravity = -10;
        }
        return Gravity;
    }

    IEnumerator WaitBeforeStart(float waitForSeconds)
    {
        yield return new WaitForSeconds(waitForSeconds);
        _canMove = true;
    }

}


