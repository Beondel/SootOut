using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score2 : MonoBehaviour {

	public int iceCapSize;
	public Sprite[] sprites;
	public Text score;
	public bool started;

	void Start () {
		started = false;
	}

	void Update () {
		if (started) {
			iceCapSize = GameObject.FindGameObjectWithTag ("ice2").GetComponent<Icecap2> ().size;
			if (iceCapSize >= 0 && iceCapSize <= 100) {
				Change ();
			}
		}
	}

	void Change () {
		//int n = (int)(((100 - iceCapSize) / 25) * 10);
		//GameObject.FindGameObjectWithTag("heat").GetComponent<SpriteRenderer>().sprite = sprites[n];
		score.text = iceCapSize.ToString() + "/100";
	}

	public void buttonPressed(){
		started = true;
		iceCapSize = GameObject.FindGameObjectWithTag ("ice2").GetComponent<Icecap2> ().size;
		//sprites = Resources.LoadAll<Sprite>("heatMeters");
		score.text = iceCapSize.ToString() + "/100";
	}
}
