using DATA;
using DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace velaMaryWebApp.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product
        public ActionResult Index()
        {
            MapProduct mapProduct = new MapProduct();
            MapCollection mapCollection = new MapCollection();

            //Load nhiều nhất là 50 product
            List <tb_product> listProduct = mapProduct.findAllProduct();
            List <tb_collection> listCollection = mapCollection.findAllCollection();

            var model = new Tuple<List<tb_product>, List<tb_collection>>(listProduct, listCollection);
            return View(model);
        }


        [HttpPost]
        public ActionResult Update(int ProductId, string ProductName, int Price, int Quantity, int CollectionId)
        {
            tb_product product = new tb_product()
            {
                // Assuming these are the properties of tb_product, adjust as needed
                product_id = ProductId,
                name = ProductName,
                price = Price,
                quantity = Quantity,
                collection_id = CollectionId
            }; 
            MapProduct mapProduct = new MapProduct();
            bool saveSucess = mapProduct.updateProduct(product);
            if (saveSucess)
            {
                ViewBag.Alert = "Update thành công";
            } else ViewBag.Alert = "Update failed";
            return RedirectToAction("Index", "Product", new { area = "Admin" });
        }
        public ActionResult deleteProduct()
        {
            return View();
        }
        public ActionResult addProduct()
        {
            return View();
        }
    }
}