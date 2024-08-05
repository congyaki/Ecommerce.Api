using Ecommerce.API.Application.Common.Mappings;
using Ecommerce.API.Domain.Entities;

namespace Ecommerce.API.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
