using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carpma : MonoBehaviour
{
    //Bir küp gameobjesi,sphere gameobjectsine çarptığı zaman hem küp gameobjesinin hemde çarptığı sphere gameobjesinin tag’ını “Taha” nasıl yapabiliriz
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameObject.tag = "Taha";
            collision.gameObject.tag = "Taha";

        }

    }



}
