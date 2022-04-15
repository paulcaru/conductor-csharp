/*
 * Conductor API Server
 *
 * Conductor API Server
 *
 * The version of the OpenAPI document: v0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Conductor.Client.Models
{
    /// <summary>
    /// SubWorkflowParams
    /// </summary>
    [DataContract(Name = "SubWorkflowParams")]
    public partial class SubWorkflowParams : IEquatable<SubWorkflowParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubWorkflowParams" /> class.
        /// </summary>
        [JsonConstructor]
        protected SubWorkflowParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubWorkflowParams" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="version">version.</param>
        /// <param name="taskToDomain">taskToDomain.</param>
        /// <param name="workflowDefinition">workflowDefinition.</param>
        public SubWorkflowParams(string name = default(string), int version = default(int), Dictionary<string, string> taskToDomain = default(Dictionary<string, string>), WorkflowDef workflowDefinition = default(WorkflowDef))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for SubWorkflowParams and cannot be null");
            }
            this.Name = name;
            this._Version = version;
            this.TaskToDomain = taskToDomain;
            this.WorkflowDefinition = workflowDefinition;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Gets or Sets TaskToDomain
        /// </summary>
        [DataMember(Name = "taskToDomain", EmitDefaultValue = false)]
        public Dictionary<string, string> TaskToDomain { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowDefinition
        /// </summary>
        [DataMember(Name = "workflowDefinition", EmitDefaultValue = false)]
        public WorkflowDef WorkflowDefinition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubWorkflowParams {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  TaskToDomain: ").Append(TaskToDomain).Append("\n");
            sb.Append("  WorkflowDefinition: ").Append(WorkflowDefinition).Append("\n");
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
            return this.Equals(input as SubWorkflowParams);
        }

        /// <summary>
        /// Returns true if SubWorkflowParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SubWorkflowParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubWorkflowParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.TaskToDomain == input.TaskToDomain ||
                    this.TaskToDomain != null &&
                    input.TaskToDomain != null &&
                    this.TaskToDomain.SequenceEqual(input.TaskToDomain)
                ) && 
                (
                    this.WorkflowDefinition == input.WorkflowDefinition ||
                    (this.WorkflowDefinition != null &&
                    this.WorkflowDefinition.Equals(input.WorkflowDefinition))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                if (this.TaskToDomain != null)
                {
                    hashCode = (hashCode * 59) + this.TaskToDomain.GetHashCode();
                }
                if (this.WorkflowDefinition != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowDefinition.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
