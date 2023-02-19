# unity_client_hotfix
## hybridclr 编译加载
## yooasset  资源加载
## fairygui  界面
## protobuf-net  协议
## luban 配置文件
## websocket 网络  https://github.com/James-Frowen/SimpleWebTransport

## manifest.json
修改 package/manifest.json
```
  "scopedRegistries": [
    {
      "name": "registry.npmjs.org",
      "url": "https://registry.npmjs.org",
      "scopes": [
        "io.nekonya",
        "com.fairygui.unity"
      ]
    },
    {
      "name": "package.openupm.com",
      "url": "https://package.openupm.cn",
      "scopes": [
        "com.cysharp.unitask",
        "com.neuecc.unirx",
        "com.tuyoogame.yooasset",
        "com.james-frowen",
        "com.focus-creative-games.hybridclr_unity"
      ]
    }
  ]
```




```
https://github.com/focus-creative-games/hybridclr_unity.git
https://gitee.com/focus-creative-games/hybridclr_unity.git
https://github.com/Cysharp/UniTask.git?path=src/UniTask/Assets/Plugins/UniTask
https://github.com/tuyoogame/YooAsset.git?path=Assets/YooAsset
```
