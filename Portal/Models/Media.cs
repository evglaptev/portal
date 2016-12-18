using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal.Models
{
    enum Type { Audio,Document,Note,Photo,Video}
    public class Media
    {
        Type Type { get; set; }
        public int Id { get; set; }
        public int ContextUserId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public byte[] Data { get; set; }

    }
}