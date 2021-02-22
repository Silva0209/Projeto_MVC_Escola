using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_MVC_Escola.web.Data.Entities;
using Projeto_MVC_Escola.web.Models;

namespace Projeto_MVC_Escola.web.Controllers
{
    public class ProfessoresController : Controller
    {
        private readonly DataContext _context;

        public ProfessoresController(DataContext context)
        {
            _context = context;
        }

        // GET: Professores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Professores.ToListAsync());
        }

        // GET: Professores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Professores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            var professorViewModel = new ProfessorViewModel
            {
                Id = model.Id,
                cc = model.cc,
                contacto = model.contacto,
                cp_1 = model.cp_1,
                cp_2 = model.cp_2,
                email = model.email,
                genero = model.genero,
                nome = model.nome,
                ImageUrl = model.ImageUrl,
                localidade = model.localidade,
                morada = model.morada,
                nif = model.nif,

            };
            return View(professorViewModel);
        }

        // GET: Professores/Create
        public IActionResult Create()
        {
            var professor = new ProfessorViewModel();
            return View(professor);
        }

        // POST: Professores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProfessorViewModel professorViewModel)
        {
            if (ModelState.IsValid)
            {

                var professor = new Professor
                {
                    cc = professorViewModel.cc,
                    contacto = professorViewModel.contacto,
                    cp_1 = professorViewModel.cp_1,
                    cp_2 = professorViewModel.cp_2,
                    email = professorViewModel.email,
                    genero = professorViewModel.genero,
                    nome = professorViewModel.nome,
                    ImageUrl = professorViewModel.ImageUrl,
                    localidade = professorViewModel.localidade,
                    morada = professorViewModel.morada,
                    nif = professorViewModel.nif,

                };

                _context.Add(professor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(professorViewModel);
        }

        // GET: Professores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Professores
                            .FirstOrDefaultAsync(m => m.Id == id.Value);
            if (model == null)
            {
                return NotFound();
            }
            var professorViewModel = new ProfessorViewModel
            {
                Id = model.Id,
                cc = model.cc,
                contacto = model.contacto,
                cp_1 = model.cp_1,
                cp_2 = model.cp_2,
                email = model.email,
                genero = model.genero,
                nome = model.nome,
                ImageUrl = model.ImageUrl,
                localidade = model.localidade,
                morada = model.morada,
                nif = model.nif,

            };

            return View(professorViewModel);
        }

        // POST: Professores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProfessorViewModel professorViewModel)
        {
            if (id != professorViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                  

                    var professor = new Professor
                    {
                        Id = professorViewModel.Id,
                        cc = professorViewModel.cc,
                        contacto = professorViewModel.contacto,
                        cp_1 = professorViewModel.cp_1,
                        cp_2 = professorViewModel.cp_2,
                        email = professorViewModel.email,
                        genero = professorViewModel.genero,
                        nome = professorViewModel.nome,
                        ImageUrl = professorViewModel.ImageUrl,
                        localidade = professorViewModel.localidade,
                        morada = professorViewModel.morada,
                        nif = professorViewModel.nif,

                    };
                    _context.Update(professor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfessorModelExists(professorViewModel.Id))
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
          
            return View(professorViewModel);
        }

        // GET: Professores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Professores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {

                return NotFound();
            }
            var professorViewModel = new ProfessorViewModel
            {
                Id = model.Id,
                cc = model.cc,
                contacto = model.contacto,
                cp_1 = model.cp_1,
                cp_2 = model.cp_2,
                email = model.email,
                genero = model.genero,
                nome = model.nome,
                ImageUrl = model.ImageUrl,
                localidade = model.localidade,
                morada = model.morada,
                nif = model.nif,

            };
            return View(professorViewModel);
        }

        // POST: Professores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var model = await _context.Professores.FindAsync(id);
            _context.Professores.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfessorModelExists(int id)
        {
            return _context.Professores.Any(e => e.Id == id);
        }
    }
}
