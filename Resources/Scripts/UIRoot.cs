﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FairyGUI;

public delegate void my_delegate_no_param();
public delegate void my_delegate(object str);
//public delegate object my_delegate_return_object(string param, string param_type);
public class UIRoot : MonoBehaviour {
	GComponent main_comp;//主组件
	GComponent bg_comp;//背景组件
	GComponent login_comp;//登录组件

	Controller insert_bg;//主界面-背景图上升
	Controller select_option_ctrl;//登录界面-选择选项
	Controller select_tank;//登录界面-选择坦克
	//**********************************************
	Dictionary<string, bool> times = new Dictionary<string, bool>();
	Logger logger = new Logger();
	
	bool isable_select = false;
	//**********************************************
	// Use this for initialization
	void Start () {
		comp_init ();
		select_tank.selectedIndex = 1;
		insert_bg.selectedIndex = 1;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (bg_comp.position.y == 0) {
			isable_select = true;
		}
		
		if (Input.GetKeyUp ("w")) {
			register_select_option (up_select);
		}

		if (Input.GetKeyUp ("s")) {
			register_select_option (down_select);
		}

		if (Input.GetMouseButtonDown (1)) {
			main_comp.Dispose ();
			SceneManager.LoadScene (1);
		}
		if (times.ContainsKey("bb")) {
			//Debug.Log("ooo=================================");
		}
	}
	//******************************************************************
	private void comp_init(){
		UIPackage.AddPackage ("UI/TankFight");
		main_comp = UIPackage.CreateObject ("TankFight", "main").asCom;
		GRoot.inst.AddChild (main_comp);

		insert_bg = main_comp.GetController("insert_bg");
		bg_comp   = main_comp.GetChild("background").asCom;
		login_comp 	      = bg_comp.GetChild ("login").asCom;
		select_option_ctrl 	= login_comp.GetController ("select_option");
		select_tank         = login_comp.GetController ("select_tank");
	}

	private void up_select ()
	{
		if (select_option_ctrl.selectedIndex == 0) {
			select_option_ctrl.selectedIndex = 2;
		} else {
			select_option_ctrl.selectedIndex -= 1;
		}
	}

	private void down_select ()
	{
		if (select_option_ctrl.selectedIndex == 2) {
			select_option_ctrl.selectedIndex = 0;
		} else {
			select_option_ctrl.selectedIndex += 1;
		}
	}
	
	private void table_times_add (string key){
		times.Add (key, true);
		logger.warn ("[Function][do_once]:" + key + "be done once and has been a member in table 'times'");
	}
//	private bool is_times (string key){
//		return true;
//	}

	//delegate*****************************************************************
	private void register_select_option(my_delegate_no_param select_direction){
		select_direction ();
	}

	private void do_once (my_delegate func, string key, bool is_param, string param, string param_type)
	{
		bool ret = true;
		if (times.ContainsKey (key) && times [key]) {
			return;
		}
		switch (param_type) {
		case "s":
			func (param);
			table_times_add(key);
			break;
		case "n":
			int param_n;
			ret = int.TryParse (param, out param_n);
			if (ret) {
				func(param_n);
				table_times_add(key);
			}
			break;
		}
	}
}
