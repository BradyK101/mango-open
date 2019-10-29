using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Mango.Framework.Data;
namespace Mango.Module.CMS.Entity
{
    public partial class m_CmsAttention:EntityBase
    {
		
        /// <summary>
        /// ��עId
        /// </summary>
        [Key]
        public int? AttentionId { get; set; }
		
        /// <summary>
        /// ����Id
        /// </summary>
        
        public int? ContentsId { get; set; }
		
        /// <summary>
        /// ��עʱ��
        /// </summary>
        
        public DateTime? AttentionTime { get; set; }
		
        /// <summary>
        /// �û�Id
        /// </summary>
        
        public int? AccountId { get; set; }
		
    }
}