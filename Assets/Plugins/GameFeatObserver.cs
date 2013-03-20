using UnityEngine;
using System.Collections;

public class  GameFeatObserver : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		AndroidJavaClass plugin = new AndroidJavaClass("jp.basicinc.gamefeat.android.sdk.controller.GameFeatAppController");
		AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
		plugin.CallStatic("show", activity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}