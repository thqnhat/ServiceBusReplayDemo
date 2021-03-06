﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProductsServer.Domain
{
    // Define the data contract
    [DataContract]
    public class ProductData
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Quantity { get; set; }
    }

    // Define the service contract
    [ServiceContract]
    interface IProducts
    {
        [OperationContract]
        IList<ProductData> GetProducts();
    }
    
    interface IProductsChannel : IProducts, IClientChannel
    {

    } 
}
