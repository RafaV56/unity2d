using UnityEngine;
using System.Collections;

public class Plataforma : MonoBehaviour {

    //eventos de colisiones
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Ha ocurrido un evento Colisión");
    }

    //Eventos de triger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Ha ocurrido un evento de triger");
    }
}
