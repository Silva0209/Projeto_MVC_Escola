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
    public class TurmasController : Controller
    {
        private readonly DataContext _context;

        public TurmasController(DataContext context)
        {
            _context = context;
        }

        // GET: Turmas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Turmas.ToListAsync());
        }

        // GET: Turmas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Turmas.Include(a => a.Curso)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            var turmaViewModel = new TurmaViewModel
            {
                Id = model.Id,
                nome_turma = model.nome_turma,
                Curso = model.Curso,
                id_curso = model.id_curso,

            };
            return View(turmaViewModel);
        }

        // GET: Alunos/Create
        public IActionResult Create()
        {
            var turma = new TurmaViewModel();
            turma.cursos = GetCurso();
            return View(turma);
        }
        private IEnumerable<SelectListItem> GetCurso()
        {
            var list = _context.Cursos.Select(c => new SelectListItem
            {
                Text = c.nome_curso,
                Value = c.Id.ToString()

            }).OrderBy(l => l.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(seleciona um curso...)",
                Value = "0"
            });

            return list;

        }
        // POST: Alunos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TurmaViewModel turmaViewModel)
        {
            if (ModelState.IsValid)
            {
                var cursos = await _context.Cursos.FirstOrDefaultAsync(t => t.Id == turmaViewModel.id_curso);
                if (cursos == null)
                {
                    return NotFound();
                }

                var turma = new Turma
                {
                    Id = turmaViewModel.Id,
                    nome_turma = turmaViewModel.nome_turma,
                    Curso = cursos,
                    id_curso = turmaViewModel.id_curso,

                };

                _context.Add(turma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(turmaViewModel);
        }

        // GET: Alunos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Turmas.Include(a => a.Curso)
                            .FirstOrDefaultAsync(m => m.Id == id.Value);
            if (model == null)
            {
                return NotFound();
            }
            var turmaViewModel = new TurmaViewModel
            {
                Id = model.Id,
                nome_turma = model.nome_turma,
                Curso = model.Curso,
                id_curso = model.id_curso,

            };

            return View(turmaViewModel);
        }

        // POST: Alunos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TurmaViewModel turmaViewModel)
        {
            if (id != turmaViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var curso = await _context.Cursos.FirstOrDefaultAsync(t => t.Id == turmaViewModel.id_curso);
                    if (curso == null)
                    {
                        return NotFound();
                    }

                    var turma = new Turma
                    {
                        Id = turmaViewModel.Id,
                        nome_turma = turmaViewModel.nome_turma,
                        Curso = curso,
                        id_curso = turmaViewModel.id_curso,

                    };
                    _context.Update(turma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TurmaModelExists(turmaViewModel.Id))
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
            turmaViewModel.cursos = GetCurso();
            return View(turmaViewModel);
        }

     

        // GET: Alunos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Turmas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {

                return NotFound();
            }
            var turmaViewModel = new TurmaViewModel
            {
                Id = model.Id,
                nome_turma = model.nome_turma,
                Curso = model.Curso,
                id_curso = model.id_curso,

            };
            return View(turmaViewModel);
        }

        // POST: Alunos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var model = await _context.Turmas.FindAsync(id);
            _context.Turmas.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TurmaModelExists(int id)
        {
            return _context.Turmas.Any(e => e.Id == id);
        }
    }
}
