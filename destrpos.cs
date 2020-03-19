using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destrpos : MonoBehaviour
{
 
  Vector3 destrposit;
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
    void Fixedupdate()
    {
          transform.RotateAround(pivot, Vector3.down, rotate*Time.fixedDeltaTime*-speed); 
    }
}
