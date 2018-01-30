using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class TestLua01 : MonoBehaviour
{

    LuaEnv env = new LuaEnv();
	void Start ()
    {
        env.DoString(@"

            local luaM2 = CS.Test01
            local luaO2 = luaM2()
            luaM2:hello()
            luaO2:hello2()
            luaO2:hello3('stone')            

            local value = luaO2:hello4('lua')
            print(value)
        ");

	}
	
}
