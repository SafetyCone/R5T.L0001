﻿using System;


namespace R5T.L0001.Z000
{
    public class Values : IValues
    {
        #region Infrastructure

        public static IValues Instance { get; } = new Values();

        private Values()
        {
        }

        #endregion
    }
}
