using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace image_upload_api.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] ProfilePic { get; set; }
    }
}
