using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    private MeshRenderer _renderer;
    private Rigidbody _rigidbody;
    [SerializeField] float timeToWait;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();
        
        _renderer.enabled = false;
        _rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            _renderer.enabled = true;
            _rigidbody.useGravity = true;
        }
    }
}