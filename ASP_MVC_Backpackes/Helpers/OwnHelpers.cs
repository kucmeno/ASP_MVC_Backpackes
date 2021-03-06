﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Razor.Configuration;

namespace ASP_MVC_Backpackes.Helpers
{
    public static class OwnHelpers { 



        public static HtmlString but1(string action)
        {
            if (action == "Save")
                return new HtmlString("<input type=\"submit\" class=\"btn btn-warning\" value=\"Zapisz\" />");
            else if(action == "Delete")
                return  new HtmlString("<input type=\"submit\" class=\"btn btn-danger\" value=\"Usuń\" />");
            else if(action == "Details")
            {
                return new HtmlString("<input type=\"submit\" class=\"btn btn-primary\" value=\"Szczegóły\" />"); ;
            }else if (action == "Check")
            {
                return new HtmlString("<input type=\"submit\" class=\"btn btn-success\" value=\"Sprawdź\"/>");
            }
            else if(action == "Odbierz")
            {
                return  new HtmlString("<input type=\"submit\" class=\"btn btn-danger\" value=\"Odbierz\"/>");
            }
            else if (action == "Create")
            {
                return new HtmlString("<input type=\"submit\" class=\"btn btn-priamry\" value=\"Utwórz\"/>");
            }
            return new HtmlString("<input type=\"submit\" class=\"btn btn-primary\" value=\"Klik\" />");

        }

        public static string Capacity(decimal x)
        {
          
          return String.Format(x+" L");
        }
    }
}