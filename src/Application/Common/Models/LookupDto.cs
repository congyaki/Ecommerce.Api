using Ecommerce.API.Application.Common.Mappings;
using Ecommerce.API.Domain.Entities;

namespace Ecommerce.API.Application.Common.Models;

// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public string? Title { get; set; }
}
