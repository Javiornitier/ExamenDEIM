using UnityEngine;
using System.Collections;
//No me funciona el script en si, más abajo hay un comentario.

public class Nave : MonoBehaviour {


	public float velocidad = 100f;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();
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

	void OnTriggerExit2D(Collider2D objeto){
		if (objeto.tag == "Meteorito") {
				DestroyObject;  //Creo que aqui es donde me falla todo, no se como era, pero se supone que la nave al tocar el tag meteorito deberia desaparecer.
		}
				
	void muerte (){
		gcs.respawn ();
	}

}
