using MyBlazorApp.Domain.Contracts;
using MyBlazorApp.Domain.Entities.Misc;

namespace MyBlazorApp.Domain.Entities.ExtendedAttributes
{
    public class DocumentExtendedAttribute : AuditableEntityExtendedAttribute<int, int, Document>
    {
    }
}