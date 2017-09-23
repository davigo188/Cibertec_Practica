using CibertecPractica.Models;
using CibertecPractica.Repositories.EntityFramework.Credit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;

namespace CibertecPractica.Repositories.EntityFrameworkTests
{
    public class CorporationRepositoryTest
    {
        private readonly DbContext _context;
        private readonly CreditUnitOfWork unit;

        public CorporationRepositoryTest()
        {
            _context = new CreditDBContext();
            unit = new CreditUnitOfWork(_context);
        }

        [Fact(DisplayName = "[CorporationRepository]Get All")]
        public void Corporation_Repository_GetAll()
        {
            var result = unit.Corporations.GetList();
            Assert.True(result.Count() > 0);
        }

        [Fact(DisplayName = "[CorporationRepository]Insert")]
        public void Corporation_Repository_Insert()
        {
            var corporation = GetNewCorporation();
            var result = unit.Corporations.Insert(corporation);
            Assert.True(result > 0);
        }
        [Fact(DisplayName = "[CorporationRepository]Delete")]
        public void Corporation_Repository_Delete()
        {
            var corporation = GetNewCorporation();
            var result = unit.Corporations.Insert(corporation);
            Assert.True(unit.Corporations.Delete(corporation));
        }

        [Fact(DisplayName = "[CorporationRepository]Update")]
        public void Corporation_Repository_Update()
        {
            var corporation = unit.Corporations.GetById(10);
            Assert.True(corporation != null);
            corporation.Expr_dt = DateTime.Now;
            Assert.True(unit.Corporations.Update(corporation));
        }

        [Fact(DisplayName = "[CorporationRepository]Get By Id")]
        public void Corporation_Repository_Get_By_Id()
        {
            var corporation = unit.Corporations.GetById(10);
            Assert.True(corporation != null);
        }

        private Corporation GetNewCorporation()
        {
            return new Corporation
            {
                Corp_name = "",
                Street = "",
                City = "",
                State_prov = "",
                Country = "",
                Mail_code = "",
                Phone_no = "",
                Expr_dt = DateTime.Now,
                Corp_code = ""
            };
        }


        [Fact(DisplayName = "[CorporationRepository]SearchByNames")]
        public void Corporation_Repository_SearchByNames()
        {
            var corporation = unit.Corporations.SearchByNames("Corp. Apex LightingInc.");
            Assert.True(corporation != null);
        }

    }
}
