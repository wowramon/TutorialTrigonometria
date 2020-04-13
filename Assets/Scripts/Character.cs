using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public trigonometry Trigon;
    public GameObject CamaraGo;

    public float tang;



    private void Start()
    {
        Trigon = new trigonometry();
    }

    private void FixedUpdate()
    {


        tang = Trigon.FindTang(transform.position, CamaraGo.transform.position);
     
        float angle = (tang * 180f / Mathf.PI) -90;

        Quaternion anglesAxis = Quaternion.AngleAxis((angle), Vector3.down);
        transform.rotation = Quaternion.Slerp(transform.rotation, anglesAxis,Time.fixedDeltaTime *50f);
     
      

    }
    
}
