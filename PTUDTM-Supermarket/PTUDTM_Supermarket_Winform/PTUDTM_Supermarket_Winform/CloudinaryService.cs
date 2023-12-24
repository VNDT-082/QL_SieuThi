using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM_Supermarket_Winform
{
    public  class CloudinaryService
    {
        private Account account;
        private Cloudinary cloudinary;
        public CloudinaryService()
        {
            account = new Account(
              "dozsz2dqi",
              "453574262281117",
              "L6S4ZLeF6wI35ILMHuGseA0r6E0");

            cloudinary = new Cloudinary(account);

        }
        public Bitmap getBitMapImage(string originalUrl)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] imageData = webClient.DownloadData(originalUrl);

                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {

                    Bitmap bitmap = new Bitmap(memoryStream);
                    return bitmap;
                }
            }
        }
        public string Upload(OpenFileDialog openFileDialog)
        {
            if (openFileDialog != null)
            {
                ImageUploadParams uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(openFileDialog.FileName),
                    Folder = "QL_SieuThi"
                };

                ImageUploadResult uploadResult = cloudinary.Upload(uploadParams);

                string imageUrl = uploadResult.SecureUrl.ToString();
                return imageUrl;
            }
            return null;
        }
    }

}
