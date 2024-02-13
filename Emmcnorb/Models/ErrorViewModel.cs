namespace Emmcnorb.Models
{
    public class ErrorViewModel
    {
        //Models are typically responsible for retrieving and storing data
        //from and to a data store, such as a database
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
