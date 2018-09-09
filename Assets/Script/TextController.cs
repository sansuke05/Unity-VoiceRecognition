using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public GameObject textMesh;

	private string text = "Hello";

	public void SetText(string text){
		this.text = text;
	}

	public void WriteText(){
		textMesh.GetComponent<TextMesh>().text = this.text;
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		WriteText();
	}
}
