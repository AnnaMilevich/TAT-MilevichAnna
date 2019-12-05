namespace DEV_6
{
    /// <summary>
    /// Сlass for counting average price of cars
    /// </summary>
    class AveragePriceCommand : ICommand
    {
        private Catalog Catalog { get; set; }

        /// <summary>
        /// Constructor initializes fields
        /// </summary>
        /// <param name="catalog"></param>
        public AveragePriceCommand(Catalog catalog) => this.Catalog = catalog;

        /// <summary>
        /// Calls method for catalog cars and displays average price of cars
        /// </summary>
        /// <returns></returns>
        public string Execute()
        {
            return Catalog.GetAveragePrice().ToString();
        }
    }
}
