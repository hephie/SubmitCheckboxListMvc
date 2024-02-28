using System.Collections.Generic;
using System.Web.Mvc;

namespace WebApplication1.Areas.Test.Controllers
{
    public class ZController : Controller
    {
        public ActionResult Index(int? id)
        {
            var model = new ZModel()
            {
                Id = 1,
                Items = new List<ZItem>()
                {
                    new ZItem() { Name = "Thomas", Selected = true},
                    new ZItem() { Name = "Yassine", Selected = false}
                }
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(ZModel model)
        {
            var x = model.Id;

            return View("Index", model);
        }
    }

    public class ZModel
    {
        public int Id { get; set; }

        public List<ZItem> Items { get; set; }
    }

    public class ZItem
    {
        public string Name { get; set; }

        public bool Selected { get; set; }
    }
}