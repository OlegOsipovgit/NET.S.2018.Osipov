using System;
using System.IO;

namespace Task_2
{
    public abstract class Generator
    {
        public abstract string WorkingDirectory { get; }
        public abstract string FileExtension{get; }
        public abstract void GenerateFiles(int a, int b);
        public abstract byte[] GenerateFileContent(int a);
        public abstract void WriteBytesToFile(string a, byte[] content);

    }
    public class RandomBytesFileGenerator:Generator
    {
        public override string WorkingDirectory => "Files with random bytes";

        public override string FileExtension => ".bytes";

        public override void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        public override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }

        public override void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
        }
    }
}