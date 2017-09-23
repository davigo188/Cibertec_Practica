using CibertecPractica.Models;
using CibertecPractica.Repositories.EntityFramework.Credit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;

namespace CibertecPractica.Repositories.EntityFrameworkTests
{
    public class MemberRepositoryTest
    {
        private readonly DbContext _context;
        private readonly CreditUnitOfWork unit;

        public MemberRepositoryTest()
        {
            _context = new CreditDBContext();
            unit = new CreditUnitOfWork(_context);
        }
        [Fact(DisplayName = "[MemberRepository]Get All")]
        public void Member_Repository_GetAll()
        {
            var result = unit.Members.GetList();
            Assert.True(result.Count() > 0);
        }


        [Fact(DisplayName = "[MemberRepository]Insert")]
        public void Member_Repository_Insert()
        {
            var Member = GetNewMember();
            var result = unit.Members.Insert(Member);
            Assert.True(result > 0);
        }

        [Fact(DisplayName = "[MemberRepository]Delete")]
        public void Member_Repository_Delete()
        {
            var member = GetNewMember();
            var result = unit.Members.Insert(member);
            Assert.True(unit.Members.Delete(member));
        }

        [Fact(DisplayName = "[MemberRepository]Update")]
        public void Member_Repository_Update()
        {
            var member = unit.Members.GetById(10);
            Assert.True(member != null);
            member.Expr_dt = DateTime.Now;
            Assert.True(unit.Members.Update(member));
        }

        [Fact(DisplayName = "[MemberRepository]Get By Id")]
        public void Member_Repository_Get_By_Id()
        {
            var member = unit.Members.GetById(10);
            Assert.True(member != null);
        }

        private Member GetNewMember()
        {
            return new Member
            {
                Lastname = "",
                Firstname = "",
                Middleinitial = "",
                Street="",
                City="",
                State_prov="",
                Country = "",
                Mail_code = "",
                Phone_no = "",
                Issue_dt = DateTime.Now,
                Expr_dt = DateTime.Now,
                Corp_no = 7,
                Prev_balance = 0,
                Curr_balance = 0,
                Member_code = ""

            };
        }

        [Fact(DisplayName = "[MemberRepository]SearchByLastName")]
        public void Member_Repository_SearchByNames()
        {
            var member = unit.Members.SearchByLastName("ANDERSON");
            Assert.True(member != null);
        }
    }
}
