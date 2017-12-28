using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void pNull_rNull_delegate(string str);
//public delegate void pNull_rNull_delegate();
public delegate object pNull_ret_delegate();
//public delegate void pNull_rNull_delegate();
public class DoOnce {
	Dictionary<string, bool> do_func_times = new Dictionary<string, bool>();
	Logger logger = new Logger();
	
	private bool isFuncDone (string func_name)
	{
		if (do_func_times.ContainsKey (func_name)) {
			if (do_func_times [func_name]) {
				return true;
			} else {
				return false;
			}
		} else {
			return false;
		}
	}

	private void print_log (string func_name){
		logger.warn("[Function][DoOnce]:" + func_name + "() has been taken");
		logger.warn("[Table][DoFuncTimes]:"+func_name+"() join in the table DoFuncTimes");
	}

	public void func (pNull_rNull_delegate func, string func_name, string str)
	{
		if (!isFuncDone (func_name)) {
			func(str);
			do_func_times.Add(func_name, true);
			print_log(func_name);
		}
	}
	
	public void func (pNull_rNull_delegate func, string func_name, bool isParam, object []param, int param_num)
	{
		if (!isFuncDone (func_name)) {
			//func();
			do_func_times.Add(func_name, true);
			print_log(func_name);
		}
	}
}
