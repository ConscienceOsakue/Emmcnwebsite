namespace Emmcnorb.Models
{
    //Models are typically responsible for retrieving and storing data
    //from and to a data store, such as a database
    public class AffinityHarmonyAnalyzer
    {
        //sample of my calculator then calling it in main.
        public int Userresponse { get; set; }
        public required string Username { get; set; } //I added required because they all non-nullable properties so the controller can process it.
        
    }
}
