using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.Entities
{
    public class Seat
    {
        public int id { get; set; }
        public int row { get; set; }
        public int column { get; set; }
        public int roomId { get; set; }
        public int isAvaliable { get; set; }
}
}
