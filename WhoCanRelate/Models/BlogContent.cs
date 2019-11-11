using System;
using System.Collections.Generic;


namespace WhoCanRelate.Models
{
    public partial class BlogContent
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public byte[] Image { get; set; }
        public string Body { get; set; }
        public string Tag { get; set; }
        public byte[] Timestamp { get; set; }
        public string Author { get; set; }
    }
}
