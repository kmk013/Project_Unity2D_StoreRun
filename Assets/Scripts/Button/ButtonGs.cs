using UnityEngine;
using System.Collections;

public class ButtonGs : MonoBehaviour {

	void Update()
	{
		ButtonGS();
	}

	void ButtonGS()
	{
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("asdf");
		}
	}
}
