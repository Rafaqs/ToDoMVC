using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoMVC.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluido { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}