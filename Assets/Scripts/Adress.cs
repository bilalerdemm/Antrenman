using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adress : MonoBehaviour
{

    public GameObject myAdress;

    public GameObject myHome;

    public GameObject myStreet;

    public GameObject A;

    // Start is called before the first frame update
    void Start()
    {
        myAdress = GameObject.Find("Adress");

        
        myHome = GameObject.Find("/Adress/Turkiye/Istanbul/Beykoz/Sinem Sokak/No 3");

        myStreet = GameObject.FindGameObjectWithTag("Sokak");

        A = GameObject.Find("A/B/C/D");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
