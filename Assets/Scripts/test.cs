using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private Vector3 newpos;
    public void Start()
    {
        newpos = this.transform.position + new Vector3(0, 0, -20);
    }
    public void Update()
    {
        Move();
    }
    public void Move()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position,newpos, Time.deltaTime * 1);
    }
}
