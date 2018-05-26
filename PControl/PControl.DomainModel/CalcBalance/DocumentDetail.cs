namespace PControl.DomainModel.CalcBalance
{
    public class DocumentDetail
    {
        public long Id { get; set; }
        public Document Document { get; set; }
        public Product Product { get; set; }
        public double Quantity { get; set; }
    }
}