using UnityEngine;
using System.Collections;

public class PlayerColor : MonoBehaviour {


    private Color _red = Color.red;
    private Color _green = Color.green;

    private bool _toggle = true;

    private Renderer _renderer;

	// Use this for initialization
	void Start ()
    {
        _renderer = GetComponent<Renderer>();
        ToggleColor();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ToggleColor();
        }
	}

    void ToggleColor()
    {
        _toggle = !_toggle;

        if (_toggle)
        {
            _renderer.material.color = _red;
        }
        else
        {
            _renderer.material.color = _green;
        }
    }
}
