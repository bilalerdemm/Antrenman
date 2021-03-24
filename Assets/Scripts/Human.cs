using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject myHuman;
    public GameObject myFinger;
    public static Human Instance;
    public GameObject Body;

    private void Awake()
    {
        Instance = this; 
    }



    void Start()
    {
        myHuman = GameObject.Find("Human");

        myFinger = GameObject.Find("Human/Body/Legs/Foot Left/Finger 3");

        myFinger = GameObject.FindGameObjectWithTag("Finger");

        






    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
