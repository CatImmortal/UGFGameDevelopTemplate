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
    /// 播放声音失败事件。
    /// </summary>
    public sealed class PlaySoundFailureEventArgs : GameEventArgs
    {
        /// <summary>
        /// 播放声音失败事件编号。
        /// </summary>
        public static readonly int EventId = typeof(PlaySoundFailureEventArgs).GetHashCode();

        /// <summary>
        /// 获取播放声音失败事件编号。
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
        /// 获取声音组名称。
        /// </summary>
        public string SoundGroupName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取播放声音参数。
        /// </summary>
        public PlaySoundParams PlaySoundParams
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
        /// 获取错误码。
        /// </summary>
        public PlaySoundErrorCode ErrorCode
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取错误信息。
        /// </summary>
        public string ErrorMessage
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
        /// 清理播放声音失败事件。
        /// </summary>
        public override void Clear()
        {
            SerialId = default(int);
            SoundAssetName = default(string);
            SoundGroupName = default(string);
            PlaySoundParams = default(PlaySoundParams);
            BindingEntity = default(Entity);
            ErrorCode = default(int);
            ErrorMessage = default(string);
            UserData = default(object);
        }

        /// <summary>
        /// 填充播放声音失败事件。
        /// </summary>
        /// <param name="e">内部事件。</param>
        /// <returns>播放声音失败事件。</returns>
        public PlaySoundFailureEventArgs Fill(GameFramework.Sound.PlaySoundFailureEventArgs e)
        {
            PlaySoundInfo playSoundInfo = (PlaySoundInfo)e.UserData;
            SerialId = e.SerialId;
            SoundAssetName = e.SoundAssetName;
            SoundGroupName = e.SoundGroupName;
            PlaySoundParams = e.PlaySoundParams;
            BindingEntity = playSoundInfo.BindingEntity;
            ErrorCode = e.ErrorCode;
            ErrorMessage = e.ErrorMessage;
            UserData = playSoundInfo.UserData;

            return this;
        }
    }
}
