using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Mysqlx.Prepare;
using PI_Entra21_Back_end.DTO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace PI_Entra21_Back_end.Controllers
{
    [ApiController]
    [Route("file")]
    public class FileController : ControllerBase
    {
                
        [HttpPost("Upload")]
        public async Task<ActionResult> Upload([FromForm] ICollection<IFormFile> file)
        {
            if (file == null || file.Count == 0)
                return BadRequest();
            List<byte[]> data = new();
            string uploads = Path.Combine("C:\\Users\\ricardo.mandarino\\Desktop\\PI\\Imagens");
            string filePath = "";


            foreach (IFormFile formFile in file)
            {
                var date = DateTime.Now.ToString();
                date = date.Replace(" ", "-");
                date = date.Replace('/', '.');
                date = date.Replace(':', '.');
                var fileName = date + formFile.FileName;
                    filePath = Path.Combine(uploads, fileName);
                using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(fileStream);
                }
            }
            return Ok(new
            {   
                status = true,
                message = "Arquivo Inserido",
                data = new {path = filePath},
                caminho = filePath
                
            });
        }

    }
}
