using cabide_solidario.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cabide_solidario.Controllers
{
    
    public class RoupasDoadasController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public RoupasDoadasController(AppDbContext context, IWebHostEnvironment webHostEnvironment) 
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.RoupasDoadas.ToListAsync();

            return View(dados);
        }
        public async Task<IActionResult> Catalogo()
        {
            var dados = await _context.RoupasDoadas.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoupaDoada roupaDoada)
        {
            if (ModelState.IsValid)
            {
                if (roupaDoada.ImageUpload != null)
                {
                    string uploadsDir = Path.Combine(_webHostEnvironment.WebRootPath, "Produtos");
                    string imageName = Guid.NewGuid().ToString() + "_" + roupaDoada.ImageUpload.FileName;

                    string filePath = Path.Combine(uploadsDir, imageName);

                    FileStream fs = new FileStream(filePath, FileMode.Create);
                    await roupaDoada.ImageUpload.CopyToAsync(fs);
                    fs.Close();

                    roupaDoada.Imagem = imageName;
                }
                _context.RoupasDoadas.Add(roupaDoada);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }    
            
            return View(roupaDoada);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.RoupasDoadas.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, RoupaDoada roupaDoada )
        {
            if (id != roupaDoada.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.RoupasDoadas.Update(roupaDoada);
                await _context.SaveChangesAsync();
                TempData["Success"] = "O Produto foi adicionado";
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.RoupasDoadas.FindAsync(id);

            if(dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.RoupasDoadas.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.RoupasDoadas.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.RoupasDoadas.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
