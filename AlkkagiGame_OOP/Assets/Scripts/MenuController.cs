using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

	public void MenuGame()
	{
		Application.LoadLevel("Menu_scene");

	}
	public void StartGame()
	{
		Application.LoadLevel("Start_scene");

	}
	public void OptionMenu()
	{
		Application.LoadLevel("Option_scene");
	}
	public void AboutMenu()
	{
		Application.LoadLevel("About_scene");
	}

	public void How2playMenu()
	{
		Application.LoadLevel("How2play_scene");
	}

	public void EndGame ()
	{
		Application.Quit ();
	}
}
