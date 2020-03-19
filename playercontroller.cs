using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour
{
    public Text gameover;
   public float fallspeed= 10f;
    public Text score;
public GameObject ball;
public Rigidbody rb;

public scoreup scoreup;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
          gameover.enabled=false;
    }

   
   void FixedUpdate()
    {
        rb.velocity = new Vector3(0, -fallspeed, 0);

    }
   
   
   
   void ShowUI()
   {
       gameover.enabled=true;
       score.enabled=false;
   }
    private void OnCollisionEnter(Collision other) {
        if(other.collider.tag == "obstacle")
        {
            GameObject.Destroy(ball);
            ShowUI();
            }

    }

    private void OnTriggerEnter(Collider other) {
        
        if(other.tag == "score up")
         scoreup.scorevalue++;
          
        
    }
}
