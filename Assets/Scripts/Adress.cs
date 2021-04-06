using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adress : MonoBehaviour
{

    public GameObject myAdress;

    public GameObject myHome;

    public GameObject myStreet;

    public GameObject[] Enemys;

    public GameObject A, H;

    public Brain otherBrain;



    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Find kullanımı.
        myAdress = GameObject.Find("Adress");
        myHome = GameObject.Find("/Adress/Turkiye/Istanbul/Beykoz/Sinem Sokak/No 3");
        myStreet = GameObject.FindGameObjectWithTag("Sokak");

        //GetComponent ve İnstance kullanarak İnspectorda bir şeyleri kapatma.
        Human.Instance.Body.GetComponent<Animation>().enabled = false;
        Human.Instance.GetComponentInChildren<Animator>().enabled = false;


        //FindType kullanma
        H = GameObject.FindObjectOfType<Human>().gameObject;

        //Parent alma
        GameObject myTargetObject = Human.Instance.transform.parent.gameObject;
        //Child alma 
        Human.Instance.transform.GetChild(0);
        //Aldığımız objenin ismini yazma
        Debug.Log(myTargetObject.name);

        // Objemizin içindeki deneme.cs de bulunan methodu çalıştırma
        myTargetObject.GetComponent<Deneme>().MyTestMetod();

        //Başka bir objeye component ekleme
        Brain myBrain = Human.Instance.transform.GetChild(0).GetChild(0).gameObject.AddComponent<Brain>();
        myBrain.YasiniSoyle();
        otherBrain.YasiniSoyle();
        //Tag kullanarak objenin yerini değiştirme.
        Enemys = GameObject.FindGameObjectsWithTag("Enemy");


        foreach (var enemy in Enemys)
        {
            enemy.SetActive(false);
        }

        A = GameObject.Find("A/B/C/D");


    }

    // Update is called once per frame
    void Update()
    {

    }
}
