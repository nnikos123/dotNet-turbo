﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qoollo.Turbo.Queues.DiskQueueComponents
{
    /// <summary>
    /// Indicates that item inside DiskQueueSegment is corrupted
    /// </summary>
    [Serializable]
    public class ItemCorruptedException : TurboException
    {
        /// <summary>
        /// ItemCorruptedException constructor
        /// </summary>
        public ItemCorruptedException() : base("Item is corrupted") { }
        /// <summary>
        /// ItemCorruptedException constructor
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        public ItemCorruptedException(string message) : base(message) { }
        /// <summary>
        /// ItemCorruptedException constructor
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        /// <param name="innerException">Inner exception</param>
        public ItemCorruptedException(string message, Exception innerException) : base(message, innerException) { }
        /// <summary>
        /// ItemCorruptedException constructor
        /// </summary>
        /// <param name="info">SerializationInfo</param>
        /// <param name="context">StreamingContext</param>
        protected ItemCorruptedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
