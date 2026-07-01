using System;
using UnityEngine;

namespace ZStudio.UIMarquee {
    /// <summary>
    /// 跑马灯单条内容中的一个片段。一条 item 由若干片段按顺序水平排列组成，
    /// 从而支持「文本 + 图片 + spine」等任意组合。
    /// 通过 <see cref="IMarqueeSegmentRenderer"/> 渲染；核心库内置文本/图片，
    /// spine 等由外部扩展程序集提供并注册。
    /// </summary>
    [Serializable]
    public abstract class MarqueeSegment {
    }

    /// <summary>文本片段。</summary>
    [Serializable]
    public sealed class MarqueeTextSegment : MarqueeSegment {
        [Tooltip("文字内容")]
        public string text = "";

        public MarqueeTextSegment() {
        }

        public MarqueeTextSegment(string text) {
            this.text = text;
        }
    }

    /// <summary>图片片段。</summary>
    [Serializable]
    public sealed class MarqueeImageSegment : MarqueeSegment {
        public Sprite sprite;

        [Tooltip("显示尺寸（像素）；x 或 y 为 0 时使用 sprite 原始尺寸")]
        public Vector2 size = Vector2.zero;

        public MarqueeImageSegment() {
        }

        public MarqueeImageSegment(Sprite sprite) {
            this.sprite = sprite;
        }
    }
}
