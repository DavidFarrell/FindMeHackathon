using UnityEngine;
using System.Collections;
using HutongGames.PlayMaker;

public class PR_Impact: MonoBehaviour {
	
	
	public int improve_PR;
	public bool has_been_enabled = false; 
	
	
	// Use this for initialization
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("calling impact police update and has been is " + has_been_enabled);
		if (!has_been_enabled){
			
			has_been_enabled = true;
			
			Debug.Log("calling impact police update and has been is " + has_been_enabled);
			FsmInt myInt = FsmVariables.GlobalVariables.GetFsmInt("time_left");
			myInt.Value = myInt.Value + improve_PR;
		}
	}
	
	
}
