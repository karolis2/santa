using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Darbuotojai.Application.Services;
using Darbuotojai.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Darbuotojai.Architecture.Infra.Data;
using Darbuotojai.Domain.Models;

namespace Darbuotojai.MVC.Controllers
{
    public class DarbuotojasController : Controller
    {
        
        private IDarbuotojaiService _darbuotojaiService;

        public DarbuotojasController(IDarbuotojaiService darbuotojaiService)
        {
            _darbuotojaiService = darbuotojaiService;
        }
        
        

        // GET: Darbuotojas
        public async Task<IActionResult> Index()
        {
            var model = await _darbuotojaiService.GetDarbuotojai();
            
            return View(model);
        }

        // GET: Darbuotojas/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var darbuotojas = await _darbuotojaiService.GetDetails(id);
            
            if (darbuotojas == null)
            {
                return NotFound();
            }

            return View(darbuotojas);
        }

        // GET: Darbuotojas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Darbuotojas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Vardas,Pavardė,AsmensKodas,GimimoData,NamoNumeris,Gatve,Miestas,PastoKodas,Aktyvus")] DarbuotojasDto darbuotojas)
        {
            if (ModelState.IsValid)
            {
               await _darbuotojaiService.Create(darbuotojas.Vardas,  darbuotojas.Pavardė,  darbuotojas.AsmensKodas,  darbuotojas.GimimoData, darbuotojas.NamoNumeris,
                    darbuotojas.Gatve,  darbuotojas.Miestas,  darbuotojas.PastoKodas, darbuotojas.Aktyvus);
               
                return RedirectToAction(nameof(Index));
            }
            return View(darbuotojas);
        }

        // GET: Darbuotojas/Edit/5
        public async Task<IActionResult> Edit(int id)
        {

            var darbuotojas = await _darbuotojaiService.GetDetails(id);
            if (darbuotojas == null)
            {
                return NotFound();
            }
            return View(darbuotojas);
        }

        // POST: Darbuotojas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Vardas,Pavardė,AsmensKodas,GimimoData,NamoNumeris,Gatve,Miestas,PastoKodas,Aktyvus")] DarbuotojasDto darbuotojas)
        {
            if (id != darbuotojas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                  await  _darbuotojaiService.Update(darbuotojas.Id, darbuotojas.Vardas,  darbuotojas.Pavardė,  darbuotojas.AsmensKodas,  darbuotojas.GimimoData, darbuotojas.NamoNumeris,
                        darbuotojas.Gatve,  darbuotojas.Miestas,  darbuotojas.PastoKodas, darbuotojas.Aktyvus);
                }
                catch (DbUpdateConcurrencyException)
                {
                    var darbuotojasExists = await DarbuotojasExists(darbuotojas.Id);
                    
                    if (!darbuotojasExists)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(darbuotojas);
        }

        // GET: Darbuotojas/Delete/5
        public async Task<IActionResult> Delete(int id)
        {

            var darbuotojas = await _darbuotojaiService.GetDetails(id);
            if (darbuotojas == null)
            {
                return NotFound();
            }
            return View(darbuotojas);
        }

        // POST: Darbuotojas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _darbuotojaiService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> DarbuotojasExists(int id)
        {

            var darbuotojai = await _darbuotojaiService.GetDarbuotojai();
            
            return darbuotojai.Any();
        }
    }
}
