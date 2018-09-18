using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public static bool isStair;
	public static float newXposition;

	float ntime;
	float time = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ntime += Time.deltaTime;

		if (ButtonManager.isPause == false) {
			newXposition = transform.position.x + 7 * Time.deltaTime;
		}
		else if (ButtonManager.isPause == true) {
			newXposition = transform.localPosition.x;
		}

		if (transform.position.x >= 140.3f) {
			newXposition = 140.3f;
			Application.LoadLevel ("Score");
		}
		transform.position = new Vector2 (newXposition, 0);
	}
}
