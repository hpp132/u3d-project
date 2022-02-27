using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class playerMove : MonoBehaviour
{

    private LuaEnv luaenv;
    // Start is called before the first frame update
    void Start()
    {
        print("hello world c# to lua");
        luaenv = new LuaEnv();

        //luaenv.DoString("print('测试 luaenv')");

    }

    private void OnDestroy()
    {
        luaenv.Dispose();
    }
}
