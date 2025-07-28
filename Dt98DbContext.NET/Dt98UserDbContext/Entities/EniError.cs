using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class EniError
    {
        #region Public Constructors

        public EniError()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }
        public string Service { get; set; }
        public string MessageId { get; set; }
        public string MessageType { get; set; }
        public int MessageNumber { get; set; }
        public string MessageText { get; set; }
        public int HostDeliveryState { get; set; }
        public DateTime DateTime { get; set; }

        #endregion Public Properties
    }
}