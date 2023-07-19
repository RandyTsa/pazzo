using Pazzo;
using Pazzo.Models.Repositories;
using System;

namespace Repository
{
    public class MemberRepository : PazzoRepository<Member>
    {
        private readonly pazzoEntities pazzoEntities;

        public MemberRepository(pazzoEntities pazzoEntities) : base(pazzoEntities)
        {
            this.pazzoEntities = pazzoEntities;
        }
    }

    public interface IMemberRepository : IRepository<Member>
    { }
}