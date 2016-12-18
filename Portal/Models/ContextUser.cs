using System.Collections.Generic;

namespace Portal.Models
{
    public class ContextUser
    {
        public int Id { get; set; }
        public List<Note> Note { get; set; }

    }
}