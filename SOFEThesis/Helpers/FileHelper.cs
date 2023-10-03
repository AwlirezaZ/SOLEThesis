namespace SOFEThesis.Helpers
{
    public static class FileHelper
    {
        public static void SaveFile(IFormFile file)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Images");
            using (Stream fileStream = new FileStream($"{filePath}/{file.FileName}", FileMode.Create))
            {
                file.CopyToAsync(fileStream);
            }
        }
    }
}
