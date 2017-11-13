using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;

public class UIRoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UIPackage.AddPackage ("UI/TankFight");
		GComponent comp = UIPackage.CreateObject ("TankFight", "main").asCom;
		GRoot.inst.AddChild (comp);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
