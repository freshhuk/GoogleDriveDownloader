using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIGoogleDriveDownloader.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIGoogleDriveDowloader : ControllerBase
    {
        /// <summary>
        /// Этот контролер служит для отправки всех запросов на разные сервисы
        /// Тип с него отправить запрос на загрузку файлов на проект и если успешно
        /// сохранилось то тогда этот файл загрузить на гугл диск спомощу другого класа
        /// </summary> 
        private readonly ILogger<APIGoogleDriveDowloader> _logger;
        public APIGoogleDriveDowloader(ILogger<APIGoogleDriveDowloader> logger)
        {
            _logger = logger;
        }
       
        [HttpPost("UpLoadOnDrive")]
        public async Task<IActionResult> UpLoadOnDrive(IFormFile uploadedFile)
        {

            return Ok();
        }
    }
}
