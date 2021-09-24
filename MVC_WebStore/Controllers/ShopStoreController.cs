using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_ADM.Models;
using Newtonsoft.Json;


namespace MVC_WebStore.Controllers
{
    public class ShopStoreController : Controller
    {
        // GET PRODUCTS AND DETAILS \\


        public IActionResult Index()
        {
            List<Product> lst = new List<Product>();
            try
            {
                //Connect To API using class Helper
                ApiConnector ac = new ApiConnector();
                string result = ac.Get(ConstantsProduct.APIController + ConstantsProduct.APIController_Action_Get);

                // convert Json
                lst = JsonConvert.DeserializeObject<List<Product>>(result);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return View(lst);
        }


        public ActionResult Details(int id)
        {
            Product product = new Product();
            try
            {
                //Connect To API using class Helper
                ApiConnector ac = new ApiConnector();
                string result = ac.GetId(ConstantsProduct.APIController + ConstantsProduct.APIController_Action_GetId, id);
                //Convert Json
                product = JsonConvert.DeserializeObject<Product>(result);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return View(product);
        }



        // CREATE AND DELETE A NEW ORDER \\ em desesnvolvimento

        // GET: Order/Edit/5
        public ActionResult AddOrder(int id)
        {
            Order order = new Order();
            try
            {
                //Connect To API using class Helper
                ApiConnector ac = new ApiConnector();
                string result = ac.GetId(ConstantsProduct.APIController + ConstantsProduct.APIController_Action_GetId, id);
                // Convert Json
                order = JsonConvert.DeserializeObject<Order>(result);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return View(order);
        }

        // POST: Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddOrder(int id, IFormCollection collection)
        {
            Order obj = new Order();
            foreach (var item in collection)
            {
                switch (item.Key)
                {
                    case "OrderId":
                        obj.OrderId = int.Parse(item.Value);
                        break;
                    case "UserId":
                        obj.UserId = int.Parse(item.Value);
                        break;
                    //case "ProductId":
                    //    obj.ProductId = int.Parse(item.Value);
                    //    break;
                    case "Quantity":
                        obj.Quantity = int.Parse(item.Value);
                        break;
                    case "Price":
                        obj.Price = decimal.Parse(item.Value);
                        break;
                }
            }
            // Convert Json
            string data = JsonConvert.SerializeObject(obj);

            //Connect To API using class Helper
            ApiConnector ac = new ApiConnector();
            string result = ac.Put(ConstantsOrder.APIController + ConstantsOrder.APIController_Action_Put + obj.OrderId, data);
            return RedirectToAction(nameof(Index));
        }

        // GET: Categorys/Delete/5
        public ActionResult Delete(int id)
        {
            Order order = new Order();
            try
            {
                //Connect To API using class Helper
                ApiConnector ac = new ApiConnector();
                string result = ac.GetId(ConstantsCategory.APIController + ConstantsCategory.APIController_Action_GetId, id);
                // Convert Json
                order = JsonConvert.DeserializeObject<Order>(result);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return View(order);
        }

        // POST: Categorys/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Order obj = new Order();
                foreach (var item in collection)
                {
                    switch (item.Key)
                    {
                        case "OrderId":
                            obj.OrderId = int.Parse(item.Value);
                            break;
                        case "UserId":
                            obj.UserId = int.Parse(item.Value);
                            break;
                        //case "ProductId":
                        //    obj.ProductId = int.Parse(item.Value);
                        //    break;
                        case "Quantity":
                            obj.Quantity = int.Parse(item.Value);
                            break;
                        case "Price":
                            obj.Price = decimal.Parse(item.Value);
                            break;
                    }
                }
                string data = JsonConvert.SerializeObject(obj);

                //Connect To API using class Helper
                ApiConnector ac = new ApiConnector();
                string result = ac.Delete(ConstantsOrder.APIController + ConstantsOrder.APIController_Action_Del + obj.OrderId, data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }




        // FILTER  PRODUCTS BY CATEGORY \\


        // filter by Category
        public IActionResult GetPlants()
        {
            List<Product> lst = new List<Product>();
            try
            {
                //Connect To API using class Helper
                ApiConnector ac = new ApiConnector();
                string result = ac.Get(ConstantsProduct.APIController + ConstantsProduct.APIController_Action_Get);

                // convert Json
                lst = JsonConvert.DeserializeObject<List<Product>>(result);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }

            var lst2 = new List<Product>();
            foreach (var item in lst)
            {
                if (item.CategoryId == 1)
                {
                    lst2.Add(item);
                }
            }
            return View(lst2);
        }

        // filter by Category
        public IActionResult GetFlowers()
        {
            List<Product> lst = new List<Product>();
            try
            {
                //Connect To API using class Helper
                ApiConnector ac = new ApiConnector();
                string result = ac.Get(ConstantsProduct.APIController + ConstantsProduct.APIController_Action_Get);

                // convert Json
                lst = JsonConvert.DeserializeObject<List<Product>>(result);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }

            var lst2 = new List<Product>();
            foreach (var item in lst)
            {
                if (item.CategoryId == 2)
                {
                    lst2.Add(item);
                }
            }
            return View(lst2);
        }

        // filter by Category
        public IActionResult GetProdsCult()
        {
            List<Product> lst = new List<Product>();
            try
            {
                //Connect To API using class Helper
                ApiConnector ac = new ApiConnector();
                string result = ac.Get(ConstantsProduct.APIController + ConstantsProduct.APIController_Action_Get);

                // convert Json
                lst = JsonConvert.DeserializeObject<List<Product>>(result);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }

            var lst2 = new List<Product>();
            foreach (var item in lst)
            {
                if (item.CategoryId == 3)
                {
                    lst2.Add(item);
                }
            }
            return View(lst2);
        }
    }
}
