using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public float forceX = 0;
    public float forceY = 0;
    public float forceZ = 0;
    
    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.AddForce(new Vector3(forceX,forceY,forceZ));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
