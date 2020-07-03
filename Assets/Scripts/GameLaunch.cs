using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 游戏启动脚本
/// </summary>
public class GameLaunch : MonoBehaviour
{

    private void Awake() {
        //初始化框架

        gameObject.AddComponent<show_fps>();
        gameObject.AddComponent<xLuaManager>();


        xLuaManager.Instance.Init();
        //end
    }

    void Start()
    {
        //进入启动逻辑

        xLuaManager.Instance.EnterLuaGame();

        //end
    }
    
    void Update()
    {
        
    }
}
