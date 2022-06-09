using System;


namespace R5T.L0001.Z000
{
    public class Values : IValues
    {
        #region Infrastructure

        public static Values Instance { get; } = new();

        private Values()
        {
        }

        #endregion
    }
}
