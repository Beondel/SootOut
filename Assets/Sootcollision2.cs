using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sootcollision2 : MonoBehaviour {

	public bool onIce1;
	public bool onIce2;
	public bool onIce3;

	// Use this for initialization
	void Start () {
		onIce1 = false;
		onIce2 = false;
		onIce3 = false;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "ice") {
			onIce1 = true;
		}
		if (other.gameObject.tag == "ice2") {
			onIce2 = true;
		}
		if (other.gameObject.tag == "ice3") {
			onIce3 = true;
		}
		if (other.gameObject.tag == "soot" && (other.gameObject.GetComponent<Sootcollision2>().onIce1 || other.gameObject.GetComponent<Sootcollision2>().onIce2 || other.gameObject.GetComponent<Sootcollision2>().onIce3)){
			Destroy (this.gameObject);
		}
		if (other.gameObject.tag == "sunlight" && onIce1) {
			Destroy (other.gameObject);
			GameObject.Find ("ice1").GetComponent<Icecap> ().specialContact ();
		}
		if (other.gameObject.tag == "sunlight" && onIce2) {
			Destroy (other.gameObject);
			GameObject.Find ("ice2").GetComponent<Icecap2> ().specialContact ();
		}
		if (other.gameObject.tag == "sunlight" && onIce3) {
			Destroy (other.gameObject);
			GameObject.Find ("ice3").GetComponent<Icecap3> ().specialContact ();
		}


		if (other.gameObject.tag == "snowflake") {
			Destroy (other.gameObject);
			//GameObject.Find ("ice cap").GetComponent<Icecap> ().specialContact2 ();
		}
	}
}
