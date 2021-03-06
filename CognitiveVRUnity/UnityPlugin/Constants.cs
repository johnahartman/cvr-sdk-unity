﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CognitiveVR
{
    public static class Constants
    {
        public const int DEFAULT_REQUEST_TIMEOUT = 3000; // in ms
        public const string TXN_SUCCESS = "success";
        public const string TXN_ERROR = "error";
        public const string ENTITY_TYPE_USER = "USER";
        public const string ENTITY_TYPE_DEVICE = "DEVICE";

        public const string TIMEOUT_MODE_TRANSACTION = "TXN";
        public const string TIMEOUT_MODE_ANY = "ANY";

        public const string PROPERTY_ISNEW = "_COGNITIVEVR_isNew";
        internal const double TIME_RECORDAGAIN = 8.0*60.0*60.0;  // only record each 8 hours
    }
}
