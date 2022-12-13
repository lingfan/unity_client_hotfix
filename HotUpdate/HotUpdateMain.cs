using System;
using HybridCLR;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using FairyGUI;
using FGUI.Loading;
using FGUI.Lobby;
using ProtoBuf;
using UnityEngine;
using TinaX; //XCore来自该命名空间
using TinaX.Services;
using YooAsset;

public class HotUpdateMain : MonoBehaviour
{
    public string text;
    private AssetsPackage defaultPackage;

    async void Start()
    {
        BetterStreamingAssets.Initialize();

        var core = XCore.New();

        await core.RunAsync();

//或使用回调方式：
        core.RunAsync(err =>
        {
            if (err != null)
            {
                Debug.LogError(err.Message);
            }
            else
            {
                Debug.Log("TinaX 启动完成");
            }
        });

        Debug.Log("这个热更新脚本挂载在prefab上，打包成ab。通过从ab中实例化prefab成功还原");
        Debug.LogFormat("hello, {0}.", text);

        gameObject.AddComponent<CreateByCode>();
        gameObject.AddComponent<wsclient>();

        Debug.Log("=======看到此条日志代表你成功运行了示例项目的热更新代码=======");


        StartCoroutine(InitializeYooAsset());
        // StartCoroutine(UpdateStaticVersion());
        // StartCoroutine(UpdatePatchManifest());
        Debug.Log("=====InitializeYooAsset=====");
    }

    private void OnEnable()
    {
    }


    private IEnumerator InitializeYooAsset()
    {
        
        // 初始化资源系统
        YooAssets.Initialize();

        // 创建默认的资源包
        var defaultPackage = YooAssets.CreateAssetsPackage("FGUI");

        // 设置该资源包为默认的资源包，可以使用YooAssets相关加载接口加载该资源包内容。
        YooAssets.SetDefaultAssetsPackage(defaultPackage);

        var initParameters = new HostPlayModeParameters();
        initParameters.QueryServices = new QueryStreamingAssetsFileServices();

        initParameters.DefaultHostServer = "http://192.168.1.110:8090/Android/100";
        initParameters.FallbackHostServer = "http://192.168.1.110:8090/Android/100";
        yield return defaultPackage.InitializeAsync(initParameters);

        // var package = YooAssets.GetAssetsPackage("FGUI");
        var operation = defaultPackage.UpdatePackageVersionAsync();
        yield return operation;

        if (operation.Status == EOperationStatus.Succeed)
        {
            //更新成功
            string PackageVersion = operation.PackageVersion;
            Debug.Log($"Updated package Version : {PackageVersion}");
            aaa();
        }
        else
        {
            //更新失败
            Debug.LogError(operation.Error);
        }
    }


    public async Task LoadAssetAsync()
    {
        var Loading = YooAssets.LoadAssetAsync<TextAsset>("Assets/HotRes/FGUI/Loading_fui");
        await Loading.Task;
        UIPackage.AddPackage(Loading.GetAssetObject<TextAsset>().bytes, "Loading", LoadPackageInternalAsync);
        
        var Lobby = YooAssets.LoadAssetAsync<TextAsset>("Assets/HotRes/FGUI/Lobby_fui");
        await Lobby.Task;
        UIPackage.AddPackage(Lobby.GetAssetObject<TextAsset>().bytes, "Lobby", LoadPackageInternalAsync);
        
        LoadingBinder.BindAll();
        LobbyBinder.BindAll();
        
        var ui = UI_Lobby.CreateInstance();
        var view = ui.asCom;
        view.SetSize(GRoot.inst.size.x, GRoot.inst.size.y);
        GRoot.inst.AddChild(view);
    }

    private async void LoadPackageInternalAsync(string name, string extension, System.Type type, PackageItem item)
    {
        var texture = YooAssets.LoadAssetAsync<Texture>("Assets/HotRes/FGUI/" + name);
        await texture.Task;
        item.owner.SetItemAsset(item, texture.GetAssetObject<Texture>(), DestroyMethod.Unload);
    }
    
    // 内置文件查询服务类
    private class QueryStreamingAssetsFileServices : IQueryServices
    {
        public bool QueryStreamingAssets(string fileName)
        {
            // 注意：使用了BetterStreamingAssets插件，使用前需要初始化该插件！
            string buildinFolderName = YooAssets.GetStreamingAssetBuildinFolderName();
            return BetterStreamingAssets.FileExists($"{buildinFolderName}/{fileName}");
        }
        
        // ArgumentNullException: Value cannot be null.
        // Parameter name: array
        //
        //HotUpdateMain+QueryStreamingAssetsFileServices.QueryStreamingAssets (System.String fileName) (at <00000000000000000000000000000000>:0)
        //HotUpdateMain.LoadAssetAsync () (at <00000000000000000000000000000000>:0)
        //System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[TStateMachine] (TStateMachine& stateMachine) (at <00000000000000000000000000000000>:0)
        //     
    }

    public async void aaa()
    {
        await  LoadAssetAsync();;
    }

    private IEnumerator UpdateStaticVersion()
    {
        var package = YooAssets.GetAssetsPackage("FGUI");
        var operation = package.UpdatePackageVersionAsync();
        yield return operation;

        if (operation.Status == EOperationStatus.Succeed)
        {
            //更新成功
            string PackageVersion = operation.PackageVersion;
            Debug.Log($"Updated package Version : {PackageVersion}");
        }
        else
        {
            //更新失败
            Debug.LogError(operation.Error);
        }
    }

    private IEnumerator UpdatePatchManifest()
    {
        var package = YooAssets.GetAssetsPackage("FGUI");
        var operation = package.UpdatePackageManifestAsync("100");
        yield return operation;

        if (operation.Status == EOperationStatus.Succeed)
        {
            //更新成功
        }
        else
        {
            //更新失败
            Debug.LogError(operation.Error);
        }
    }
}