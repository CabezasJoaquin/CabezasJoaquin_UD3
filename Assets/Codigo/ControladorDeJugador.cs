using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDeJugador : MonoBehaviour
{
    //Almacena componetne Rigidbody del personaje Jugador
    Rigidbody rb;

    public float velocidad;
    int contador;
    int numItems_1;
    int numItems_2;
    int numItems_3;

    public Text Marcador;
    public Text FinJuego;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();

        FinJuego.gameObject.SetActive(false);
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
        if (other.tag == "suma1")
        {
            Destroy(other.gameObject);
            contador = contador + 1;
            numItems_1 = numItems_1 + 1;
        }

        else if (other.tag == "suma2")
        {
            Destroy(other.gameObject);
            contador = contador + 2;
            numItems_2 = numItems_2 + 1;
        }

        else if (other.tag == "resta")
        {
            Destroy(other.gameObject);
            contador = contador - 1;
            numItems_3 = numItems_3 - 1;
        }

        ActualizaMarcador();

        if (contador >= 10) 
        {
            FinJuego.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

        else if (numItems_1 >= 4 && numItems_2 >= 4) 
        {
            FinJuego.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void ActualizaMarcador()
    {
        Marcador.text = "Tienes: " + contador + " puntos";
    }
}