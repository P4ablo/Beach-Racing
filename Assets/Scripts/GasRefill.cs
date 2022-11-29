using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasRefill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) //kiedy następuje kolizja
    {
        VehicleController.instance.gas = 1f; //ilosc paliwa zwieksza sie do 100% kiedy najedziemy na ikonke
        Destroy(gameObject); // po przejechaniu przez ikonke gameobject sie usuwa
    }
 
}
