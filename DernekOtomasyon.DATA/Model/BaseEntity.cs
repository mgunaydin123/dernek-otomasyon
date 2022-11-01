using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyon.DATA.Model
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public Nullable<DateTime> InsertedDate { get; set; }
        public Nullable<DateTime> UpdateDate { get; set; }
    }
}
