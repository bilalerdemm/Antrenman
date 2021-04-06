using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    public int yasim = 25;
    public string adim = "Bilal";
    void OnEnable ()
    {
        Debug.Log("artık beynim var");
    }


    public void YasiniSoyle()
    {
        Debug.Log("Benim Yasim " + yasim);
        
    }

    public void AdimiSoyle()
    {
        Debug.Log("Benim adim " + adim);
    }

}