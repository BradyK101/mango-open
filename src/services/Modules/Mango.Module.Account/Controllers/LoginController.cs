﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Mango.Module.Core.Entity;
using Mango.Framework.Infrastructure;
using Mango.Framework.Data;

namespace Mango.Module.Account.Controllers
{
    [Area("Account")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUnitOfWork<MangoDbContext> _unitOfWork;
        public LoginController(IUnitOfWork<MangoDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        /// <summary>
        /// 账号登录
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody]Models.LoginRequestModel requestModel)
        {
            if (string.IsNullOrEmpty(requestModel.AccountName)|| requestModel.AccountName=="")
            {
                return APIReturnMethod.ReturnFailed("请输入您的登录账号!");
            }
            if (string.IsNullOrEmpty(requestModel.Password) || requestModel.Password == "")
            {
                return APIReturnMethod.ReturnFailed("请输入您的登录密码!");
            }
            var repository = _unitOfWork.GetRepository<m_Account>();
            var accountData = repository.Query()
                                        .Where(q=>q.AccountName==requestModel.AccountName&&q.Password== TextHelper.MD5Encrypt(requestModel.Password.Trim()))
                                        .Select(q=>new Models.AcountDataModel() { 
                                            AccountId=q.AccountId.Value,
                                            AccountName=q.AccountName,
                                            AddressInfo=q.AddressInfo,
                                            Birthday=q.Birthday,
                                            Email=q.Email,
                                            GroupId=q.GroupId.Value,
                                            HeadUrl=q.HeadUrl,
                                            LastLoginDate=q.LastLoginDate.Value,
                                            NickName=q.NickName,
                                            Phone=q.Phone,
                                            RegisterDate=q.RegisterDate.Value,
                                            Sex=q.Sex,
                                            StateCode=q.StateCode.Value,
                                            Tags=q.Tags
                                        })
                                        .FirstOrDefault();
            if (accountData == null)
            {
                return APIReturnMethod.ReturnFailed("请输入正确的账号与密码!");
            }
            if (accountData.StateCode==0)
            {
                return APIReturnMethod.ReturnFailed("该账号已经被禁止登陆!");
            }
            return APIReturnMethod.ReturnSuccess(accountData);
        }
    }
}