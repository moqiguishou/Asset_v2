using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;

public delegate int select_direction_delegate();
public class UIRoot : MonoBehaviour {
	GComponent main_comp;//主组件
	GComponent register_comp;//登录组件

	Controller select_option_ctrl;//登录界面-选择选项

	// Use this for initialization
	void Start () {
		comp_init ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp("w")) {
			register_select_option (up_select);
		}

		if (Input.GetKeyUp("s")) {
			register_select_option (down_select);
		}
	}
	//******************************************************************
	private void comp_init(){
		UIPackage.AddPackage ("UI/TankFight");
		main_comp = UIPackage.CreateObject ("TankFight", "main").asCom;
		GRoot.inst.AddChild (main_comp);

		register_comp 		= main_comp.GetChild ("register").asCom;
		select_option_ctrl 	= register_comp.GetController ("select_option");
	}


	//*****************************************************************
	private void register_select_option(select_direction_delegate select_direction){
		select_option_ctrl.selectedIndex = select_direction ();
	}

	private int up_select(){
		if (select_option_ctrl.selectedIndex == 0) {
			return 2;
		}
		return select_option_ctrl.selectedIndex - 1;
	}

	private int down_select(){
		if (select_option_ctrl.selectedIndex == 2) {
			return 0;
		}
		return select_option_ctrl.selectedIndex + 1;
	}
}
