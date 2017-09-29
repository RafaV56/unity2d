using UnityEngine;
using System.Collections;

public class ControladorNave : MonoBehaviour {

    //velocidad de la nave
    public float speed = 5f;
    //marco del juego
    public float marco = 1f;
    //Balas
    public GameObject balas;


	
	// Actualiza cada fotograma
	void Update() {

        //movimiento con variación de horizontal 

        float entradaHorizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(entradaHorizontal * speed * Time.deltaTime, 0, 0);

        //movimiento con variación de velocidad 

        float entradaVertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, entradaVertical * speed * Time.deltaTime, 0);


        //clamping rectificación de coordenadas
        float nuevaX = Mathf.Clamp(transform.position.x, -10+marco, 10-marco);
        float nuevaY = Mathf.Clamp(transform.position.y, -10+marco, 10-marco);
        transform.position = new Vector3(nuevaX, nuevaY, 0);

        //Disparo
        if (Input.GetKeyDown(KeyCode.Space)){
            //poner el repetidor en marcha de rafaga. 
            InvokeRepeating("Fuego", 0.001f, 0.25f);
        }else if (Input.GetKeyUp(KeyCode.Space))
        {
            //parar la rafagas
            CancelInvoke("Fuego");
        }
    }

    void Fuego()
    {
        var nave = GameObject.Find("Nave");
        if (nave != null)
        {
            Vector3 posIzq = nave.transform.position + Vector3.up * 1.3f + Vector3.left * 0.65f;
            Vector3 posDer = nave.transform.position + Vector3.up * 1.3f + Vector3.right * 0.65f;
            Instantiate(balas, posIzq, Quaternion.identity);
            Instantiate(balas, posDer, Quaternion.identity);
        }
    }

}
