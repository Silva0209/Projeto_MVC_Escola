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
    public class AlunosController : Controller
    {
        private readonly DataContext _context;

        public AlunosController(DataContext context)
        {
            _context = context;
        }

        // GET: Alunos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alunos.ToListAsync());
        }

        // GET: Alunos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Alunos.Include(a => a.Turma)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            var alunoViewModel = new AlunoViewModel {
                Id = model.Id,
                cc = model.cc,
                contacto = model.contacto,
                cp_1 = model.cp_1,
                cp_2 = model.cp_2,
                email = model.email,
                genero = model.genero,
                nome = model.nome,
                id_turma = model.id_turma,
                ImageUrl = model.ImageUrl,
                localidade = model.localidade,
                Turma = model.Turma,
                morada = model.morada,
                nif = model.nif,

            };
            return View(alunoViewModel);
        }

        // GET: Alunos/Create
        public IActionResult Create()
        {
            var aluno = new AlunoViewModel();
            aluno.turmas = GetTurma();
            return View(aluno);
        }
        private IEnumerable<SelectListItem> GetTurma()
        {
            var list = _context.Turmas.Select(c => new SelectListItem
            {
                Text = c.nome_turma,
                Value = c.Id.ToString()

            }).OrderBy(l => l.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(seleciona uma turma...)",
                Value = "0"
            });

            return list;

        }
        // POST: Alunos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AlunoViewModel alunoViewModel)
        {
            if (ModelState.IsValid)
            {
                var turma = await _context.Turmas.FirstOrDefaultAsync(t => t.Id == alunoViewModel.id_turma);
                if(turma == null)
                {
                    return NotFound();
                }
               
                var aluno = new Aluno
                {
                    cc = alunoViewModel.cc,
                    contacto = alunoViewModel.contacto,
                    cp_1 = alunoViewModel.cp_1,
                    cp_2 = alunoViewModel.cp_2,
                    email = alunoViewModel.email,
                    genero = alunoViewModel.genero,
                    nome = alunoViewModel.nome,
                    id_turma = alunoViewModel.id_turma,
                    ImageUrl = alunoViewModel.ImageUrl,
                    localidade = alunoViewModel.localidade,
                    Turma = turma,
                    morada = alunoViewModel.morada,
                    nif = alunoViewModel.nif,

                };

                _context.Add(aluno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(alunoViewModel);
        }

        // GET: Alunos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Alunos.Include(a => a.Turma)
                            .FirstOrDefaultAsync(m => m.Id == id.Value);
            if (model == null)
            {
                return NotFound();
            }
            var alunoViewModel = new AlunoViewModel
            {
                Id = model.Id,
                cc = model.cc,
                contacto = model.contacto,
                cp_1 = model.cp_1,
                cp_2 = model.cp_2,
                email = model.email,
                genero = model.genero,
                nome = model.nome,
                id_turma = model.id_turma,
                ImageUrl = model.ImageUrl,
                localidade = model.localidade,
                Turma = model.Turma,
                morada = model.morada,
                nif = model.nif,

            };

            return View(alunoViewModel);
        }

        // POST: Alunos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AlunoViewModel alunoViewModel)
        {
            if (id != alunoViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var turma = await _context.Turmas.FirstOrDefaultAsync(t => t.Id == alunoViewModel.id_turma);
                    if (turma == null)
                    {
                        return NotFound();
                    }

                    var aluno = new Aluno
                    {
                        Id = alunoViewModel.Id,
                        cc = alunoViewModel.cc,
                        contacto = alunoViewModel.contacto,
                        cp_1 = alunoViewModel.cp_1,
                        cp_2 = alunoViewModel.cp_2,
                        email = alunoViewModel.email,
                        genero = alunoViewModel.genero,
                        nome = alunoViewModel.nome,
                        id_turma = alunoViewModel.id_turma,
                        ImageUrl = alunoViewModel.ImageUrl,
                        localidade = alunoViewModel.localidade,
                        Turma = turma,
                        morada = alunoViewModel.morada,
                        nif = alunoViewModel.nif,

                    };
                    _context.Update(aluno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlunoModelExists(alunoViewModel.Id))
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
            alunoViewModel.turmas = GetTurma();
            return View(alunoViewModel);
        }

        // GET: Alunos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Alunos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {

                return NotFound();
            }
            var alunoViewModel = new AlunoViewModel
            {
                Id = model.Id,
                cc = model.cc,
                contacto = model.contacto,
                cp_1 = model.cp_1,
                cp_2 = model.cp_2,
                email = model.email,
                genero = model.genero,
                nome = model.nome,
                id_turma = model.id_turma,
                ImageUrl = model.ImageUrl,
                localidade = model.localidade,
                Turma = model.Turma,
                morada = model.morada,
                nif = model.nif,

            };
            return View(alunoViewModel);
        }

        // POST: Alunos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var model = await _context.Alunos.FindAsync(id);
            _context.Alunos.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlunoModelExists(int id)
        {
            return _context.Alunos.Any(e => e.Id == id);
        }
    }
}
