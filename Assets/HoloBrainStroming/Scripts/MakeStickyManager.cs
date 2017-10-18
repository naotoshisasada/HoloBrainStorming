using HoloToolkit.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System;
using UnityEngine.UI;

public class MakeStickyManager : Singleton<MakeStickyManager>
{
    public DictationRecognizer m_DictationRecognizer;
    public GameObject HoloSticky;
    public GameObject FukidashiUI;
    private List<GameObject> stickyList = new List<GameObject>();

    // Use this for initialization
    void Start () {
        m_DictationRecognizer = new DictationRecognizer();
        m_DictationRecognizer.InitialSilenceTimeoutSeconds = 30f;
        m_DictationRecognizer.DictationResult += (text, confidence) =>
        {
            
            MakeSticky(text);
        };
        m_DictationRecognizer.Start();
    }

    public void MakeSticky(string text)
    {
        GameObject Sticky = GameObject.Instantiate(HoloSticky);
        Sticky.transform.transform.Find("Text").GetComponent<Text>().text = text;
        stickyList.Add(Sticky);
        Sticky.transform.parent = FukidashiUI.transform;
        Sticky.transform.localPosition = new Vector3(0f, -8f - stickyList.Count * 10, 0f);
        Sticky.transform.localScale = new Vector3(0.148f, 0.148f, 0.148f);


    }

    // Update is called once per frame
    void Update () {
		
	}
}
