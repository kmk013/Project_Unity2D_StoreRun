using UnityEngine;
using System.Collections;

public class PlyaerAnimation : MonoBehaviour {

	Animator playerAnim = null;

	float ntime;
	float time = 100f;

	// Use this for initialization
	void Start () {
		playerAnim = gameObject.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		ntime += Time.deltaTime;

		if (Player.ishurt == true) {
			playerAnim.SetBool ("ChkHurt", true);
		} else {
			playerAnim.SetBool ("ChkHurt", false);
		}

		if (Player.isdie == true) {
			playerAnim.SetBool ("ChkDie", true);
		} else {
			playerAnim.SetBool ("ChkDie", false);
		}

		if (Pause.isStair == true) {
			playerAnim.SetBool ("ChkStair", true);
		} else {
			playerAnim.SetBool ("ChkStair", false);
		}

		if (ButtonManager.isSlide == true) {
			playerAnim.SetBool ("ChkSliding", true);
		} else {
			playerAnim.SetBool ("ChkSliding", false);
		}
	}
}