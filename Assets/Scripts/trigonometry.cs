using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigonometry 
{
   
    public float FindCos(Vector3 OriginPosition, Vector3 Targetposition)
    {
        Vector3 ImgA = new Vector3(Targetposition.x, 1f, OriginPosition.z);
   
         float distance = (Targetposition - OriginPosition).magnitude;
        
        float Abscisa = ImgA.x;

        float cos = Abscisa / distance;
        return cos;
    }
    public float FindArcCos(Vector3 OriginPosition, Vector3 Targetposition)
    {
        Vector3 ImgA = new Vector3(Targetposition.x, 1f, OriginPosition.z);

        float distance = (Targetposition - OriginPosition).magnitude;

        float Abscisa = ImgA.x;

        float cos = Abscisa / distance;
        return Mathf.Acos( cos);
    }

    public float FindSen(Vector3 OriginPosition, Vector3 Targetposition)
    {
        Vector3 ImgB = new Vector3(OriginPosition.x, 1f, Targetposition.z);

        float distance = (Targetposition - OriginPosition).magnitude;

        float Ordenada = ImgB.z;

        float seno = Ordenada/distance;
        return seno;
    }
    public float FindArcSen(Vector3 OriginPosition, Vector3 Targetposition)
    {
        Vector3 ImgB = new Vector3(OriginPosition.x, 1f, Targetposition.z);

        float distance = (Targetposition - OriginPosition).magnitude;

        float Ordenada = ImgB.z;

        float seno = Ordenada / distance;
        return Mathf.Asin(seno);
    }

    public float FindTang(Vector3 OriginPosition, Vector3 Targetposition)
    {
        Vector3 ImgA =  new Vector3(Targetposition.x, 1f, OriginPosition.z);
        Vector3 ImgB = new Vector3(OriginPosition.x, 1f, Targetposition.z);
     
        float Abscisa = ImgA.x;
        float Ordenada = ImgB.z;

        float tang = Mathf.Atan2(Ordenada , Abscisa); // esto es igual a ordenada/Abscisa en unidades de Radianes

        return tang;
    }
}
