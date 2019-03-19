using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhoCanRelate.Models
{
    public class ContentModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte[] Image { get; set; }
        public string Body  { get; set; }
        public string Tags  { get; set; }
        public string Author { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
