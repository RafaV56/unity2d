using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ControladorEscenas : MonoBehaviour {

	public void CambiarEscena(string nombre)
    {
        //Cambiar de escena de en el boton jugar de portada
        SceneManager.LoadScene(nombre);

    }


    public void SalirJuego()
    {
        //Método para salir del juego
        Application.Quit();

    }
}
