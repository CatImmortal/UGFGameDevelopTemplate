﻿//------------------------------------------------------------
// Game Framework v3.x
// Copyright © 2013-2018 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using GameFramework.Resource;
using System;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 加载资源代理辅助器基类。
    /// </summary>
    public abstract class LoadResourceAgentHelperBase : MonoBehaviour, ILoadResourceAgentHelper
    {
        /// <summary>
        /// 加载资源代理辅助器异步加载资源更新事件。
        /// </summary>
        public abstract event EventHandler<LoadResourceAgentHelperUpdateEventArgs> LoadResourceAgentHelperUpdate;

        /// <summary>
        /// 加载资源代理辅助器异步读取资源文件完成事件。
        /// </summary>
        public abstract event EventHandler<LoadResourceAgentHelperReadFileCompleteEventArgs> LoadResourceAgentHelperReadFileComplete;

        /// <summary>
        /// 加载资源代理辅助器异步读取资源二进制流完成事件。
        /// </summary>
        public abstract event EventHandler<LoadResourceAgentHelperReadBytesCompleteEventArgs> LoadResourceAgentHelperReadBytesComplete;

        /// <summary>
        /// 加载资源代理辅助器异步将资源二进制流转换为加载对象完成事件。
        /// </summary>
        public abstract event EventHandler<LoadResourceAgentHelperParseBytesCompleteEventArgs> LoadResourceAgentHelperParseBytesComplete;

        /// <summary>
        /// 加载资源代理辅助器异步加载资源完成事件。
        /// </summary>
        public abstract event EventHandler<LoadResourceAgentHelperLoadCompleteEventArgs> LoadResourceAgentHelperLoadComplete;

        /// <summary>
        /// 加载资源代理辅助器错误事件。
        /// </summary>
        public abstract event EventHandler<LoadResourceAgentHelperErrorEventArgs> LoadResourceAgentHelperError;

        /// <summary>
        /// 通过加载资源代理辅助器开始异步读取资源文件。
        /// </summary>
        /// <param name="fullPath">要加载资源的完整路径名。</param>
        public abstract void ReadFile(string fullPath);

        /// <summary>
        /// 通过加载资源代理辅助器开始异步读取资源二进制流。
        /// </summary>
        /// <param name="fullPath">要加载资源的完整路径名。</param>
        /// <param name="loadType">资源加载方式。</param>
        public abstract void ReadBytes(string fullPath, int loadType);

        /// <summary>
        /// 通过加载资源代理辅助器开始异步将资源二进制流转换为加载对象。
        /// </summary>
        /// <param name="bytes">要加载资源的二进制流。</param>
        public abstract void ParseBytes(byte[] bytes);

        /// <summary>
        /// 通过加载资源代理辅助器开始异步加载资源。
        /// </summary>
        /// <param name="resource">资源。</param>
        /// <param name="resourceChildName">要加载的子资源名。</param>
        /// <param name="assetType">要加载资源的类型。</param>
        /// <param name="isScene">要加载的资源是否是场景。</param>
        public abstract void LoadAsset(object resource, string resourceChildName, Type assetType, bool isScene);

        /// <summary>
        /// 重置加载资源代理辅助器。
        /// </summary>
        public abstract void Reset();
    }
}
