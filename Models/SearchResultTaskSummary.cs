/* 
 * 
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Conductor.Client.Models
{
    /// <summary>
    /// SearchResultTaskSummary
    /// </summary>
    [DataContract]
    public partial class SearchResultTaskSummary :  IEquatable<SearchResultTaskSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultTaskSummary" /> class.
        /// </summary>
        /// <param name="totalHits">totalHits.</param>
        /// <param name="results">results.</param>
        public SearchResultTaskSummary(long? totalHits = default(long?), List<TaskSummary> results = default(List<TaskSummary>))
        {
            this.TotalHits = totalHits;
            this.Results = results;
        }
        
        /// <summary>
        /// Gets or Sets TotalHits
        /// </summary>
        [DataMember(Name="totalHits", EmitDefaultValue=false)]
        public long? TotalHits { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<TaskSummary> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchResultTaskSummary {\n");
            sb.Append("  TotalHits: ").Append(TotalHits).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchResultTaskSummary);
        }

        /// <summary>
        /// Returns true if SearchResultTaskSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResultTaskSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResultTaskSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalHits == input.TotalHits ||
                    (this.TotalHits != null &&
                    this.TotalHits.Equals(input.TotalHits))
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TotalHits != null)
                    hashCode = hashCode * 59 + this.TotalHits.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}