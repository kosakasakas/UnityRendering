using UnityEngine;
using System.Collections;

using UnityChan;
public class SDunitychanGUIController : MonoBehaviour {

	// SDユニティちゃんオブジェクト
	private GameObject 	mUnityChanObject = null;

	// GUIを表示するか否か
	private bool		mEnableGUI = false;

	// Use this for initialization
	void Start () {
		GameObject  parent 	=  transform.parent.gameObject;
		mUnityChanObject 	= parent.transform.FindChild("SD_unitychan_humanoid_st").gameObject;
		Debug.Assert (mUnityChanObject != null, "missing unity chan!");

		SetGUIEnabled (mEnableGUI);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){
			mEnableGUI = !mEnableGUI;
		}
		SetGUIEnabled (mEnableGUI);
	}

	private void SetGUIEnabled (bool enabled) {
		if (mUnityChanObject) {
			mUnityChanObject.GetComponent<FaceUpdate> ().enabled 	= enabled;
			mUnityChanObject.GetComponent<IdleChanger> ().enabled	= enabled;
			mUnityChanObject.GetComponent<RandomWind> ().enabled 	= enabled;
		}
	}
}
