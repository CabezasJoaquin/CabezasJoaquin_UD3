using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDeJugador : MonoBehaviour
{
    //Almacena componetne Rigidbody del personaje Jugador
    Rigidbody rb;

    public float velocidad;
    int contador;

    public Text Marcador;
    public Text FinJuego;

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
        rb.AddForce(movimiento*velocidad);
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        contador = contador + 1;
        ActualizaMarcador();
    }

    void ActualizaMarcador()
    {
        Marcador.text = "Puntos: " + contador;
    }
}