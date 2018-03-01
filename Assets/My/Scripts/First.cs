using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class First : MonoBehaviour {

    private LuaEnv luaenv;

    public delegate void lua_func(int x,int y);

	void Start () {
        luaenv = new LuaEnv();
        //---执行字符串
        //luaenv.DoString("print('first')");
        //---执行lua文件，文件需要放置在resources下，并且以.lua.txt结尾
        //luaenv.DoString("require 'luamain'");
        /////////////////////////////////c# call lua////////////////////////////
        //---获取lua虚拟机中的全局变量
        //Debug.Log("gloabl val int_val is " + luaenv.Global.Get<int>("int_val"));
        //Debug.Log("gloabl val string_val is " + luaenv.Global.Get<string>("string_val"));
        //Debug.Log("gloabl val bool_val is " + luaenv.Global.Get<bool>("bool_val"));
        //获取table,使用类或结构体
        //---tab_class tab_val = luaenv.Global.Get<tab_class>("tab_val");
        //Debug.Log("tab_val:val1=" + tab_val.val1 + ";val2=" + tab_val.val2);
        //---获取全局函数
        //delegate
        //lua_func func = luaenv.Global.Get<lua_func>("lua_func");
        //func(1, 2);
        //luafunction
        //LuaFunction func2 = luaenv.Global.Get<LuaFunction>("lua_func");
        //func2.Call(3, 4);

        /////////////////////////////////lua call c#////////////////////////////

    }

    private void OnDestroy()
    {
        luaenv.Dispose();
    }

}
public class tab_class
{
    public int val1;
    public int val2;
}
