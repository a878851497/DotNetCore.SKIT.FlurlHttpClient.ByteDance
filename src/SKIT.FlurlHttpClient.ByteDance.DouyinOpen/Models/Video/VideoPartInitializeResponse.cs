namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/video/init_video_part_upload 接口的响应。</para>
    /// </summary>
    public class VideoPartInitializeResponse : DouyinOpenResponse<VideoPartInitializeResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置上传 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("upload_id")]
                [System.Text.Json.Serialization.JsonPropertyName("upload_id")]
                public string UploadId { get; set; } = default!;
            }
        }
    }
}
