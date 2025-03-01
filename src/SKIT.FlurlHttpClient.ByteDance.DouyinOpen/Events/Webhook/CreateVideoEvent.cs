﻿namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 create_video 事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/webhooks/event-list </para>
    /// </summary>
    public class CreateVideoEvent : DouyinOpenEvent<CreateVideoEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_id")]
                [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                public string ItemId { get; set; } = default!;

                /// <summary>
                /// 获取或设置分享 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_id")]
                [System.Text.Json.Serialization.JsonPropertyName("share_id")]
                public string ShareId { get; set; } = default!;
            }
        }
    }
}
