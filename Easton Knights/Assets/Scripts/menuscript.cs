using UnityEngine;
using System.Collections;

public class menuscript : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
	
	}

	public void ChangetoScene (int nextscene) {
		Application.LoadLevel (nextscene);
	}

	public void ExitGame () { 
		Application.Quit ();
	}

	public void HelpClick () {
		GUI.Box (new Rect (Screen.width/3, Screen.height/3, 300, 270), "Instructions");
		GUI.Label (new Rect (Screen.width/3 + 20, Screen.height/3 + 20, 300, 20), "1. Click on Canon balls to pick them up");
		GUI.Label (new Rect (Screen.width/3 + 20, Screen.height/3 + 40, 300, 20), "   you may only have 5 canon balls at one time.");
		GUI.Label (new Rect (Screen.width/3 + 20, Screen.height/3 + 60, 300, 20), "2. Don't jump off the boat, if you do, ");
		GUI.Label (new Rect (Screen.width/3 + 20, Screen.height/3 + 80, 300, 20), "   you will loose a life and all your canon balls.");
		GUI.Label (new Rect (Screen.width/3 + 20, Screen.height/3 + 100, 300, 20), "   Loose all lives and you die!");
		GUI.Label (new Rect (Screen.width/3 + 20, Screen.height/3 + 120, 300, 20), "3. Stand behind canons wiht at least 1 canon");
		GUI.Label (new Rect (Screen.width/3 + 20, Screen.height/3 + 140, 300, 20), "   ball, and fire at the Shark, hit it 10 times ");
		GUI.Label (new Rect (Screen.width/3 + 20, Screen.height/3 + 160, 300, 20), "   and you win!");
		GUI.Label (new Rect (Screen.width/3 + 20, Screen.height/3 + 180, 300, 20), "4. Make sure you kill the Shark before it gets");
		GUI.Label (new Rect (Screen.width/3 + 20, Screen.height/3 + 200, 300, 20), "   hungry, which happens in ~5 minutes");
		GUI.Label (new Rect (Screen.width/3 + 95, Screen.height/3 + 225, 300, 20), "GOOD LUCK MATE!");
		GUI.Label (new Rect (Screen.width/3 + 105, Screen.height/3 + 250, 300, 20), "Press 'h' to close.");
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

