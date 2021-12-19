using OyunProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProject.Entities
{
   public  class Games:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
