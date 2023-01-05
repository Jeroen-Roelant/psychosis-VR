using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnLook : MonoBehaviour
{
    public Camera camera;
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
    bool viewed = false;
    private void Start()
    {
        GameObject gameObject = this.gameObject;
    }
    // Update is called once per frame
    void Update()
    {
        if (IsTargetVisible(camera, gameObject))
        {
            viewed = true;
            Debug.Log("Is visible");
        }
        else
        {
            Debug.Log("Is not visible");
            if (viewed)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}
