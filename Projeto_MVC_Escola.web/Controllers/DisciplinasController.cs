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
    public class DisciplinasController : Controller
    {
        private readonly DataContext _context;

        public DisciplinasController(DataContext context)
        {
            _context = context;
        }

        // GET: Disciplinas
        public async Task<IActionResult> Index()
        {
            //Quando queres que apareca coisas de outras tabelas tem de se meter o include
            return View(await _context.Disciplinas.Include(a => a.Curso).Include(a => a.Professor).ToListAsync());
        }

        // GET: Disciplinas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Disciplinas.Include(a => a.Curso).Include(a => a.Professor)

                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            var disciplinaViewModel = new DisciplinaViewModel
            {
                Id = model.Id,
                area_formação = model.area_formação,
                carga_horaria_discplina = model.carga_horaria_discplina,
                creditos_discplina = model.creditos_discplina,
                nome_disciplina = model.nome_disciplina,
                Curso = model.Curso,
                id_curso = model.id_curso,
                id_professor = model.id_professor,
                Professor = model.Professor,

            };
            return View(disciplinaViewModel);
        }

        // GET: Disciplinas/Create
        public IActionResult Create()
        {
            var disciplina = new DisciplinaViewModel();
            disciplina.cursos = GetCurso();
            disciplina.professores = GetProfessor();
            return View(disciplina);
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

        private IEnumerable<SelectListItem> GetProfessor()
        {
            var list = _context.Professores.Select(c => new SelectListItem
            {
                Text = c.nome,
                Value = c.Id.ToString()

            }).OrderBy(l => l.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(seleciona um professor...)",
                Value = "0"
            });

            return list;

        }
        // POST: Disciplinas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DisciplinaViewModel disciplinaViewModel)
        {
            if (ModelState.IsValid)
            {
                var curso = await _context.Cursos.FirstOrDefaultAsync(t => t.Id == disciplinaViewModel.id_curso);
                var professor = await _context.Professores.FirstOrDefaultAsync(t => t.Id == disciplinaViewModel.id_professor);
                if (curso == null)
                {
                    return NotFound();
                }
                if (professor == null)
                {
                    return NotFound();
                }

                var disciplina = new Disciplina
                {
                    Id = disciplinaViewModel.Id,
                    area_formação = disciplinaViewModel.area_formação,
                    carga_horaria_discplina = disciplinaViewModel.carga_horaria_discplina,
                    creditos_discplina = disciplinaViewModel.creditos_discplina,
                    nome_disciplina = disciplinaViewModel.nome_disciplina,
                    Curso = curso,
                    Professor = professor,
                    id_curso = disciplinaViewModel.id_curso,
                    id_professor = disciplinaViewModel.id_professor,


                };

                _context.Add(disciplina);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(disciplinaViewModel);
        }

        // GET: Disciplinas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Disciplinas.Include(a => a.Curso).Include(a => a.Professor)

                           .FirstOrDefaultAsync(m => m.Id == id.Value);
            if (model == null)
            {
                return NotFound();
            }
            var disciplinaViewModel = new DisciplinaViewModel
            {
                Id = model.Id,
                area_formação = model.area_formação,
                carga_horaria_discplina = model.carga_horaria_discplina,
                creditos_discplina = model.creditos_discplina,
                nome_disciplina = model.nome_disciplina,
                Curso = model.Curso,
                id_curso = model.id_curso,
                id_professor = model.id_professor,
                Professor = model.Professor,

            };

            return View(disciplinaViewModel);
        }

        // POST: Disciplinas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, DisciplinaViewModel disciplinaViewModel)
        {
            if (id != disciplinaViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var curso = await _context.Cursos.FirstOrDefaultAsync(t => t.Id == disciplinaViewModel.id_curso);
                    var professor = await _context.Professores.FirstOrDefaultAsync(t => t.Id == disciplinaViewModel.id_professor);
                    if (curso == null)
                    {
                        return NotFound();
                    }
                    if (professor == null)
                    {
                        return NotFound();
                    }

                    var disciplina = new Disciplina
                    {
                        Id = disciplinaViewModel.Id,
                        area_formação = disciplinaViewModel.area_formação,
                        carga_horaria_discplina = disciplinaViewModel.carga_horaria_discplina,
                        creditos_discplina = disciplinaViewModel.creditos_discplina,
                        nome_disciplina = disciplinaViewModel.nome_disciplina,
                        Curso = curso,
                        Professor = professor,
                        id_curso = disciplinaViewModel.id_curso,
                        id_professor = disciplinaViewModel.id_professor,

                    };
                    _context.Update(disciplina);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DisciplinaModelExists(disciplinaViewModel.Id))
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
            disciplinaViewModel.cursos = GetCurso();
            return View(disciplinaViewModel);
        }

        // GET: Disciplinas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Disciplinas.Include(a => a.Curso).Include(a => a.Professor)

                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {

                return NotFound();
            }
            var disciplinaViewModel = new DisciplinaViewModel
            {
                Id = model.Id,
                area_formação = model.area_formação,
                carga_horaria_discplina = model.carga_horaria_discplina,
                creditos_discplina = model.creditos_discplina,
                nome_disciplina = model.nome_disciplina,
                Curso = model.Curso,
                id_curso = model.id_curso,
                id_professor = model.id_professor,
                Professor = model.Professor,

            };
            return View(disciplinaViewModel);
        }

        // POST: Disciplinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var model = await _context.Disciplinas.FindAsync(id);
            _context.Disciplinas.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DisciplinaModelExists(int id)
        {
            return _context.Disciplinas.Any(e => e.Id == id);
        }
    }
}
