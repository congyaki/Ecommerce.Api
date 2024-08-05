using System.Globalization;
using Ecommerce.API.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace Ecommerce.API.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
