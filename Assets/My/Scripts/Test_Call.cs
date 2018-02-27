using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class Test_Call : MonoBehaviour {

    LuaEnv luaenv;

	// Use this for initialization
	void Start () {
        luaenv = new LuaEnv();
        luaenv.DoString("require 'hellolua'");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
[XLua.LuaCallCSharp]
public class CallClass
{
    public void test()
    {
        Debug.Log("this is CallClass test");
    }
}
