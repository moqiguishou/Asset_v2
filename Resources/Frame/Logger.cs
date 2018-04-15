using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger {

	public void log (string str){
		Debug.Log(str);
        
	}

    //日志封装函数
    //params: func_name: 调用执行的函数名；
    //        num_param: 该函数的参数数量；
    //        string[] param_key: 参数名+参数值的集合；(参数值以string形式保存)
    //打印出封装日志（Func<param1 = param1, param2 = param2>）
    public void log_func(string func_name, int num_param, params string[] my_param)
    {
        string str = "";
        str = str + "<color=#a52a2aff>" + func_name + "</color>" + "<";
        if (num_param != 0) {
            int flag = 0;
            string[] param_key = new string[num_param];
            string[] param_value = new string[num_param];
            foreach (string s in my_param) {
                if (flag < num_param)
                {
                    param_key[flag] = s;
                }
                else {
                    param_value[flag - num_param] = s;
                }
                flag++;
            }
            for (int i = 0; i < num_param; i++) {
                str = str + "<color=#a52a2aff>" + param_key[i] + "</color>" + " = " + param_value[i];
                if (i != num_param - 1) {
                    str = str + ", ";
                }
            }
            str = str + ">";
        }
        else {
            str = str + ">";
        }
        Debug.Log(str);
    }

    public void debug (string str){
		Debug.Log("<color=#0000ffff>" + str + "</color>");
        //蓝色
	}
	
	public void warn (string str){
		Debug.Log("<color=#ffa500ff>" + str + "</color>");
        //橙黄色
	}

	public void error (string str){
		Debug.Log("<color=#ff0000ff>" + str + "</color>");
        //红色
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
