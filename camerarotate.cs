using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerarotate : MonoBehaviour
{
    float rotate=0f;
    public float fallspeed= 10f;
   
    Vector3 pivot;
    public GameObject pivotobj, Camera;
    float speed =500f;
 public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
    if(Camera.tag=="MainCamera"){
    rotate = Input.GetAxisRaw("Horizontal");

    pivot = pivotobj.transform.position;
    }
    }

    void FixedUpdate()
    {
        transform.RotateAround(pivot, Vector3.down, rotate*Time.fixedDeltaTime*-speed);
        rb.velocity = new Vector3(0, -fallspeed, 0);

    }
}
