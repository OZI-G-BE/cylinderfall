using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinder_destroyer : MonoBehaviour
{

  
  private void OnTriggerEnter(Collider other) {
      if(other.tag=="destroyer")
      {
          Destroy(this.gameObject);
      }
  }
}
