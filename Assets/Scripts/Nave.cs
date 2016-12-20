using UnityEngine;
using System.Collections;
//No me funciona el script en si, más abajo hay un comentario.

public class Nave : MonoBehaviour {


	public float velocidad = 100f;
	private Rigidbody2D rb;
	private GameControlScript gcs;

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();
		gcs = GameObject.Find ("GameControl").GetComponent<GameControlScript>();
	}

	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
			MovimientoDerecha ();
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			MovimientoIzquierda ();
		}


	void MovimientoDerecha(){
		rb.velocity = new Vector2(velocidad, rb.velocity.y);
		this.transform.localScale = new Vector3(1, 1, 1);
	}

	void MovimientoIzquierda() {
		rb.velocity = new Vector2(-velocidad, rb.velocity.y);
		this.transform.localScale = new Vector3(-1, 1, 1);
	}

	void Salto() {
		GetComponent<Rigidbody2D> ().AddForce (Vector2.up*300);
	}

	void OnTriggerExit2D(Collider2D objeto){
		if (objeto.tag == "Meteorito") {
			Meteorito = false;  //Creo que aqui es donde me falla todo, no se como era, pero se supone que la nave al tocar el tag meteorito deberia desaparecer.
		}
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Muerte") {
			Invoke ("muerte", 1);
		}
	void muerte (){
		gcs.respawn ();
	}

}
