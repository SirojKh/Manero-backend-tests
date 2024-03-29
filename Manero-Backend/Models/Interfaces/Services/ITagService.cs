using Manero_Backend.Models.Dtos.Tag;
using Manero_Backend.Models.Entities;

namespace Manero_Backend.Models.Interfaces.Services;

public interface ITagService : IBaseService<TagRequest, TagResponse, TagEntity>
{
    Task<TagEntity> GetOrCreateAsync(TagRequest entityTag);
}