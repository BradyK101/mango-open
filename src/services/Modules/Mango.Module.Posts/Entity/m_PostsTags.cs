using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Mango.Framework.Data;
namespace Mango.Module.Posts.Entity
{
    public partial class m_PostsTags:EntityBase
    {
		
        /// <summary>
        /// ����Id
        /// </summary>
        [Key]
        public int? TagsId { get; set; }
		
        /// <summary>
        /// ��������
        /// </summary>
        
        public string TagsName { get; set; }
		
    }
}