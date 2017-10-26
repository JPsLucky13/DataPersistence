using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserApi : MonoBehaviour {
	
	public delegate void CallbackFunction();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void GetNewUser(CallbackFunction callback){
		StartCoroutine(GetUserData(callback));		
	}
	
	private IEnumerator GetUserData(CallbackFunction callback){
		WWW www = new WWW("https://randomuser.me/api");
		yield return www;
		string returnString = www.text;
		Debug.Log(returnString);
	}
}
