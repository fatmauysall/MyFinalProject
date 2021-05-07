using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{

    //çıplak class kalmasın çck 
    public class Category:IEntity //isaretleme
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
