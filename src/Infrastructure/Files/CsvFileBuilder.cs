using System.Globalization;
using Ecommerce.API.Application.Common.Interfaces;
using Ecommerce.API.Application.TodoLists.Queries.ExportTodos;
using Ecommerce.API.Infrastructure.Files.Maps;
using CsvHelper;

namespace Ecommerce.API.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
