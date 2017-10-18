using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class InputStickyText : MonoBehaviour ,IFocusable{

    public GameObject XPic;
    public void OnFocusEnter()
    {
        //MakeStickyManager.Instance.m_DictationRecognizer.Start();
        XPic.SetActive(false);
    }

    public void OnFocusExit()
    {
        //MakeStickyManager.Instance.m_DictationRecognizer.Stop();
        XPic.SetActive(true);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
