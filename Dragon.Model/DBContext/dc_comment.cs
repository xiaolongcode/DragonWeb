//======================================================================
//      Copyright (c) 2020-09-22 Dragon All rights reserved. 
//======================================================================
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon.Model.DBContext
 { 
    /// <summary> 
    /// 
    /// <summary> 
    [Table("dc_comment")]
    public class dc_comment
    { 

        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 视频id
        /// </summary>
        public int c_videoid { get; set; }

        /// <summary>
        /// 评论人id
        /// </summary>
        public int c_userid { get; set; }

        /// <summary>
        /// 置顶 0 否  1 是
        /// </summary>
        public int c_sticky { get; set; }

        /// <summary>
        /// 状态 0 未删除  1 已删除
        /// </summary>
        public int c_del { get; set; }

        /// <summary>
        /// 类型 0 视频 1 直播 页面用
        /// </summary>
        public int c_type { get; set; }

        /// <summary>
        /// 0 评论 1 回复
        /// </summary>
        public int c_datatype { get; set; }

        /// <summary>
        /// 被回复评论id（总ID 当前评论下的所有回复都根据此id读取）
        /// </summary>
        public int c_dataid { get; set; }

        /// <summary>
        /// 被回复的回复id（针对某条评论进行回复 被回复的那条数据id）
        /// </summary>
        public int c_todataid { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        public int c_likecount { get; set; }

        /// <summary>
        /// 视频标题
        /// </summary>
        public string c_title { get; set; }

        /// <summary>
        /// 视频作者
        /// </summary>
        public string c_videoname { get; set; }

        /// <summary>
        /// 评论人姓名
        /// </summary>
        public string c_username { get; set; }

        /// <summary>
        /// 评论人手机号
        /// </summary>
        public string c_usersj { get; set; }

        /// <summary>
        /// 评论日期
        /// </summary>
        public string c_date { get; set; }

        /// <summary>
        /// 评论时间
        /// </summary>
        public string c_time { get; set; }

        /// <summary>
        /// 被回复人姓名
        /// </summary>
        public string c_tousername { get; set; }

        /// <summary>
        /// 被回复人头像链接
        /// </summary>
        public string c_tohref { get; set; }

        /// <summary>
        /// 评论人头像链接
        /// </summary>
        public string c_href { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        public string c_content { get; set; }    } 
 } 
