using Pazzo;
using Pazzo.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface IHomeService
    {
        /// <summary>
        /// 新增會員
        /// </summary>
        /// <param name="createVM"></param>
        /// <returns></returns>
        Task<ApplicationResult<Member>> CreateAsync(CreateViewModel createVM);
    }
}