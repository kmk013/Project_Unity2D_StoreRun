using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public GameObject Zero;
	public GameObject One;
	public GameObject Two;
	public GameObject Three;
	public GameObject Four;
	public GameObject Five;
	public GameObject Six;
	public GameObject Seven;
	public GameObject Eight;
	public GameObject Nine;

	int ScoreCnt = 0;
	int cnt = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		cnt++;
		if (cnt % 1000 == 0) {
			ScoreCnt++;
		}
	}

	void score()
	{
		int hundred;
		int ten;
		int oneth;

		hundred = ScoreCnt / 100;
		ten = ScoreCnt / 100 / 10;
		oneth = ScoreCnt % 10;

		switch (hundred) {
		case 0:
			Instantiate (Zero);
			break;
		}
	}
}
