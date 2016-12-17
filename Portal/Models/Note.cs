using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal.Models
{
    public class Note
    {
        User author;
        int authorId;
        string title;
        DateTime createDateTime;
        String message;
    }
}