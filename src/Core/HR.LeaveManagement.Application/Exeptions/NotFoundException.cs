namespace HR.LeaveManagement.Application.Exeptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object key) : base($"{name}" )
        { 

        }
    }
}
