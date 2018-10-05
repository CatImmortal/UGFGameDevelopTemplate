﻿//------------------------------------------------------------
// Game Framework v3.x
// Copyright © 2013-2018 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using GameFramework.Event;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 加载字典成功事件。
    /// </summary>
    public sealed class LoadDictionarySuccessEventArgs : GameEventArgs
    {
        /// <summary>
        /// 加载字典成功事件编号。
        /// </summary>
        public static readonly int EventId = typeof(LoadDictionarySuccessEventArgs).GetHashCode();

        /// <summary>
        /// 获取加载字典成功事件编号。
        /// </summary>
        public override int Id
        {
            get
            {
                return EventId;
            }
        }

        /// <summary>
        /// 获取字典名称。
        /// </summary>
        public string DictionaryName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取字典资源名称。
        /// </summary>
        public string DictionaryAssetName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取加载持续时间。
        /// </summary>
        public float Duration
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取用户自定义数据。
        /// </summary>
        public object UserData
        {
            get;
            private set;
        }

        /// <summary>
        /// 清理加载字典成功事件。
        /// </summary>
        public override void Clear()
        {
            DictionaryName = default(string);
            DictionaryAssetName = default(string);
            Duration = default(float);
            UserData = default(object);
        }

        /// <summary>
        /// 填充加载字典成功事件。
        /// </summary>
        /// <param name="e">内部事件。</param>
        /// <returns>加载字典成功事件。</returns>
        public LoadDictionarySuccessEventArgs Fill(GameFramework.Localization.LoadDictionarySuccessEventArgs e)
        {
            LoadDictionaryInfo loadDictionaryInfo = (LoadDictionaryInfo)e.UserData;
            DictionaryName = loadDictionaryInfo.DictionaryName;
            DictionaryAssetName = e.DictionaryAssetName;
            Duration = e.Duration;
            UserData = loadDictionaryInfo.UserData;

            return this;
        }
    }
}
