namespace Polymorphism_S3.Entities
{
    public interface IPayable
    {
         public bool IsProcessed { get; set; }

        decimal GetAmount();
    }
}