﻿#region Copyright (C) 2017   Kevin   （OS系列开源项目）

/***************************************************************************
*　　	文件功能描述: 公号素材管理实体Mo
*
*　　	创建人： Kevin
*       创建人Email：1985088337@qq.com
*    	创建日期：2017-1-16
*       
*****************************************************************************/

#endregion

using System.IO;

namespace OS.Social.WX.Offcial.Basic.Mos
{

    /// <summary>
    /// 上传素材请求参数
    /// </summary>
    public class WxMediaUploadReq
    {
        /// <summary>
        /// 素材类型
        /// </summary>
        public MediaType type { get; set; }

        /// <summary>
        /// 上传文件的formdata中name，如：file
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// formdata中的文件名称  如：my_photo_20170116.jpg
        /// </summary>
        public string file_name { get; set; }

        /// <summary>
        ///  请求中的contentteype
        /// </summary>
        public string content_type { get; set; }

        /// <summary>
        ///   文件的流，调用方会自动调用Dispose方法
        ///   防止文件较大时byte 传值太大，调用时使用了buffer处理
        /// </summary>
        public Stream file_stream { get; set; }
    }


    /// <summary>
    /// 上传素材响应接口
    /// </summary>
    public class WxMediaUploadResp:WxBaseResp
    {
        /// <summary>   
        ///   媒体文件类型，分别有图片（image）、语音（voice）、视频（video）和缩略图（thumb，主要用于视频与音乐格式的缩略图）
        /// </summary>  
        public string type { get; set; }

        /// <summary>   
        ///   媒体文件上传后，获取标识
        /// </summary>  
        public string media_id { get; set; }

        /// <summary>   
        ///   媒体文件上传时间戳
        /// </summary>  
        public string created_at { get; set; }
    }


    /// <summary>
    /// 如果是视频素材响应信息
    /// </summary>
    public class WxMediaVideoUrlResp:WxBaseResp
    {
        /// <summary>
        /// 视频下载地址
        /// </summary>
        public string video_url { get; set; }
    }

    /// <summary>
    /// 素材类型
    /// </summary>
    public enum MediaType
    {
        /// <summary>
        /// 图片（image）: 2M，支持PNG\JPEG\JPG\GIF格式
        /// </summary>
        image,

        /// <summary>
        ///  语音（voice）：2M，播放长度不超过60s，支持AMR\MP3格式
        /// </summary>
        voice,

        /// <summary>
        ///   视频（video）：10MB，支持MP4格式
        /// </summary>
        video,

        /// <summary>
        ///  缩略图（thumb）：64KB，支持JPG格式
        /// </summary>
        thumb
    }
}
