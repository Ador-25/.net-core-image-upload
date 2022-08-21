using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace image_upload_api.Forms
{
    public class FileViewModel
    {
        public string Name { get; set; }
        public IFormFile File { get; set; }
        public List<IFormFile> Files { get; set; }
    }
}
