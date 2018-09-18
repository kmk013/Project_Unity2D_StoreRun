using UnityEngine;
using System.Collections;

public class MoveBackImage : MonoBehaviour {

	float newXposition;
	int i = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (i % 2 == 0) 
		{
			newXposition = transform.position.x - Time.deltaTime;
			if (newXposition <= -26) {
				i++;
			}
		} 
		else if (i % 2 == 1) 
	    {
			newXposition = transform.position.x + Time.deltaTime;
			if (newXposition >= 26) {
				i--;
			}
	    }
		transform.position = new Vector2(newXposition, 0);


	}
}
