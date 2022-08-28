using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using xcifytest.Models;

namespace xcifytest.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product


        private XcifySampleTestDB1Entities objProductDbEntities;

        public ProductController()
        {
            objProductDbEntities = new XcifySampleTestDB1Entities();
        }
        public ActionResult Index()
        {

            
            return View();
        }

        public JsonResult GetAllProduct()
        {
            var ProductGet = (from obj in objProductDbEntities.tblProducts select
                              new
                              {
                                  Name = obj.Name,
                                  Price= obj.Price
                              }

                            ).ToList();
            return Json(data:new {Success=true,data=ProductGet }, JsonRequestBehavior.AllowGet);
        }
    }
}