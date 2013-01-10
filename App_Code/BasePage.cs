using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.Threading;

public class BasePage : System.Web.UI.Page
{
	public BasePage()
	{
	}

    protected override void InitializeCulture()  
    {
        string idioma=CConector.GetCookie("lang");
        if (Request.QueryString["lang"] != null)
        {
            idioma = Request.QueryString["lang"];
            CConector.SetCookie("lang", idioma);
        }
        if(idioma!="") {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(idioma);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma);
        }
        base.InitializeCulture();
    }
}
