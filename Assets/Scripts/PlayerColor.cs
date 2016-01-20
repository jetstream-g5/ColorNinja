using UnityEngine;
using System.Collections;

public class PlayerColor : MonoBehaviour {

    [SerializeField]
    private Color _orange;
    [SerializeField]
    private Color _blue;

    public bool _isBlue = true;

    private Renderer _renderer;

    private ParticleSystem _particleSystem;


	void Start ()
    {
        _renderer = GetComponent<Renderer>();
        _particleSystem = GameObject.Find("PlayerParticles").GetComponent<ParticleSystem>();
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
        _isBlue = !_isBlue;

        if (_isBlue == true)
        {
            _renderer.material.color = _blue;
            //verander particle kleur
            
        }
        if(_isBlue == false)
        {
            _renderer.material.color = _orange;
            //verander particle kleur
        }
    }
}
