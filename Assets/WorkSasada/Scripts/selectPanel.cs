using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectPanel : MonoBehaviour {

    int cnt = 0;
    float rate = 1.5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cnt++;

        if (cnt % 60 == 30)
        {
            selectPanelOn(rate);
        }
        else if (cnt % 60 == 0)
        {
            selectPanelOff(rate);
        }
    }

    // Update is called once per frame
    void selectPanelOn(float expandRate)
    {
        // expandrate

        this.transform.localScale = this.transform.localScale * expandRate;
        MeshRenderer meshrender = this.GetComponent<MeshRenderer>();
        this.GetComponent<MeshRenderer>().material.color = new Color(meshrender.material.color.r, meshrender.material.color.g, meshrender.material.color.b, 0.0f);
 //     Debug.Log(meshrender.material.color.ToString());
    }

    void selectPanelOff(float expandRate)
    {
        this.transform.localScale = this.transform.localScale / expandRate;
        MeshRenderer meshrender = this.GetComponent<MeshRenderer>();
        this.GetComponent<MeshRenderer>().material.color = new Color(meshrender.material.color.r, meshrender.material.color.g, meshrender.material.color.b, 1.0f);
        meshrender.material.color = new Color(meshrender.material.color.r, meshrender.material.color.g, meshrender.material.color.b, 1.0f);
    }
}
