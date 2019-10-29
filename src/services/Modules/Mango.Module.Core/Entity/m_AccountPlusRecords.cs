using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Mango.Framework.Data;
namespace Mango.Module.Core.Entity
{
    public partial class m_AccountPlusRecords:EntityBase
    {
		
        /// <summary>
        /// ��¼Id
        /// </summary>
        [Key]
        public int? RecordsId { get; set; }
		
        /// <summary>
        /// ���޶���Id
        /// </summary>
        
        public int? ObjectId { get; set; }
		
        /// <summary>
        /// �����
        /// </summary>
        
        public int? UserId { get; set; }
		
        /// <summary>
        /// ���ʱ��
        /// </summary>
        
        public DateTime? AppendTime { get; set; }
		
        /// <summary>
        /// ��¼���� 1 ���ӵ��� 2 ���ӻش���� 3 �������۵��� 4 �ĵ����� 5 �ĵ������
        /// </summary>
        
        public int? RecordsType { get; set; }
		
    }
}