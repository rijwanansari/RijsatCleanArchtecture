using Domain.Master;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IApplicationDBContext
    {
        DbSet<AppSetting> AppSettings { get; set; }
        Task<int> SaveChangesAsync();
    }
}
