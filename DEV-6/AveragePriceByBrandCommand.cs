namespace DEV_6
{
    /// <summary>
    /// Сlass for counting average price for a specific brand
    /// </summary>
    class AveragePriceByBrandCommand : ICommand
    {
        private Catalog Catalog { get; set; }
        private string Brand { get; set; }

        /// <summary>
        /// Constructor initializes fields
        /// </summary>
        /// <param name="catalog"></param>
        /// <param name="brand"></param>
        public AveragePriceByBrandCommand(Catalog catalog, string brand)
        {
            Catalog = catalog;
            Brand = brand;
        }
        /// <summary>
        /// Calls method for catalog cars and displays average price of a specific brand cars
        /// </summary>
        /// <returns></returns>
        public string Execute()
        {
            return Catalog.GetAveragePriceByBrand(Brand).ToString();
        }
    }
}
