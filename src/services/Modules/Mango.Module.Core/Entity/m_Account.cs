using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Mango.Framework.Data;
namespace Mango.Module.Core.Entity
{
    public partial class m_Account:EntityBase
    {
		
        /// <summary>
        /// �û�Id
        /// </summary>
        [Key]
        public int? AccountId { get; set; }
		
        /// <summary>
        /// �û���
        /// </summary>
        
        public string AccountName { get; set; }
		
        /// <summary>
        /// ��½����
        /// </summary>
        
        public string Password { get; set; }
		
        /// <summary>
        /// �ǳ�
        /// </summary>
        
        public string NickName { get; set; }
		
        /// <summary>
        /// �û�ͷ��
        /// </summary>
        
        public string HeadUrl { get; set; }
		
        /// <summary>
        /// �û�״̬(1:����
        /// </summary>
        
        public int? StateCode { get; set; }
		
        /// <summary>
        /// �ֻ���
        /// </summary>
        
        public string Phone { get; set; }
		
        /// <summary>
        /// 
        /// </summary>
        
        public string Email { get; set; }
		
        /// <summary>
        /// ע��ʱ��
        /// </summary>
        
        public DateTime? RegisterDate { get; set; }
		
        /// <summary>
        /// ����½ʱ��
        /// </summary>
        
        public DateTime? LastLoginDate { get; set; }
		
        /// <summary>
        /// ������Ϣ
        /// </summary>
        
        public string AddressInfo { get; set; }
		
        /// <summary>
        /// ����
        /// </summary>
        
        public string Birthday { get; set; }
		
        /// <summary>
        /// ���˱�ǩ
        /// </summary>
        
        public string Tags { get; set; }
		
        /// <summary>
        /// �Ա�
        /// </summary>
        
        public string Sex { get; set; }
		
        /// <summary>
        /// 
        /// </summary>
        
        public int? GroupId { get; set; }
		
    }
}