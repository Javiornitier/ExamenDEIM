using UnityEngine;
using System.Collections;

public class Jugador2 : MonoBehaviour {


	public float velocidad = 100f;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
	}

	void Update () {

		if (Input.GetKey (KeyCode.D)) {
			MovimientoDerecha ();
		}
		if (Input.GetKey (KeyCode.A)) {
			MovimientoIzquierda ();
		}
		if (Input.GetKey (KeyCode.W)) {
			MovimientoArriba ();
		}
		if (Input.GetKey (KeyCode.S)) {
			MovimientoAbajo ();
		}
	}
	void MovimientoDerecha(){
		rb.velocity = new Vector2(velocidad, rb.velocity.y);
		this.transform.localScale = new Vector3(1, 1, 1);
	}

	void MovimientoIzquierda() {
		rb.velocity = new Vector2(-velocidad, rb.velocity.y);
		this.transform.localScale = new Vector3(-1, 1, 1);
	}

	void MovimientoArriba(){
		rb.velocity = new Vector2(velocidad, rb.velocity.x);
		this.transform.localScale = new Vector3(1, 1, 1);
	}

	void MovimientoAbajo() {
		rb.velocity = new Vector2(-velocidad, rb.velocity.x);
		this.transform.localScale = new Vector3(-1, 1, 1);
	}
}
