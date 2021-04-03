namespace StarlingBank.Utilities
{
    public enum ArrayDeserialization
    {
        /// <summary>
        /// Example: variableName[0] = value1
        /// </summary>
        INDEXED = 0,
        /// <summary>
        /// Example: variableName[] = value1
        /// </summary>
        UN_INDEXED = 1,
        /// <summary>
        /// Example: variableName = value1, variableName = value 2
        /// </summary>
        PLAIN = 2,
        /// <summary>
        /// Example: variableName = value1,value2
        /// </summary>
        CSV = 3,
        /// <summary>
        /// Example: variableName = value1\tvalue2
        /// </summary>
        TSV = 4,
        /// <summary>
        /// Example: variableName = value1|value2
        /// </summary>
        PSV = 5,
        /// <summary>
        /// Example: Ignore format
        /// </summary>
        NONE = 6
    }
}