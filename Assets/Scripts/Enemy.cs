using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Pause.newXposition = transform.position.x + 7 * Time.deltaTime;
		transform.position = new Vector2 (Pause.newXposition, transform.localPosition.y);
	}
}
