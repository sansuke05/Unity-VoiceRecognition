using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechToText : MonoBehaviour {

	private PXCMSession session;
	private PXCMAudioSource source;
	private PXCMSpeechRecognition sr;
	private PXCMSpeechRecognition.Handler handler;

	TextController controller;
	public GameObject textMesh;


	// Use this for initialization
	void Start () {
		// テキストを渡すスクリプトの参照
		textMesh = GameObject.Find("Word");
		controller = textMesh.GetComponent<TextController>();

		// 音声認識セッションの初期化
		session = PXCMSession.CreateInstance();
		source = session.CreateAudioSource();

		PXCMAudioSource.DeviceInfo dinfo = null;

		source.QueryDeviceInfo(1, out dinfo);
		source.SetDevice(dinfo);
		Debug.Log(dinfo.name);

		session.CreateImpl<PXCMSpeechRecognition>(out sr);

		PXCMSpeechRecognition.ProfileInfo pinfo;
		sr.QueryProfile(out pinfo);
		pinfo.language = PXCMSpeechRecognition.LanguageType.LANGUAGE_JP_JAPANESE;
		sr.SetProfile(pinfo);

		handler = new PXCMSpeechRecognition.Handler();
		handler.onRecognition = (x) => controller.SetText(x.scores[0].sentence);
		sr.SetDictation();
		sr.StartRec(source, handler);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDisable() {
		if(sr != null){
			sr.StopRec();
			sr.Dispose();
		}

		if(session != null){
			session.Dispose();
		}
	}
}
