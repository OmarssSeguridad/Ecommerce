using E_CommerceF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_CommerceF.Controllers
{
    public class FinanzasController : Controller
    {
        private ecommerceEntities db = new ecommerceEntities();
        // GET: Finanzas
        //0 Autorizado 1 Por autorizar 2 No autorizado
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Pedidos()
        {
            ViewBag.showSuccessAlert = false;
            var pedido = db.PEDIDO_PROVEEDOR.Where(d => d.ACTIVO == 0).OrderBy(d => d.ID);
            return View(pedido);
        }
        public ActionResult PedidosDetalles(int id)
        {
            var detalle = db.PEDIDO_PROVEEDOR.Find(id);
            return View(detalle);

        }
        [HttpPost]
        public ActionResult editPedidosDetalles(FormCollection formCollection)
        {
            string id = formCollection["id"];
            string estatus = formCollection["estatus"];
            string observaciones = formCollection["observaciones"];
            int e;
            var orden = db.PEDIDO_PROVEEDOR.Find(int.Parse(id));
            if (estatus.Equals("Autorizado"))
            {
                e = 0;
            }
            else
            {
                e = 2;
            }
            orden.AUTORIZADO = e;
            orden.OBSERVACIONES = observaciones;
            orden.FECHA_ACTUALIZACION = System.DateTime.Now;
            db.Entry(orden).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            ViewBag.showSuccessAlert = true;
            return RedirectToAction("Pedidos", "Finanzas");
        }
        public ActionResult Precios()
        {
            var precios = db.HISTORIAL_PRECIO.Where(d => d.STATUS == 1);

            return View(precios);
        }
        public ActionResult PreciosDetalles(int id)
        {
            var detalle = db.HISTORIAL_PRECIO.Find(id);
            return View(detalle);
        }
        public ActionResult PreciosHistorial(int id)
        {
            var detalle = db.HISTORIAL_PRECIO.Where(d => d.FK_PRODUCTOS == id & (d.STATUS == 0 || d.STATUS == 2)).OrderBy(d => d.Id);
            return View(detalle);
        }
        
        public ActionResult aceptarPrecio(FormCollection formCollection)
        {
            String id = formCollection["id"];
            int e = 0;
            var precio = db.HISTORIAL_PRECIO.Find(int.Parse(id));
            var producto = db.PRODUCTO.Find(precio.PRODUCTO.ID);
            producto.PRECIO = precio.PRECIO;
            precio.FECHA_ACTUALIZACION = System.DateTime.Now;
            db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
            precio.STATUS = e;
            db.Entry(precio).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Precios", "Finanzas");

            }
        [HttpPost]
        public ActionResult rechazarPrecio(FormCollection formCollection)
        {


            return View();
        }
        [HttpPost]
        public ActionResult editPreciosDetalles(FormCollection formCollection)
        {

            String id = formCollection["id"];
            string estatus = formCollection["estatus"];
            string observaciones = formCollection["observaciones"];
            int e;
            var precio = db.HISTORIAL_PRECIO.Find(int.Parse(id));
            if (estatus.Equals("Autorizar"))
            {
                e = 0;
                var producto = db.PRODUCTO.Find(precio.PRODUCTO.ID);
                producto.PRECIO = precio.PRECIO;
                precio.FECHA_ACTUALIZACION = System.DateTime.Now;
                db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                e = 2;
            }

            precio.STATUS = e;
            precio.OBSERVACIÓN = observaciones;

            db.Entry(precio).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();

            return RedirectToAction("Precios", "Finanzas");

        }
        public ActionResult BalanceGeneral()
        {
            var balance = db.PEDIDO_PROVEEDOR.Where(d => d.AUTORIZADO == 0);
            ViewBag.Total = db.PEDIDO_PROVEEDOR.Where(d => d.AUTORIZADO == 0).Sum(d => d.PRECIO_TOTAL);
            ViewBag.Compras = db.ORDEN;
            ViewBag.TotalCompras = db.ORDEN.Sum(d => d.TOTAL);


            return View(balance);
        }




    }
}
 