using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Mango.Framework.Data;
namespace Mango.Module.CMS.Entity
{
    public partial class m_CmsContents:EntityBase
    {
		
        /// <summary>
        /// ����Id
        /// </summary>
        [Key]
        public int? ContentsId { get; set; }
		
        /// <summary>
        /// ����
        /// </summary>
        
        public string Title { get; set; }
		
        /// <summary>
        /// ����
        /// </summary>
        
        public string Contents { get; set; }
		
        /// <summary>
        /// ����ʱ��
        /// </summary>
        
        public DateTime? PostTime { get; set; }
		
        /// <summary>
        /// ������ʱ��
        /// </summary>
        
        public DateTime? LastTime { get; set; }
		
        /// <summary>
        /// �˺�Id
        /// </summary>
        
        public int? AccountId { get; set; }
		
        /// <summary>
        /// +1��
        /// </summary>
        
        public int? PlusCount { get; set; }
		
        /// <summary>
        /// �Ķ�����
        /// </summary>
        
        public int? ReadCount { get; set; }
		
        /// <summary>
        /// �Ƿ���ʾ
        /// </summary>
        
        public int? StateCode { get; set; }
		
        /// <summary>
        /// ���ݱ�ǩ
        /// </summary>
        
        public string Tags { get; set; }
		
        /// <summary>
        /// ͼƬ��ַ
        /// </summary>
        
        public string ImgUrl { get; set; }
		
        /// <summary>
        /// �ظ���
        /// </summary>
        
        public int? AnswerCount { get; set; }
		
        /// <summary>
        /// ����Ƶ��
        /// </summary>
        
        public int? ChannelId { get; set; }
		
    }
}