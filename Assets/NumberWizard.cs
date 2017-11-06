using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	
	private int max, min, guess, maxGuessesAllowed;
	
	public Text text;
	
	public void Start () {
		max = 1001;
		min = 1;
		maxGuessesAllowed = 5;	
		guess = 500;
	}	

	public void GuessHigher(){
		min = guess;
		nextGuess();
	}
	
	public void GuessLower(){
		max = guess;
		nextGuess();
	}	
	
	private void nextGuess(){		
		guess = Random.Range(min, max);
		
		maxGuessesAllowed -= 1;
		
		text.text = guess.ToString();
		
		 if(maxGuessesAllowed <= 0){
		 	Application.LoadLevel("Lose");
		 } 
	}
}
