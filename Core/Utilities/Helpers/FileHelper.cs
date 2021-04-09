using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers
{
    public  class FileHelper 
    {
       
        public static string FileAdd(IFormFile formFile)
        {
            var sourcePath = Path.GetTempFileName();
            if (formFile.Length>0)
            {
                using (var upload = new FileStream(sourcePath, FileMode.Create))
                {
                    formFile.CopyTo(upload);
                }
            }
            var result = NewPath(formFile);
            File.Move(sourcePath,@"wwwroot"+ result);
            return result;
        }
        public static IResult FileDelete(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception e)
            {

                return new ErrorResult(e.Message);

            }
            return new SuccessResult();
        }
        public static string FileUpdate(string sourcePath,IFormFile formFile)
        {
            var result = NewPath(formFile).ToString();

            if (sourcePath.Length > 0)
            {
                using ( var stream=new FileStream(result, FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return result;
            
        }
        public static string NewPath(IFormFile formFile)
        {
            FileInfo fileInfo = new FileInfo(formFile.FileName);
            string fileExtension = fileInfo.Extension;
           // string path = Environment.CurrentDirectory + @"\CarImages";
            var newPath = Guid.NewGuid().ToString() + fileExtension;
            string result = $@"\Images\{newPath}";
            return result;

        }

    }
}
