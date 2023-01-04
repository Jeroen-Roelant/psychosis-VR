using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    private GameObject gameObject;
    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        gameObject = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        var position = Target.transform.position;
        position.y = this.transform.position.y;
        this.transform.LookAt(position);
    }
}
