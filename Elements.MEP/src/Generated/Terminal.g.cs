//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Spatial;
using Elements.Validators;
using Elements.Serialization.JSON;
using Newtonsoft.Json;
using System;
using Elements.Flow;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements.Fittings
{
    #pragma warning disable // Disable all warnings

    /// <summary>A termination point of a piping system. Has a single connection.</summary>
    [JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Terminal : Fitting
    {
        [JsonConstructor]
        public Terminal(Port @port, Node @flowNode, PressureCalculationTerminal @pressureCalculations, double @staticPressure, bool @canBeMoved, FittingLocator @componentLocator, Transform @transform, Material @material, Representation @representation, bool @isElementDefinition, System.Guid @id, string @name)
            : base(canBeMoved, componentLocator, transform, material, representation, isElementDefinition, id, name)
        {
            this.Port = @port;
            this.FlowNode = @flowNode;
            this.PressureCalculations = @pressureCalculations;
            this.StaticPressure = @staticPressure;
            }
        
        // Empty constructor
        public Terminal()
            : base()
        {
        }
    
        /// <summary>The connector for this terminal.</summary>
        [JsonProperty("Port", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Port Port { get; set; }
    
        /// <summary>The Node served by this Terminal, if any.</summary>
        [JsonProperty("FlowNode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Node FlowNode { get; set; }
    
        /// <summary>The Pressure calculations</summary>
        [JsonProperty("Pressure Calculations", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PressureCalculationTerminal PressureCalculations { get; set; }
    
        /// <summary>The static pressure at the final termination.</summary>
        [JsonProperty("Static Pressure", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double StaticPressure { get; set; }
    
    
    }
}