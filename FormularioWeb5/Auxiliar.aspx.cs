using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormularioWeb5
{
    public partial class Auxiliar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadSession();
            deleteSessions();
        }

        private void LoadSession()
        {
            string nombre = (string)(Session["Nombre"]);
            string apellidos = (string)(Session["Apellidos"]);
                                                          
            LabelUsuario.Text = "Enviado por Sesion: ";                                 // Asignacion de la informacion a los campos HTML respectivos
            LabelNombre.Text = "Nombre: " + nombre;
            LabelApellidos.Text = "Apellido: " + apellidos;
        }

        protected void MostrarCookie_Click(object sender, EventArgs e)
        {
            HttpCookie miCookie = Request.Cookies["MiCookie"];                          // Obtener la cookie

            if (miCookie != null)
            {
                string nombre = miCookie["Nombre"];                                     // Obtener los valores de la cookie y mostrarlos en el TextBox
                string apellidos = miCookie["Apellidos"];
                txtCookieInfo.Text = "Nombre: " + nombre + Environment.NewLine + "Apellidos: " + apellidos;
            }

            else
            { txtCookieInfo.Text = "Cookie no encontrada";}
        }
  
        private void deleteSessions()
        {
            Session.RemoveAll();
            Session.Abandon();
        }

      
    }
}
