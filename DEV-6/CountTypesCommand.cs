namespace DEV_6
{
    /// <summary>
    /// Сlass for counting number of brands
    /// </summary>
    class CountTypesCommand : ICommand
    {
        private Catalog Catalog { get; set; }

        /// <summary>
        /// Constructor initializes fields
        /// </summary>
        /// <param name="catalog"></param>
        public CountTypesCommand(Catalog catalog) => this.Catalog = catalog ;
        /// <summary>
        /// Calls method for catalog cars and displays number of brands
        /// </summary>
        /// <returns></returns>
        public string Execute()
        {
            return Catalog.GetCountTypes().ToString();
        }
    }
}
