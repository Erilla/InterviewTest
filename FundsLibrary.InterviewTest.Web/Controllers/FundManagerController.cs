﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using FundsLibrary.InterviewTest.Common;
using FundsLibrary.InterviewTest.Web.Repositories;
using FundsLibrary.InterviewTest.Service;
using PagedList;
using System.Collections.Generic;

namespace FundsLibrary.InterviewTest.Web.Controllers
{
    [Authorize]
    public class FundManagerController : Controller
    {
        private readonly IFundManagerRepository _repository;

        public FundManagerController(IFundManagerRepository repository)
        {
            _repository = repository;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> Index(string sortOrder = "", int? page = null)
        {
            var fundManagersList = await _repository.GetAll();
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "Name":
                    fundManagersList = fundManagersList.OrderBy(n => n.Name);
                    break;
                case "Location":
                    fundManagersList = fundManagersList.OrderBy(n => n.Location.ToString());
                    break;
                case "Biography":
                    fundManagersList = fundManagersList.OrderBy(n => n.Biography);
                    break;
                case "ManagedSince":
                    fundManagersList = fundManagersList.OrderBy(n => n.ManagedSince);
                    break;
                default:
                    fundManagersList = fundManagersList.OrderByDescending(n => n.Name);
                    break;
            }

            var pageNumber = page ?? 1;
            const int pageSize = 3;
            return View(fundManagersList.ToPagedList(pageNumber, pageSize));
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return _UnverifiedFundManagerId("A Fund Manager Id was not provided or was in an invalid format");
            }
            var result = await _repository.Get(id.Value);
            if (result == null)
            {
                return _UnverifiedFundManagerId($"The Fund Manager id {id.Value} was not found");
            }

            var funds = await _repository.GetFunds(id.Value);
            foreach (var value in funds.value)
            {
                foreach (var team in value.StaticData.Management.Team)
                {
                    if (team.Id == id.Value)
                    {
                        if (!String.IsNullOrEmpty(team.Bio))
                        {
                            result.Biography = team.Bio;
                        }
                        
                        if (!String.IsNullOrEmpty(team.Photo))
                        {
                            result.Photo = team.Photo;
                        }
                    }
                }

                result.SecurityFunds = new List<SecurityFunds>();

                if (!String.IsNullOrEmpty(value.StaticData.Identification.IsinCode))
                {
                    SecurityFunds securityFund = new SecurityFunds();
                    securityFund.IsinCode = value.StaticData.Identification.IsinCode;
                    securityFund.FullName = value.StaticData.Identification.FullName;

                    result.SecurityFunds.Add(securityFund);
                }
            }
            

            return View(result);
        }

        private RedirectToRouteResult _UnverifiedFundManagerId(string errorMessage)
        {
            return RedirectToAction("Index", "Error", new { errorMessage });
        }

        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Add(FundManager newManager)
        {
            if (ModelState.IsValid)
            {
                var result = await _repository.Post(newManager);
                return RedirectToAction("Details", new { id = result });
            }
            return View(newManager);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return _UnverifiedFundManagerId("A Fund Manager Id was not provided or was in an invalid format");
            }
            await _repository.Delete(id.Value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return _UnverifiedFundManagerId("A Fund Manager Id was not provided or was in an invalid format");
            }
            var result = await _repository.Get(id.Value);
            if (result == null)
            {
                return _UnverifiedFundManagerId($"The Fund Manager id {id.Value} was not found");
            }
            return View(result);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(FundManager editManager)
        {
            if (ModelState.IsValid)
            {
                var result = await _repository.Put(editManager);
                return RedirectToAction("Details", new { id = result });
            }

            return View(editManager);
        }
    }
}
