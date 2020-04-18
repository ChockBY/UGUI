using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewManger : MonoBehaviour {

    private Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        text.text = "必须得完善一下";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
