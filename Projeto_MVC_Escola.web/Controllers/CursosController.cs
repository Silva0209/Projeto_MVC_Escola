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
    public class CursosController : Controller
    {
        private readonly DataContext _context;

        public CursosController(DataContext context)
        {
            _context = context;
        }

        // GET: Cursos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cursos.ToListAsync());

        }

        // GET: Cursos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Cursos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            var cursoViewModel = new CursoViewModel
            {
                Id = model.Id,
                nome_curso = model.nome_curso,
                carga_horaria_curso = model.carga_horaria_curso,
                data_fim = model.data_fim,
                data_inicio = model.data_inicio,
            };
            return View(cursoViewModel);
        }

        // GET: Cursos/Create
        public IActionResult Create()
        {
            var curso = new CursoViewModel();
            return View(curso);
        }

        // POST: Cursos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CursoViewModel cursoViewModel)
        {
            if (ModelState.IsValid)
            {

                var curso = new Curso
                {
                    Id = cursoViewModel.Id,
                    nome_curso = cursoViewModel.nome_curso,
                    carga_horaria_curso = cursoViewModel.carga_horaria_curso,
                    data_fim = cursoViewModel.data_fim,
                    data_inicio = cursoViewModel.data_inicio,

                };

                _context.Add(curso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(cursoViewModel);
        }

        // GET: Cursos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Cursos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            var cursoViewModel = new CursoViewModel
            {
                Id = model.Id,
                nome_curso = model.nome_curso,
                carga_horaria_curso = model.carga_horaria_curso,
                data_fim = model.data_fim,
                data_inicio = model.data_inicio,

            };

            return View(cursoViewModel);
        }

        // POST: Cursos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CursoViewModel cursoViewModel)
        {
            if (id != cursoViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   
                    var curso = new Curso
                    {
                        Id = cursoViewModel.Id,
                        nome_curso = cursoViewModel.nome_curso,
                        carga_horaria_curso = cursoViewModel.carga_horaria_curso,
                        data_fim = cursoViewModel.data_fim,
                        data_inicio = cursoViewModel.data_inicio,
                    };
                    _context.Update(curso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CursoModelExists(cursoViewModel.Id))
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
           
            return View(cursoViewModel);
        }

        // GET: Cursos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Cursos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {

                return NotFound();
            }
            var cursoViewModel = new CursoViewModel
            {
                Id = model.Id,
                nome_curso = model.nome_curso,
                carga_horaria_curso = model.carga_horaria_curso,
                data_fim = model.data_fim,
                data_inicio = model.data_inicio,

            };
            return View(cursoViewModel);
        }

        // POST: Cursos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var model = await _context.Cursos.FindAsync(id);
            _context.Cursos.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CursoModelExists(int id)
        {
            return _context.Cursos.Any(e => e.Id == id);
        }
    }
}
