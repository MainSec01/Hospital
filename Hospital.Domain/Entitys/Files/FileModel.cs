using Microsoft.AspNetCore.Http;

namespace Hospital.Domain.Entitys
{
    public class FileModel
    {
        public string FileName { get; set; }
        public IFormFile formFile { get; set; }
    }
}
