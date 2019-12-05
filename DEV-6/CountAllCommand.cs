namespace DEV_6
{
    /// <summary>
    /// Сlass for counting number of cars
    /// </summary>
    class CountAllCommand : ICommand
    {
        private Catalog Catalog { get; set; }

        /// <summary>
        /// Constructor initializes fields
        /// </summary>
        /// <param name="catalog"></param>
        public CountAllCommand(Catalog catalog) => this.Catalog = catalog;
        /// <summary>
        /// Calls method for catalog cars and displays number of cars
        /// </summary>
        /// <returns></returns>
        public string Execute()
        {
            return Catalog.GetCountAll().ToString();
        }
    }
}
