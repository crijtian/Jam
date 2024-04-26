using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Arma : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer spriteRenderer;
    public new Camera camera;
    void Start()
    {
        spriteRenderer=GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateTowardsMouse();        
    }

    private void RotateTowardsMouse()
    {
        float angle = GetAngleTowardMouse();
        
        transform.rotation=Quaternion.Euler(0,0,angle);
        spriteRenderer.flipY = angle >= 90 && angle <= 270;
    }

    private float GetAngleTowardMouse()
    {
        Vector3 mouseWorldPosition = camera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mouseDirection=mouseWorldPosition-transform.position;
        mouseDirection.z = 0;
        float angle = (Vector3.SignedAngle(Vector3.right, mouseDirection, Vector3.forward) + 360) % 360;
        return angle;
    }
}
 
