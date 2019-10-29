using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Mango.Framework.Data;
namespace Mango.Module.CMS.Entity
{
    public partial class m_CmsChannel:EntityBase
    {
		
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int? ChannelId { get; set; }
		
        /// <summary>
        /// Ƶ������
        /// </summary>
        
        public string ChannelName { get; set; }
		
        /// <summary>
        /// ��ע��Ϣ
        /// </summary>
        
        public string RemarkText { get; set; }
		
        /// <summary>
        /// �Ƿ���ʾ
        /// </summary>
        
        public int? StateCode { get; set; }
		
        /// <summary>
        /// Ƶ������ʱ��
        /// </summary>
        
        public DateTime? AppendTime { get; set; }
		
        /// <summary>
        /// 
        /// </summary>
        
        public int? SortCount { get; set; }
		
    }
}