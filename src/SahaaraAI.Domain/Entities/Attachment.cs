
namespace SahaaraAI.Domain.Entities;

public class Attachment
{
    public int Id { get; set; }
    public string FileName { get; set; }
    public string FileType { get; set; }
    public long FileSize { get; set; }
    public byte[] FileContent { get; set; }
    public string FilePath { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public bool IsDeleted { get; set; }

    public Attachment()
    {
        CreatedDate = DateTime.UtcNow;
        IsDeleted = false;
    }
}

