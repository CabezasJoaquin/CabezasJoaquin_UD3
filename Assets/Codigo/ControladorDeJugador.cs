
using UnityEngine;
using System.Collections;

public class ControladorDeJugador : MonoBehaviour
{
    //Almacena componetne Rigidbody del personaje Jugador
    Rigidbody rb;
    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        
    }

    public void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        rb.AddForce(movimiento);
    }
}