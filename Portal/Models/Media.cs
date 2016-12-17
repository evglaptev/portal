using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal.Models
{
    public class Media
    {
        int id;
        ApplicationUser author;
        int authorId;
        byte[] data;
    }
}