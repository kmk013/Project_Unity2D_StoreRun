using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject ButtonStory;

	public void InSelect()
	{
		Application.LoadLevel ("Select");
	}

	public void InHowToPlay()
	{
		Application.LoadLevel ("HowToPlay");
	}

	public void InGameEnd()
	{
		Application.Quit ();
	}

	public void InMain()
	{
		Application.LoadLevel ("Main");
	}

	public void InStage1()
	{
		Application.LoadLevel ("Stage1");
	}

	public void InStage2()
	{
		Application.LoadLevel ("Stage2");
	}

	public void InStage3()
	{
		Application.LoadLevel ("Stage3");
	}

	public void InStory()
	{
		Application.LoadLevel ("Story");
		Destroy (ButtonStory);
	}
}
