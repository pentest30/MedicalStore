using MedicalStore.Core.Domain.Orders;
using System;
using System.Collections.Generic;

namespace MedicalStore.Core.Domain.Shipping
{
    public class Shipment: BaseEntity
    {
        /// <summary>
        /// The shipment items
        /// </summary>
        private ICollection<ShipmentItem> _shipmentItems;

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>
        /// The order.
        /// </value>
        public Order Order { get; set; }
        /// <summary>
        /// Gets or sets the order identifier.
        /// </summary>
        /// <value>
        /// The order identifier.
        /// </value>
        public int OrderId { get; set; }
        /// <summary>
        /// Gets or sets the on created.
        /// </summary>
        /// <value>
        /// The on created.
        /// </value>
        public DateTime  OnCreated{ get; set; }
        /// <summary>
        /// Gets or sets the tracking number.
        /// </summary>
        /// <value>
        /// The tracking number.
        /// </value>
        public string TrackingNumber { get; set; }
        /// <summary>
        /// Gets or sets the shipment items.
        /// </summary>
        /// <value>
        /// The shipment items.
        /// </value>
        public virtual ICollection<ShipmentItem> ShipmentItems
        {
            get { return _shipmentItems ?? (_shipmentItems = new List<ShipmentItem>()); }
            protected set { _shipmentItems = value; }
        }
    }
}
