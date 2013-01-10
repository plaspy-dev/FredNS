using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using SDG.Componentes;

public partial class ingreso : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CUsuario usuario = (CUsuario)Usuario.GetUsuario();
        if(!IsPostBack) {
            
            HEspanol.NavigateUrl = Request.Url.AbsolutePath + "?lang=es";
            HIngles.NavigateUrl = Request.Url.AbsolutePath + "?lang=en";

            LUsuario.Text = usuario.GetNombre() + GetGlobalResourceObject("textos", "conip").ToString() + " " + Request.ServerVariables["REMOTE_ADDR"];

            CConector conector = new CConector();
            LEstadisticas.Text = conector.QueryString("SELECT COUNT(*) FROM usuarios") + GetGlobalResourceObject("textos", "usuarios").ToString();
            LEstadisticas.Text += Directory.GetFiles(ConfigurationSettings.AppSettings["ZonesFiles"]).Length + " " + GetGlobalResourceObject("textos", "dominio").ToString() + "s.";
        }
    }
}
