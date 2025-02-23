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
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements.Fittings
{
    #pragma warning disable // Disable all warnings

    /// <summary>The pressure calculation data for a manifold</summary>
    [JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PressureCalculationManifold : PressureCalculationBase
    {
        [JsonConstructor]
        public PressureCalculationManifold(IList<double> @zLosses, IList<double> @flows, IList<double> @diameters, IList<double> @heightDeltas, IList<double> @staticGains, IList<double> @lengths, IList<double> @pipeLosses, double @flow, double @diameter, System.Guid @elementId)
            : base(elementId)
        {
            this.ZLosses = @zLosses;
            this.Flows = @flows;
            this.Diameters = @diameters;
            this.HeightDeltas = @heightDeltas;
            this.StaticGains = @staticGains;
            this.Lengths = @lengths;
            this.PipeLosses = @pipeLosses;
            this.Flow = @flow;
            this.Diameter = @diameter;
            }
        
        // Empty constructor
        public PressureCalculationManifold()
            : base()
        {
        }
    
        [JsonProperty("ZLosses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<double> ZLosses { get; set; }
    
        [JsonProperty("Flows", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<double> Flows { get; set; }
    
        [JsonProperty("Diameters", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<double> Diameters { get; set; }
    
        [JsonProperty("HeightDeltas", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<double> HeightDeltas { get; set; }
    
        [JsonProperty("StaticGains", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<double> StaticGains { get; set; }
    
        [JsonProperty("Lengths", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<double> Lengths { get; set; }
    
        [JsonProperty("PipeLosses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<double> PipeLosses { get; set; }
    
        [JsonProperty("Flow", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Flow { get; set; }
    
        [JsonProperty("Diameter", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Diameter { get; set; }
    
    
    }
}