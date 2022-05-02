﻿namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/spu/take_rate/sync 接口的响应。</para>
    /// </summary>
    public class POISPUTakeRateSyncV2Response : TikTokResponse<POISPUTakeRateSyncV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                /// <summary>
                /// 获取或设置 SPU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_id")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_id")]
                public string SPUId { get; set; } = default!;
            }
        }
    }
}
