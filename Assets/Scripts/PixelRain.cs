using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PixelRain : MonoBehaviour {

	private List<GameObject> Pixel  = new List<GameObject>();
	public float speed = -5f;
	public int Timing = 10;
	private int time;


	void FixedUpdate () {
		time++;

		if (time == Timing) {
			Pixel.Add (Instantiate ((GameObject)Resources.Load ("Prefabs/Rain", typeof(GameObject)), new Vector3 (Random.Range (0f, Mathf.RoundToInt (Screen.width)), this.transform.position.y, 0f), transform.rotation, this.transform) as GameObject);
			time = 0;
		}

		for (int i = 0; i <= Pixel.Count-1; i++) {			
			Pixel [i].transform.Translate (0, speed, 0);
		}
		for (int u = 0; u <= Pixel.Count - 1; u++) {
			if (Pixel [u].transform.position.y <= -10f) {
				Destroy (Pixel [u]);
				Pixel.Remove (Pixel [u]);
			}
		}

	}

}
