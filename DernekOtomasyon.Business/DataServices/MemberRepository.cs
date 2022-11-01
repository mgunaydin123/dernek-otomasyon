using DernekOtomasyon.Business.BaseServices;
using DernekOtomasyon.DATA.Context;
using DernekOtomasyon.DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyon.Business.DataServices
{
    public class MemberRepository : GenericRepository<Member>
    {
        public MemberRepository(ApplicationEntityDbContext context)
            : base(context)
        {
        }
    }
}
