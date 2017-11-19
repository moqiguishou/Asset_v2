using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger {
	public void log (string str){
		Debug.Log(str);
	}
	
	public void debug (string str){
		Debug.Log("<color=#0000ffff>" + str + "</color>");
	}
	
	public void warn (string str){
		Debug.Log("<color=#ffa500ff>" + str + "</color>");
	}

	public void error (string str){
		Debug.Log("<color=#ff0000ff>" + str + "</color>");
	}
	//***************************************************//
	public void error1 (string str){
		Debug.Log("<color=#00ff00ff>" + "青橙绿" + "</color>");
	}
	public void error11 (string str){
		Debug.Log("<color=#800080ff>" + "紫色" + "</color>");
	}
	public void error111 (string str){
		Debug.Log("<color=#ffff00ff>" + "黄色" + "</color>");
	}
	public void error2 (string str){
		Debug.Log("<color=#00ffffff	>" + "青色" + "</color>");
	}
	public void error22 (string str){
		Debug.Log("<color=#a52a2aff>" + "棕色" + "</color>");
	}
	public void error222 (string str){
		Debug.Log("<color=#ff00ffff>" + "洋红" + "</color>");
	}
	public void error3 (string str){
		Debug.Log("<color=#add8e6ff>" + "浅蓝" + "</color>");
	}
}
