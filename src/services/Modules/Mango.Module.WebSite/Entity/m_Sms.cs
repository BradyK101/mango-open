using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Mango.Framework.Data;
namespace Mango.Module.WebSite.Entity
{
    public partial class m_Sms:EntityBase
    {
		
        /// <summary>
        /// ����ID
        /// </summary>
        [Key]
        public int? SmsID { get; set; }
		
        /// <summary>
        /// �����ֻ���
        /// </summary>
        
        public string Phone { get; set; }
		
        /// <summary>
        /// ��������
        /// </summary>
        
        public string Contents { get; set; }
		
        /// <summary>
        /// ����ʱ��
        /// </summary>
        
        public DateTime? SendTime { get; set; }
		
        /// <summary>
        /// ����IP��ַ
        /// </summary>
        
        public string SendIP { get; set; }
		
        /// <summary>
        /// �Ƿ��ͳɹ�
        /// </summary>
        
        public bool? IsOk { get; set; }
	
    }
}