using UnityEngine;
using System.Collections;

public class PlayerColor : MonoBehaviour {

    [SerializeField]
    private Color _orange;
    [SerializeField]
    private Color _blue;

    private bool _toggle = true;

    private Renderer _renderer;


	void Start ()
    {
        _renderer = GetComponent<Renderer>();
        ToggleColor();
	}
	
	void Update () 
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            ToggleColor();
        }
	}

    void ToggleColor()
    {
        _toggle = !_toggle;

        if (_toggle)
        {
            _renderer.material.color = _orange;
        }
        else
        {
            _renderer.material.color = _blue;
        }
    }
}
