using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01
{
    public static void hello()
    {
        Debug.Log("static method hello");
    }

    public void hello2()
    {
        Debug.Log("model method hello2");
    }

    public void hello3(string s)
    {
        Debug.Log("hello3 + " + s);
    }

    public string hello4()
    {
        string res = "hello4";
        Debug.Log(res);
        return res;
    }

}
