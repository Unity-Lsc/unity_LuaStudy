using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

/// <summary>
/// xLua管理类
/// </summary>
public class xLuaManager : UnitySingleton<xLuaManager>
{
    public const string LuaScriptsFolder = "LuaScripts";//lua代码的文件夹

    private LuaEnv mLuaEnv = null;

    public override void Awake() {
        base.Awake();
    }

    /// <summary>
    /// xLuaManager 初始化
    /// </summary>
    public void Init() {
        mLuaEnv = new LuaEnv();
    }

    /// <summary>
    /// 进入游戏
    /// </summary>
    public void EnterLuaGame() {

    }

    // require(main); // require(game.game_start)
    public static byte[] CustomLoader(ref string filePath) {
        string scriptPath = string.Empty;
        filePath = filePath.Replace(".", "/") + ".lua"; // game/game_start.lua
#if UNITY_EDITOR
        // if (AssetBundleConfig.IsEditorMode)
        {
            scriptPath = Path.Combine(Application.dataPath, LuaScriptsFolder);// Assets/LuaScripts
            scriptPath = Path.Combine(scriptPath, filePath); // Assets/LuaScripts/game/game_start.lua

            // Debug.Log("Custom Load lua script : " + scriptPath);
            return GameUtility.SafeReadAllBytes(scriptPath);
        }
#endif

        /*scriptPath = string.Format("{0}/{1}.bytes", luaAssetbundleAssetName, filePath);
        string assetbundleName = null;
        string assetName = null;

        bool status = AssetBundleManager.Instance.MapAssetPath(scriptPath, out assetbundleName, out assetName);
        if (!status)
        {
            Debug.LogError("MapAssetPath failed : " + scriptPath);
            return null;
        }

        var asset = AssetBundleManager.Instance.GetAssetCache(assetName) as TextAsset;
        if (asset != null)
        {
            return asset.bytes;
        }
        Debug.LogError("Load lua script failed : " + scriptPath + ", You should preload lua assetbundle first!!!");
        return null;
        */

    }

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
