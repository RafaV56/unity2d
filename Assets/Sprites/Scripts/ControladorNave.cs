using UnityEngine;
using System.Collections;

public class ControladorNave : MonoBehaviour {

    public float speed = 5f;
    public float marco = 1f;
	
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
    }
}
