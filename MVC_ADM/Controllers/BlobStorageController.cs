using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace MVC_ADM.Controllers
{
    public class BlobStorageController : Controller
    {
        // Upload Fotos
        [HttpPost]
        public IActionResult UpLoadImg(List<IFormFile> arquivos)
        {
            // Ligar ao serviço Storage
            string containername = "alexandreCouto_projeto";
            BlobServiceClient bsc = new BlobServiceClient("DefaultEndpointsProtocol=https;AccountName=asprojeto;AccountKey=a0B+PPewtIG4+ngBo/4uXdEnNq/RGCvVESJat3kcNOdmYTydATc8ik9Y7oumfAJOEJXvfyF5lP3zjOGROOPguA==;EndpointSuffix=core.windows.net");
            BlobContainerClient bcc = bsc.GetBlobContainerClient(containername);
            //Se não existir ele cria:
            bool bbcExists = bcc.Exists();
            if (bbcExists != true)
            {
                bcc = bsc.CreateBlobContainer(containername);
            }


            foreach (var I in arquivos)
            {
                var localFileName = Path.GetFileName(I.FileName);
                BlobClient bc = bcc.GetBlobClient(localFileName);
                MemoryStream ms = new MemoryStream();
                I.CopyTo(ms);
                ms.Position = 0;
                bc.Upload(ms, true);
            }

            //pesquisar metodo opara adicionar referencia
            return View();
        }
    }
}
