//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Core.Environments.Client.Http;



namespace Unity.Services.Core.Environments.Client.Models
{
    /// <summary>
    /// UnityUserOrganizationsV1OrganizationsInner model
    /// </summary>
    [Preserve]
    [DataContract(Name = "unity_UserOrganizations_v1_organizations_inner")]
    internal class UnityUserOrganizationsV1OrganizationsInner
    {
        /// <summary>
        /// Creates an instance of UnityUserOrganizationsV1OrganizationsInner.
        /// </summary>
        /// <param name="id">ID of the organization</param>
        /// <param name="genesisId">ID provided by Genesis</param>
        /// <param name="name">Name of the organization</param>
        /// <param name="role">Role of the user in the organization</param>
        /// <param name="address">address param</param>
        [Preserve]
        public UnityUserOrganizationsV1OrganizationsInner(System.Guid id = default, string genesisId = default, string name = default, string role = default, UnityAddressV1 address = default)
        {
            Id = id;
            GenesisId = genesisId;
            Name = name;
            Role = role;
            Address = address;
        }

        /// <summary>
        /// ID of the organization
        /// </summary>
        [Preserve]
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public System.Guid Id{ get; }
        
        /// <summary>
        /// ID provided by Genesis
        /// </summary>
        [Preserve]
        [DataMember(Name = "genesisId", EmitDefaultValue = false)]
        public string GenesisId{ get; }
        
        /// <summary>
        /// Name of the organization
        /// </summary>
        [Preserve]
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name{ get; }
        
        /// <summary>
        /// Role of the user in the organization
        /// </summary>
        [Preserve]
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public string Role{ get; }
        
        /// <summary>
        /// Parameter address of UnityUserOrganizationsV1OrganizationsInner
        /// </summary>
        [Preserve]
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public UnityAddressV1 Address{ get; }
    
        /// <summary>
        /// Formats a UnityUserOrganizationsV1OrganizationsInner into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Id != null)
            {
                serializedModel += "id," + Id + ",";
            }
            if (GenesisId != null)
            {
                serializedModel += "genesisId," + GenesisId + ",";
            }
            if (Name != null)
            {
                serializedModel += "name," + Name + ",";
            }
            if (Role != null)
            {
                serializedModel += "role," + Role + ",";
            }
            if (Address != null)
            {
                serializedModel += "address," + Address.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a UnityUserOrganizationsV1OrganizationsInner as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Id != null)
            {
                var idStringValue = Id.ToString();
                dictionary.Add("id", idStringValue);
            }
            
            if (GenesisId != null)
            {
                var genesisIdStringValue = GenesisId.ToString();
                dictionary.Add("genesisId", genesisIdStringValue);
            }
            
            if (Name != null)
            {
                var nameStringValue = Name.ToString();
                dictionary.Add("name", nameStringValue);
            }
            
            if (Role != null)
            {
                var roleStringValue = Role.ToString();
                dictionary.Add("role", roleStringValue);
            }
            
            return dictionary;
        }
    }
}
