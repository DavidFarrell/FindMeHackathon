using UnityEngine;
using System.Collections;
using HutongGames.PlayMaker;

public class impact_police : MonoBehaviour {


	public float improve_chance;
	public int cost_time;
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
			FsmFloat myFloat = FsmVariables.GlobalVariables.GetFsmFloat("search_chance");
			myFloat.Value = myFloat.Value + improve_chance;

			FsmInt myInt = FsmVariables.GlobalVariables.GetFsmInt("time_left");
			myInt.Value = myInt.Value - cost_time;
		}
	}


}
