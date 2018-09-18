using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static bool isdie = false;
	public static bool ishurt = false;
	public GameObject Hp;
	public GameObject BackGround;
	float dy = 0;
	int cnt = 1;

	float ntime;
	float time = 2f;

	int coincnt = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (ButtonManager.isJump == true) {
			if (cnt >= 2) {
				dy += 0;
			} else {
				dy = 15.5f * Time.deltaTime;
			}
			ButtonManager.isJump = false;
			cnt++;
		}
		transform.Translate (0, dy, 0);

		if (dy >= 0) {
			dy -= 0.4f * Time.deltaTime;
		}

		if (dy <= 0) {
			cnt = 0;
		}

		ntime += Time.deltaTime;
	}

	void jump()
	{
		GetComponent<Rigidbody2D>().AddForce (transform.up * 5, ForceMode2D.Impulse);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Enemy") {
			ishurt = true;
			Hp.transform.localScale -= new Vector3 (0.1f, 0, 0);
			if (Hp.transform.localScale.x <= 0) {
				Hp.transform.localScale += new Vector3 (0.1f, 0, 0);
			}

			if (Hp.transform.localScale.x <= 0.5f) {
				isdie = true;
			}
		}
		if (coll.gameObject.tag == "Block") {
			coincnt++;
			Destroy (coll.gameObject);

			if (coincnt >= 10) {
				Application.LoadLevel ("Score");
			}
		}
	}
}
