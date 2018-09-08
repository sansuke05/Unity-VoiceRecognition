using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public InputField GetInput;
	public GameObject textMesh;

	public void WriteText(){
		textMesh.GetComponent<TextMesh>().text = GetInput.text;
		GetInput.text = null;
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
