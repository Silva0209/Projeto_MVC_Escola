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
    public class NotasController : Controller
    {
        private readonly DataContext _context;

        public NotasController(DataContext context)
        {
            _context = context;
        }

        // GET: Notas
        public async Task<IActionResult> Index()
        {
            //Quando queres que apareca coisas de outras tabelas tem de se meter o include
            return View(await _context.Notas.Include(a => a.Aluno).Include(a => a.Disciplina).ToListAsync());
        }

        // GET: Notas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Notas.Include(a => a.Aluno).Include(a => a.Disciplina)

                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            var notaViewModel = new NotaViewModel
            {
                Id = model.Id,
                id_aluno = model.id_aluno,
                id_disciplina = model.id_disciplina,
                Aluno = model.Aluno,
                Disciplina = model.Disciplina,
                nota_final = model.nota_final,
                aprovado = model.aprovado,

            };
            return View(notaViewModel);
        }

        // GET: Notas/Create
        public IActionResult Create()
        {
            var nota = new NotaViewModel();
            nota.alunos = GetAluno();
            nota.disciplinas = GetDisciplina();
            return View(nota);
        }
        private IEnumerable<SelectListItem> GetAluno()
        {
            var list = _context.Alunos.Select(c => new SelectListItem
            {
                Text = c.nome,
                Value = c.Id.ToString()

            }).OrderBy(l => l.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(seleciona um aluno...)",
                Value = "0"
            });

            return list;

        }

        private IEnumerable<SelectListItem> GetDisciplina()
        {
            var list = _context.Disciplinas.Select(c => new SelectListItem
            {
                Text = c.nome_disciplina,
                Value = c.Id.ToString()

            }).OrderBy(l => l.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(seleciona uma disciplina...)",
                Value = "0"
            });

            return list;

        }
        // POST: Notas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NotaViewModel notaViewModel)
        {
            if (ModelState.IsValid)
            {
                var curso = await _context.Cursos.FirstOrDefaultAsync(t => t.Id == notaViewModel.id_aluno);
                var professor = await _context.Professores.FirstOrDefaultAsync(t => t.Id == notaViewModel.id_disciplina);
                if (curso == null)
                {
                    return NotFound();
                }
                if (professor == null)
                {
                    return NotFound();
                }

                var nota = new Nota
                {
                    Id = notaViewModel.Id,
                    id_aluno = notaViewModel.id_aluno,
                    id_disciplina = notaViewModel.id_disciplina,
                    Aluno = notaViewModel.Aluno,
                    Disciplina = notaViewModel.Disciplina,
                    nota_final = notaViewModel.nota_final,
                    aprovado = notaViewModel.aprovado,

                };

                _context.Add(nota);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(notaViewModel);
        }

        // GET: Notas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Notas.Include(a => a.Aluno).Include(a => a.Disciplina)

                           .FirstOrDefaultAsync(m => m.Id == id.Value);
            if (model == null)
            {
                return NotFound();
            }
            var notaViewModel = new NotaViewModel
            {
                Id = model.Id,
                id_aluno = model.id_aluno,
                id_disciplina = model.id_disciplina,
                Aluno = model.Aluno,
                Disciplina = model.Disciplina,
                nota_final = model.nota_final,
                aprovado = model.aprovado,

            };

            return View(notaViewModel);
        }

        // POST: Notas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, NotaViewModel notaViewModel)
        {
            if (id != notaViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var curso = await _context.Cursos.FirstOrDefaultAsync(t => t.Id == notaViewModel.id_aluno);
                    var professor = await _context.Professores.FirstOrDefaultAsync(t => t.Id == notaViewModel.id_disciplina);
                    if (curso == null)
                    {
                        return NotFound();
                    }
                    if (professor == null)
                    {
                        return NotFound();
                    }

                    var nota = new Nota
                    {
                        Id = notaViewModel.Id,
                        id_aluno = notaViewModel.id_aluno,
                        id_disciplina = notaViewModel.id_disciplina,
                        Aluno = notaViewModel.Aluno,
                        Disciplina = notaViewModel.Disciplina,
                        nota_final = notaViewModel.nota_final,
                        aprovado = notaViewModel.aprovado,

                    };
                    _context.Update(nota);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotaModelExists(notaViewModel.Id))
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
            notaViewModel.alunos = GetAluno();
            return View(notaViewModel);
        }

        // GET: Notas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Notas.Include(a => a.Aluno).Include(a => a.Disciplina)

                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {

                return NotFound();
            }
            var notaViewModel = new NotaViewModel
            {
                Id = model.Id,
                id_aluno = model.id_aluno,
                id_disciplina = model.id_disciplina,
                Aluno = model.Aluno,
                Disciplina = model.Disciplina,
                nota_final = model.nota_final,
                aprovado = model.aprovado,

            };
            return View(notaViewModel);
        }

        // POST: Notas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var model = await _context.Notas.FindAsync(id);
            _context.Notas.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotaModelExists(int id)
        {
            return _context.Notas.Any(e => e.Id == id);
        }
    }
}
