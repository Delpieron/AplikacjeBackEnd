namespace StoreApi
{
    /// <summary>
    /// Lista właściwości przedmiotów w tabeli
    /// </summary>
    public class Car
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Vin { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
    }
}
