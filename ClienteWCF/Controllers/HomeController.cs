using ClienteWCF.ServiceReferenceUsuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClienteWCF.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Obtener(string u_idu, string u_nombre)
        {
            try
            {
                using (ServiceClient wcf = new ServiceClient())
                {
                    List<BE> ls = wcf.ObtenerListaUs(u_idu, u_nombre).ToList();
                    return View(ls);
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                List<BE> ls = new List<BE>();
                return View(ls);
            }
        }
        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult AgregarPost(string u_idu, string u_nombre, string u_paterno, string u_materno, int u_edad=0)
        {
            try
            {
                using (ServiceClient wcf = new ServiceClient())
                {
                        wcf.AgregarUsuario(u_nombre, u_paterno, u_materno, u_edad);
                        //return View("Obtener", wcf.ObtenerListaUs(u_idu, u_nombre).ToList());
                        TempData["resu"] = "Registro guardado";
                    
                    return View("Agregar");
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("Agregar");
            }
        }

        public ActionResult Actualizar() 
        {
            return View();
        }
        public ActionResult ActualizarUsuario(string u_idu, string u_nombre, string u_paterno, string u_materno, int u_edad=0)
        {
            using (ServiceClient wcf = new ServiceClient())
            {
                wcf.ActualizarUsu(u_idu, u_nombre, u_paterno, u_materno, u_edad);
                return View("Obtener", wcf.ObtenerListaUs(u_idu, u_nombre).ToList());
                TempData["resu"] = "Registro Actualizado";
            }
        }

        public ActionResult Delete(string u_idu, string u_nombre)
        {
            using (ServiceClient wcf = new ServiceClient())
            {
                try
                {
                    wcf.Eliminar(u_idu);
                    TempData["resu"] = "Registro Eliminado";
                }
                catch (Exception ex)
                {
                    TempData["error"] = ex.Message;
                }
                return RedirectToAction("Obtener", wcf.ObtenerListaUs(u_idu,u_nombre).ToList());
            }

        }
    }
}