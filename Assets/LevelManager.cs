using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log ("Loading level " + name);
		Application.LoadLevel(name);
	}
	
	public void BackToStart(){		
		Application.LoadLevel("Start");
	}
	
	public void Quit_Request(){
		Application.Quit();
	}
}
