using Microsoft.AspNetCore.Hosting.Server;

namespace SOFEThesis.Helpers
{
    public static class FileHelper
    {
        public static async Task SaveFile(IFormFile file)
        {
            string filePath = $"wwwroot/Images/{file.FileName}";
            await using Stream fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
        }
    }
}
