﻿using System.Collections.Generic;
using System.Linq;
using UnitTestClasses.Entities;
using UnitTestClasses.Repos;

namespace UnitTestClasses.Services
{
    public class FilerEmailService
    {
        private readonly IFilerEmailRepository<FilerEmail> _feRepo;

        public FilerEmailService(IFilerEmailRepository<FilerEmail> feRepo)
        {
            _feRepo = feRepo;
        }

        public IQueryable<FilerEmail> GetFilerEmailsAsDefault()
        {
            return _feRepo.GetList(fe => fe.isDefault == true);
        }

        public IQueryable<FilerEmail> GetFilerEmailsById(int id)
        {
            return _feRepo.GetList(fe => fe.FilerId == id);
        }
    }
}
