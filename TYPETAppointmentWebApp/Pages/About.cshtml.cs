using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TYPETAppointmentWebApp.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Πλατφόρμα για online κλείσιμο με ιατρούς στο Τ.Υ.Π.Ε.Τ.";
        }
    }
}
