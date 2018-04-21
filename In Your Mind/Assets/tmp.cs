using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class tmp : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    Flowchart flowchart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
	    Debug.Log("tmp:" + flowchart.HasBlock("onWin"));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
