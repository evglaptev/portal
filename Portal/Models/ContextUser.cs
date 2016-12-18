using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Portal.Models
{
    public class ContextUser
    {
        public int Id { get; set; }

        public ICollection<Photo> Photos { get; set; }
        public ICollection<Audio> Audios { get; set; }
        public ICollection<Document> Documents { get; set; }
        public ICollection<Video> Videos { get; set; }
        public ICollection<Note> Notes { get; set; }

        public ContextUser()
        {
            Photos = new List<Photo>();
            Audios = new List<Audio>();
            Videos = new List<Video>();
            Documents = new List<Document>();
            Notes = new List<Note>();
        }

        public List<int> NoteId { get; set; }
        public List<int> PhotoId { get; set; }
        public List<int> AudioId { get; set; }
        public List<int> VideoId { get; set; }
        public List<int> DocumentId { get; set; }

        [Display(Name="Прозвище")]
        public string NickName { get; set; }
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        [Display(Name = "Дата Рождения")]
        public DateTime DateTime { get; set; }
        [Display(Name = "Пол")]
        public string Sex { get; set; }
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }


    }
}