using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoOnce {
    public static void do_once(bool isDo_once) {
        if (isDo_once) {

            DataPool.isStop = true;
        }
    }
}
