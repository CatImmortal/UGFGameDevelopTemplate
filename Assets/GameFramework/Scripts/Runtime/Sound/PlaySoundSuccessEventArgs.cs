﻿//------------------------------------------------------------
// Game Framework v3.x
// Copyright © 2013-2018 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using GameFramework.Event;
using GameFramework.Sound;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 播放声音成功事件。
    /// </summary>
    public sealed class PlaySoundSuccessEventArgs : GameEventArgs
    {
        /// <summary>
        /// 播放声音成功事件编号。
        /// </summary>
        public static readonly int EventId = typeof(PlaySoundSuccessEventArgs).GetHashCode();

        /// <summary>
        /// 获取播放声音成功事件编号。
        /// </summary>
        public override int Id
        {
            get
            {
                return EventId;
            }
        }

        /// <summary>
        /// 获取声音的序列编号。
        /// </summary>
        public int SerialId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取声音资源名称。
        /// </summary>
        public string SoundAssetName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取用于播放的声音代理。
        /// </summary>
        public ISoundAgent SoundAgent
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
        /// 获取声音绑定的实体。
        /// </summary>
        public Entity BindingEntity
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
        /// 清理播放声音成功事件。
        /// </summary>
        public override void Clear()
        {
            SerialId = default(int);
            SoundAssetName = default(string);
            SoundAgent = default(ISoundAgent);
            Duration = default(float);
            BindingEntity = default(Entity);
            UserData = default(object);
        }

        /// <summary>
        /// 填充播放声音成功事件。
        /// </summary>
        /// <param name="e">内部事件。</param>
        /// <returns>播放声音成功事件。</returns>
        public PlaySoundSuccessEventArgs Fill(GameFramework.Sound.PlaySoundSuccessEventArgs e)
        {
            PlaySoundInfo playSoundInfo = (PlaySoundInfo)e.UserData;
            SerialId = e.SerialId;
            SoundAssetName = e.SoundAssetName;
            SoundAgent = e.SoundAgent;
            Duration = e.Duration;
            BindingEntity = playSoundInfo.BindingEntity;
            UserData = playSoundInfo.UserData;

            return this;
        }
    }
}
