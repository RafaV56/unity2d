using UnityEngine;
using System.Collections;

public class enemigoControlador : MonoBehaviour {

    //Nave principal para matar
    public GameObject navePrincipal;

    //marco del juego
    public float marco = 1f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //clamping rectificación de coordenadas
        float nuevaX = Mathf.Clamp(transform.position.x, -10 + marco, 10 - marco);
        float nuevaY = Mathf.Clamp(transform.position.y, -10 + marco, 10 - marco);
        transform.position = new Vector3(nuevaX, nuevaY, 0);
    }

}
