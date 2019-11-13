﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Web.Areas.Cms.Models
{
    public class ContentsDataModel
    {
        /// <summary>
        /// 内容Id
        /// </summary>
        public int ContentsId { get; set; }
        /// <summary>
        /// 帖子标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>

        public string Contents { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>

        public DateTime PostTime { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>

        public DateTime LastTime { get; set; }

        /// <summary>
        /// 账号Id
        /// </summary>

        public int AccountId { get; set; }

        /// <summary>
        /// +1数
        /// </summary>

        public int PlusCount { get; set; }

        /// <summary>
        /// 阅读次数
        /// </summary>

        public int ReadCount { get; set; }

        /// <summary>
        /// 是否显示(1.显示 0.不显示)
        /// </summary>

        public int StateCode { get; set; }
        /// <summary>
        /// 所属频道
        /// </summary>

        public int ChannelId { get; set; }
        /// <summary>
        /// 所属频道名称
        /// </summary>

        public string ChannelName { get; set; }
        /// <summary>
        /// 回复数
        /// </summary>
        public int AnswerCount { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        public string HeadUrl { get; set; }
    }
}
