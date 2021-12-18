namespace DjurDagis.Entities
{
    public interface IOtherServices
    {
        public string Name { get; }
        public string Description { get; }
       // public string Price { get; }
        public bool TrueOrFalse { get; set; } //For any possible preference 
    }
}