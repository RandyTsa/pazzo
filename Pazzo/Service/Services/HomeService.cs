using Application.Contracts;
using Pazzo;
using Pazzo.Models.Repositories;
using Pazzo.Models.ViewModels;
using Repository;
using System;
using System.Threading.Tasks;

namespace Application
{
    public class HomeService : IHomeService
    {
        private readonly IMemberRepository memberRepository;

        public HomeService(IMemberRepository memberRepository)
        {
            this.memberRepository = memberRepository;
        }

        public async Task<ApplicationResult<Member>> CreateAsync(CreateViewModel createVM)
        {
            var isParse = int.TryParse(createVM.Id, out int id);

            if (!isParse)
            {
                throw new Exception("Id 只允許為數字");
            }
            var entity = new Member() { Id = id, Name = createVM.Name };

            var effectRows = await memberRepository.CreateAsync(entity);

            return effectRows > 0 ? ApplicationResult<Member>.Success : ApplicationResult<Member>.Failed();
        }
    }
}