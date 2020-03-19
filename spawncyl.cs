using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncyl : MonoBehaviour
{
    public Transform spawnpoint;
   float offset=25f;
     Vector3 spawn;   
    public GameObject cylinderbitch;
  void Update()
  {
      spawn = new Vector3(spawnpoint.position.x,spawnpoint.position.y-offset,spawnpoint.position.z);
  }
  
   private void OnTriggerEnter(Collider other) {
       if(other.tag==("cylinder")||other.tag==("Finish"))
       {
           Instantiate(cylinderbitch,spawn,Quaternion.identity);
           
       }
            offset = offset+5f;
       
   }
  
}
