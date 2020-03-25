namespace OpenVentilatorRegistryWeb
{

    public class Hospital
    {
        /// <summary>
        /// Gets or sets the hospital name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the full address.
        /// </summary>
        public string FullAddress { get; set; }

        /// <summary>
        /// Gets or sets the NPI number.
        /// </summary>
        public int NPI { get; set; }

        /// <summary>
        /// Gets or sets the verified status of a hospital.
        /// </summary>
        public bool Verified { get; set; }

        /// <summary>
        /// Gets or sets the current ventilator count.
        /// </summary>
        public int CurrentVentilatorCount { get; set; }

        /// <summary>
        /// Gets or sets the current ventilator need.
        /// </summary>
        public int CurrentVentilatorNeed { get; set; }
    }
}
