using DernekOtomasyon.Business.DataServices;
using DernekOtomasyon.Business.UnitOfWork;
using DernekOtomasyon.DATA.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DernekOtomasyon.MVC.Controllers.Base
{
    public class BaseController : Controller
    {
        // GET: Base


        private ApplicationEntityDbContext _dbContext;

        public MemberRepository MemberRepo;



        public IUnitOfWork _uow;

        public BaseController()
        {

            _dbContext = new ApplicationEntityDbContext();
            MemberRepo = new MemberRepository(_dbContext);


            _uow = new EFUnitOfWork(_dbContext);
        }
    }
}