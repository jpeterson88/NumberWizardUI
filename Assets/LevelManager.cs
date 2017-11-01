using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log ("Level load requested for " + name);
	}
	
	public void Quit_Request(){
		Debug.Log ("Quit Requested");
	}
}
