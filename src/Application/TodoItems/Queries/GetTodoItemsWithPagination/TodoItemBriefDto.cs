using Ecommerce.API.Application.Common.Mappings;
using Ecommerce.API.Domain.Entities;

namespace Ecommerce.API.Application.TodoItems.Queries.GetTodoItemsWithPagination;

public class TodoItemBriefDto : IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }
}
