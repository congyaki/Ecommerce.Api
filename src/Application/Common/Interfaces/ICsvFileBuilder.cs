using Ecommerce.API.Application.TodoLists.Queries.ExportTodos;

namespace Ecommerce.API.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
