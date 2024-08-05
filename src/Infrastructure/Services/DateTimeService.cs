using Ecommerce.API.Application.Common.Interfaces;

namespace Ecommerce.API.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
