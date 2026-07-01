using System;
using Spine.Unity;
using UnityEngine;

namespace ZStudio.UIMarquee {
    /// <summary>
    /// spine 片段：在跑马灯条目中嵌入一个 <see cref="SkeletonGraphic"/> 动画。
    /// 属于可选扩展（UIMarquee.Spine 程序集），不影响核心库的零依赖。
    /// 由 <see cref="SpineSegmentRenderer"/> 渲染并在运行时自动注册。
    /// </summary>
    [Serializable]
    public sealed class SpineSegment : MarqueeSegment {
        [Tooltip("Spine 骨骼数据资产")]
        public SkeletonDataAsset skeletonDataAsset;

        [Tooltip("皮肤名（可选，留空使用默认皮肤）")]
        public string skinName = "";

        [Tooltip("初始播放动画名（可选）")]
        public string animationName = "";

        [Tooltip("动画是否循环")]
        public bool loop = true;

        [Tooltip("动画播放速度倍率")]
        public float timeScale = 1f;

        [Tooltip("骨骼整体缩放")]
        public float scale = 1f;

        [Tooltip("在跑马灯中占用的显示尺寸（像素，宽 × 高）。x 或 y 为 0 时自动读取骨骼 setup pose 的边界尺寸（同 ImageSegment 的行为）；若骨骼边界也为 0，则该分量保持 0。")]
        public Vector2 size = Vector2.zero;
    }
}
