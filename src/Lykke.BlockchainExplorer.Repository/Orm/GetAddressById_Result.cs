//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lykke.BlockchainExplorer.Repository.Orm
{
    using System;
    
    public partial class GetAddressById_Result
    {
        public int Id { get; set; }
        public string Hash { get; set; }
        public string ColoredAddress { get; set; }
        public string UncoloredAddress { get; set; }
        public Nullable<decimal> Balance { get; set; }
    }
}