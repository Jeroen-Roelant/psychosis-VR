using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowOnLookAway : MonoBehaviour
{
    public Camera camera;
    public int x;
    private Vector3 previousPos;
    private Vector3 newPos;
    private bool stop = false;

    public bool IsTargetVisible(Camera c, GameObject go)
    {
        var planes = GeometryUtility.CalculateFrustumPlanes(c);
        var point = go.transform.position;
        foreach (var plane in planes)
        {
            if (plane.GetDistanceToPoint(point) < 0)
                return false;
        }
        return true;
    }
    private void Start()
    {
        GameObject gameObject = this.gameObject;
    }
    // Update is called once per frame
    void Update()
    {
        check();
        if (!stop)
        {
            if (IsTargetVisible(camera, gameObject))
            {
                if (this.GetComponent<AudioSource>().isPlaying)
                {
                    this.GetComponent<AudioSource>().Stop();
                }
            }
            else
            {
                previousPos = this.transform.position;
                newPos = new Vector3(Camera.main.transform.position.x - x, this.transform.position.y, this.transform.position.z);
                this.transform.position = Vector3.MoveTowards(this.transform.position, newPos, Time.deltaTime * 2);
                if (previousPos != this.transform.position)
                {
                    if (!this.GetComponent<AudioSource>().isPlaying)
                    {
                        this.GetComponent<AudioSource>().Play();
                    }
                }
                else
                {
                    if (this.GetComponent<AudioSource>().isPlaying)
                    {
                        this.GetComponent<AudioSource>().Stop();
                    }
                }
            }
        } 
    }

    void check()
    {
        if(this.transform.position.x < 20)
        {
            stop = true;
        }
    }
}
