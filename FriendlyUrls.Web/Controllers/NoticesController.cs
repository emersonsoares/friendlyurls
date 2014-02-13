using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using FriendlyUrls.Web.Models;

namespace FriendlyUrls.Web.Controllers
{
    public class NoticesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public NoticesController()
        {
            _db = new ApplicationDbContext();
        }

        public async Task<ActionResult> Index()
        {
            return View(await _db.Notices.ToListAsync());
        }

        public async Task<ActionResult> Details(string slug)
        {
            if (string.IsNullOrEmpty(slug))
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var notice = await (from n in _db.Notices where n.Slug == slug select n).FirstOrDefaultAsync();

            if (notice == null)
                return HttpNotFound();

            return View(notice);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
