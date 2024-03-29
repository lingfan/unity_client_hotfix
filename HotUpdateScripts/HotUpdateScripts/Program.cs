﻿using UnityEngine;

namespace HotUpdateScripts
{
    public static class Program
    {
        public static void SetupGame()
        {
            Debug.Log("<color=cyan>[SetupGame] 这个周期在ClassBind初始化之前，可以对游戏数据进行一些初始化</color>");
            //防止Task内的报错找不到堆栈，不建议删下面的代码
            System.Threading.Tasks.TaskScheduler.UnobservedTaskException += (sender, e) =>
            {
                foreach (var innerEx in e.Exception.InnerExceptions)
                {
                    Debug.LogError($"{innerEx.Message}\n" +
                                   $"ILRuntime StackTrace: {innerEx.Data["StackTrace"]}\n\n" +
                                   $"Full Stacktrace: {innerEx.StackTrace}");
                }
            };
        }

        public static void RunGame()
        {
            Debug.Log("<color=yellow>[RunGame] 这个周期在ClassBind初始化后，可以激活游戏相关逻辑</color>");
            //如果生成热更解决方案跳过，参考https://docs.xgamedev.net/zh/documents/0.7/FAQ.html#生成热更工程dll跳过
            //的方法一，把生成的平台改成Any CPU（默认是小写的，windows下无法生成）
        }
    }
}