using Microsoft.EntityFrameworkCore;
using RawLibrary.Model;

namespace RawLibrary.Data;

public class BookContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    private string DbPath { get; }

    public BookContext()
    {
        const Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
        string path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "library.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}