using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class VehicleController : MonoBehaviour
{
    // Zmienne wykorzystywane
    public static VehicleController instance;
    public Rigidbody2D Ftire;
    public Rigidbody2D Btire;
    public Rigidbody2D Vehicle;
    public float speed;
    public float movement;
    public float gas = 1f;
    public float gasConsumption = 0.1f;
    public Image gasImage;
    
    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
  
    private void Update()
    {
        movement = Input.GetAxis("Horizontal"); //Poruszanie sie strzałkami
        gasImage.fillAmount = gas; // zmiana ilości paliwa jako obraz
    }
    
    private void FixedUpdate()
    {
        if(gas > 0 )
        {
            Ftire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            Btire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            Vehicle.AddTorque(movement * speed * Time.fixedDeltaTime);
        }
          
        gas = gas - gasConsumption * Time.fixedDeltaTime * Mathf.Abs(movement); // zmiana ilosci paliwa

    }
}
