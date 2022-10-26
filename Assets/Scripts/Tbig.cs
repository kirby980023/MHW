using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tbig : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float dist = Vector3.Distance(transform.position, target.position);
      Vector3 targetPos;
      
      if (dist < 8)
      {
          targetPos = new Vector3(transform.position.x, 0, transform.position.z);
        //  transform.localScale = new Vector3(2, 2, 2);
      }

      else
      {
          targetPos = new Vector3(transform.position.x, -2, transform.position.z);
        //   transform.localScale = new Vector3(1, 1, 1);
      }

      transform.position = Vector3.Lerp(transform.position, targetPos, 0.05f);
    }
}
