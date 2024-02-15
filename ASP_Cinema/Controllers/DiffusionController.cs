﻿using ASP_Cinema.Handlers;
using ASP_Cinema.Models;
using BLL_Cinema.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared_Cinema.Repositories;

namespace ASP_Cinema.Controllers
{
    public class DiffusionController : Controller
    {
        private readonly IDiffusionRepository<Diffusion> _diffusionRepository;

        public DiffusionController(IDiffusionRepository<Diffusion> diffusionRepository)
        {
            _diffusionRepository = diffusionRepository;
        }


        // GET: DiffusionController
        public ActionResult Index()
        {
            IEnumerable<DiffusionListViewModel> model = _diffusionRepository.Get().Select(d => d.ToListItem()); ;
            return View(model);
        }

        // GET: DiffusionController/Details/5
        public ActionResult Details(int id)
        {
            DiffusionDetailsViewModel model = _diffusionRepository.Get(id). ToDetails();
            return View(model);
        }

        // GET: DiffusionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiffusionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DiffusionCreateForm form)
        {
            try
            {
                if (form == null) ModelState.AddModelError(nameof(form), "Aucun formulaire retourné.");
                if (!ModelState.IsValid) throw new Exception();
                int id_diffusion = _diffusionRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(Details), new {id = id_diffusion});
            }
            catch
            {
                return View(form);
            }
        }

        // GET: DiffusionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DiffusionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DiffusionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DiffusionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
