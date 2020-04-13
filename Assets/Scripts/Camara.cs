using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
   public  GameObject target;
   
   
    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.Q))
        {
            transform.RotateAround(target.transform.position, new Vector3(0, 1, 0), 1f);
            
            
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.RotateAround(target.transform.position, new Vector3(0, -1, 0), 1f);
        }

       

    }

}
