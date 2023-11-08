using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace APIGoogleDriveDownloader.Controllers
{
    [Route("filedowloader")]
    [ApiController]
    public class FileDownloader : ControllerBase
    {
        public async Task<IActionResult> DowloadFile(IFormFile uploadedFile)
        {
            try
            {
                if (uploadedFile != null && uploadedFile.Length > 0)
                {
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + uploadedFile.FileName;//Генерация уникального имени
                    string filePath = Path.Combine("~/TemporaryStorage/", uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await uploadedFile.CopyToAsync(fileStream);
                    }
                    // В этой точке файл сохранен на сервере в указанной папке по пути filePath.

                    return Ok();
                }
                else
                {
                    return BadRequest("File is null");
                }
                
            }
            catch (Exception ex )
            {
                return BadRequest($"Error {ex}");               
            }           
       
        }
    }
}
