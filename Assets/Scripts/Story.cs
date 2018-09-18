using UnityEngine;
using System.Collections;

public class Story : MonoBehaviour {

	public GameObject Story1;
	public GameObject Story2;
	public GameObject Story3;
	public GameObject Story4;
	public GameObject LoadingBackGround;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (Story1, 2.0f);
		Destroy (Story2, 4.0f);
		Destroy (Story3, 6.0f);
		Destroy (Story4, 8.0f);
		Destroy (LoadingBackGround, 10.0f);

		Inmain ();
	}

	IEnumerator Inmain()
	{
		yield return new WaitForSeconds (10.0f);
		Application.LoadLevel("Main");
	}
}
