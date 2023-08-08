namespace LibraryManagementSystem.Service.Exceptions
{
    public class NotFoundException : BaseException
    {
        public NotFoundException(string entityName, object entityId)
            : base($"{entityName} with ID '{entityId}' not found.")
        {
        }
    }
}