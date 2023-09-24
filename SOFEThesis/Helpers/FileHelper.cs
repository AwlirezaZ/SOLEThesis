namespace SOFEThesis.Helpers
{
    public static class FileHelper
    {
        public static void SaveFile(IFormFile file)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Images");
            FileInfo fileInfo = new FileInfo(filePath);
            fileInfo.IsReadOnly = false;
            using (Stream fileStream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyToAsync(fileStream);
            }
        }
    }
}
