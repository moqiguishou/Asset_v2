using System.Collections;
using System.Collections.Generic;

public class DataPool{
    public static Dictionary<string, bool> DATA_DO_ONCE = new Dictionary<string, bool>();

    public static bool isStop = false;

    public static bool isAble_select = false;

    //********************************************************************//

    private static Dictionary<int, string> DATA_POOL = new Dictionary<int, string>();
    

    public void init_DataPool() {
        DataPool.DATA_DO_ONCE = new Dictionary<string, bool>();
        DataPool.isStop = false;
        DataPool.isAble_select = false;
    }

    public void init_DataPool(string oper_name, string new_value)
    {
        
    }
}

//public class Oper_DataPool {
//    public void set_DATA_DO_ONCE(Dictionary<string, bool> new_DATA_DO_ONCE) {
//        DataPool.DATA_DO_ONCE = new_DATA_DO_ONCE;
//    }
//}