using UnityEngine;
using System.Collections;

public class balaControlador : MonoBehaviour {

    public float velocidadBala = 8f;

	// Use this for initialization
	void Start () {
        //movemos la bala dinamicamente
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(0, velocidadBala, 0);
	}
	
	// Update is called once per frame
	void Update () {
        //Si la y de la bala esta por encima se destruye
        if (transform.position.y > 10.5 || transform.position.y < -10.5)
        {
            Destroy(gameObject);
            print("destruida la bala");
        }
	}
}
