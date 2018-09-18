using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {

	public GameObject PauseBackground;
	public GameObject ButtonNs;
	public GameObject ButtonBtg;
	public GameObject ButtonQ;
	public GameObject ButtonSlide;
	public GameObject ButtonJump;
	public GameObject Player;
	public static bool isSlide = false;
	public static bool isJump = false;
	public static bool isPause = false;
	float newYposition;

	float ntime;
	float time = 1f;

	void Update()
	{
		ntime += Time.deltaTime;
	}

	public void InPause()
	{
		PauseBackground.SetActive (true);
		ButtonNs.SetActive (true);
		ButtonBtg.SetActive (true);
		ButtonQ.SetActive (true);
		ButtonSlide.SetActive (false);
		ButtonJump.SetActive (false);

		isPause = true;
	}

	public void Slide()
	{
		isSlide = true;
	}

	public void Jump()
	{
		isJump = true;
	}

	public void InNewStart()
	{
		PauseBackground.SetActive (false);
		ButtonNs.SetActive (false);
		ButtonBtg.SetActive (false);
		ButtonQ.SetActive (false);
		ButtonSlide.SetActive (true);
		ButtonJump.SetActive (true);

		Application.LoadLevel ("Stage1");
	}

	public void InBackToGame()
	{
		PauseBackground.SetActive (false);
		ButtonNs.SetActive (false);
		ButtonBtg.SetActive (false);
		ButtonQ.SetActive (false);
		ButtonSlide.SetActive (true);
		ButtonJump.SetActive (true);

		isPause = false;
	}
		
	public void InQuit()
	{
		isPause = false;
		Application.LoadLevel ("Select");
	}
}