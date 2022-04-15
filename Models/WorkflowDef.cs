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
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Conductor.Client.Models
{
    /// <summary>
    /// WorkflowDef
    /// </summary>
    [DataContract(Name = "WorkflowDef")]
    public partial class WorkflowDef : IEquatable<WorkflowDef>, IValidatableObject
    {
        /// <summary>
        /// Defines TimeoutPolicy
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeoutPolicyEnum
        {
            /// <summary>
            /// Enum TIMEOUTWF for value: TIME_OUT_WF
            /// </summary>
            [EnumMember(Value = "TIME_OUT_WF")]
            TIMEOUTWF = 1,

            /// <summary>
            /// Enum ALERTONLY for value: ALERT_ONLY
            /// </summary>
            [EnumMember(Value = "ALERT_ONLY")]
            ALERTONLY = 2

        }


        /// <summary>
        /// Gets or Sets TimeoutPolicy
        /// </summary>
        [DataMember(Name = "timeoutPolicy", EmitDefaultValue = false)]
        public TimeoutPolicyEnum? TimeoutPolicy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDef" /> class.
        /// </summary>
        [JsonConstructor]
        protected WorkflowDef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDef" /> class.
        /// </summary>
        /// <param name="ownerApp">ownerApp.</param>
        /// <param name="createTime">createTime.</param>
        /// <param name="updateTime">updateTime.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="updatedBy">updatedBy.</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="version">version.</param>
        /// <param name="tasks">tasks (required).</param>
        /// <param name="inputParameters">inputParameters.</param>
        /// <param name="outputParameters">outputParameters.</param>
        /// <param name="failureWorkflow">failureWorkflow.</param>
        /// <param name="schemaVersion">schemaVersion.</param>
        /// <param name="restartable">restartable.</param>
        /// <param name="workflowStatusListenerEnabled">workflowStatusListenerEnabled.</param>
        /// <param name="ownerEmail">ownerEmail.</param>
        /// <param name="timeoutPolicy">timeoutPolicy.</param>
        /// <param name="timeoutSeconds">timeoutSeconds (required).</param>
        /// <param name="variables">variables.</param>
        /// <param name="inputTemplate">inputTemplate.</param>
        public WorkflowDef(string ownerApp = default(string), long createTime = default(long), long updateTime = default(long), string createdBy = default(string), string updatedBy = default(string), string name = default(string), string description = default(string), int version = default(int), List<WorkflowTask> tasks = default(List<WorkflowTask>), List<string> inputParameters = default(List<string>), Dictionary<string, Object> outputParameters = default(Dictionary<string, Object>), string failureWorkflow = default(string), int schemaVersion = default(int), bool restartable = default(bool), bool workflowStatusListenerEnabled = default(bool), string ownerEmail = default(string), TimeoutPolicyEnum? timeoutPolicy = default(TimeoutPolicyEnum?), long timeoutSeconds = default(long), Dictionary<string, Object> variables = default(Dictionary<string, Object>), Dictionary<string, Object> inputTemplate = default(Dictionary<string, Object>))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for WorkflowDef and cannot be null");
            }
            this.Name = name;
            // to ensure "tasks" is required (not null)
            if (tasks == null) {
                throw new ArgumentNullException("tasks is a required property for WorkflowDef and cannot be null");
            }
            this.Tasks = tasks;
            this.TimeoutSeconds = timeoutSeconds;
            this.OwnerApp = ownerApp;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
            this.Description = description;
            this._Version = version;
            this.InputParameters = inputParameters;
            this.OutputParameters = outputParameters;
            this.FailureWorkflow = failureWorkflow;
            this.SchemaVersion = schemaVersion;
            this.Restartable = restartable;
            this.WorkflowStatusListenerEnabled = workflowStatusListenerEnabled;
            this.OwnerEmail = ownerEmail;
            this.TimeoutPolicy = timeoutPolicy;
            this.Variables = variables;
            this.InputTemplate = inputTemplate;
        }

        /// <summary>
        /// Gets or Sets OwnerApp
        /// </summary>
        [DataMember(Name = "ownerApp", EmitDefaultValue = false)]
        public string OwnerApp { get; set; }

        /// <summary>
        /// Gets or Sets CreateTime
        /// </summary>
        [DataMember(Name = "createTime", EmitDefaultValue = false)]
        public long CreateTime { get; set; }

        /// <summary>
        /// Gets or Sets UpdateTime
        /// </summary>
        [DataMember(Name = "updateTime", EmitDefaultValue = false)]
        public long UpdateTime { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name = "updatedBy", EmitDefaultValue = false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Gets or Sets Tasks
        /// </summary>
        [DataMember(Name = "tasks", IsRequired = true, EmitDefaultValue = false)]
        public List<WorkflowTask> Tasks { get; set; }

        /// <summary>
        /// Gets or Sets InputParameters
        /// </summary>
        [DataMember(Name = "inputParameters", EmitDefaultValue = false)]
        public List<string> InputParameters { get; set; }

        /// <summary>
        /// Gets or Sets OutputParameters
        /// </summary>
        [DataMember(Name = "outputParameters", EmitDefaultValue = false)]
        public Dictionary<string, Object> OutputParameters { get; set; }

        /// <summary>
        /// Gets or Sets FailureWorkflow
        /// </summary>
        [DataMember(Name = "failureWorkflow", EmitDefaultValue = false)]
        public string FailureWorkflow { get; set; }

        /// <summary>
        /// Gets or Sets SchemaVersion
        /// </summary>
        [DataMember(Name = "schemaVersion", EmitDefaultValue = false)]
        public int SchemaVersion { get; set; }

        /// <summary>
        /// Gets or Sets Restartable
        /// </summary>
        [DataMember(Name = "restartable", EmitDefaultValue = true)]
        public bool Restartable { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowStatusListenerEnabled
        /// </summary>
        [DataMember(Name = "workflowStatusListenerEnabled", EmitDefaultValue = true)]
        public bool WorkflowStatusListenerEnabled { get; set; }

        /// <summary>
        /// Gets or Sets OwnerEmail
        /// </summary>
        [DataMember(Name = "ownerEmail", EmitDefaultValue = false)]
        public string OwnerEmail { get; set; }

        /// <summary>
        /// Gets or Sets TimeoutSeconds
        /// </summary>
        [DataMember(Name = "timeoutSeconds", IsRequired = true, EmitDefaultValue = false)]
        public long TimeoutSeconds { get; set; }

        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name = "variables", EmitDefaultValue = false)]
        public Dictionary<string, Object> Variables { get; set; }

        /// <summary>
        /// Gets or Sets InputTemplate
        /// </summary>
        [DataMember(Name = "inputTemplate", EmitDefaultValue = false)]
        public Dictionary<string, Object> InputTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkflowDef {\n");
            sb.Append("  OwnerApp: ").Append(OwnerApp).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
            sb.Append("  InputParameters: ").Append(InputParameters).Append("\n");
            sb.Append("  OutputParameters: ").Append(OutputParameters).Append("\n");
            sb.Append("  FailureWorkflow: ").Append(FailureWorkflow).Append("\n");
            sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
            sb.Append("  Restartable: ").Append(Restartable).Append("\n");
            sb.Append("  WorkflowStatusListenerEnabled: ").Append(WorkflowStatusListenerEnabled).Append("\n");
            sb.Append("  OwnerEmail: ").Append(OwnerEmail).Append("\n");
            sb.Append("  TimeoutPolicy: ").Append(TimeoutPolicy).Append("\n");
            sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  InputTemplate: ").Append(InputTemplate).Append("\n");
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
            return this.Equals(input as WorkflowDef);
        }

        /// <summary>
        /// Returns true if WorkflowDef instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkflowDef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowDef input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OwnerApp == input.OwnerApp ||
                    (this.OwnerApp != null &&
                    this.OwnerApp.Equals(input.OwnerApp))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    this.CreateTime.Equals(input.CreateTime)
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    this.UpdateTime.Equals(input.UpdateTime)
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.Tasks == input.Tasks ||
                    this.Tasks != null &&
                    input.Tasks != null &&
                    this.Tasks.SequenceEqual(input.Tasks)
                ) && 
                (
                    this.InputParameters == input.InputParameters ||
                    this.InputParameters != null &&
                    input.InputParameters != null &&
                    this.InputParameters.SequenceEqual(input.InputParameters)
                ) && 
                (
                    this.OutputParameters == input.OutputParameters ||
                    this.OutputParameters != null &&
                    input.OutputParameters != null &&
                    this.OutputParameters.SequenceEqual(input.OutputParameters)
                ) && 
                (
                    this.FailureWorkflow == input.FailureWorkflow ||
                    (this.FailureWorkflow != null &&
                    this.FailureWorkflow.Equals(input.FailureWorkflow))
                ) && 
                (
                    this.SchemaVersion == input.SchemaVersion ||
                    this.SchemaVersion.Equals(input.SchemaVersion)
                ) && 
                (
                    this.Restartable == input.Restartable ||
                    this.Restartable.Equals(input.Restartable)
                ) && 
                (
                    this.WorkflowStatusListenerEnabled == input.WorkflowStatusListenerEnabled ||
                    this.WorkflowStatusListenerEnabled.Equals(input.WorkflowStatusListenerEnabled)
                ) && 
                (
                    this.OwnerEmail == input.OwnerEmail ||
                    (this.OwnerEmail != null &&
                    this.OwnerEmail.Equals(input.OwnerEmail))
                ) && 
                (
                    this.TimeoutPolicy == input.TimeoutPolicy ||
                    this.TimeoutPolicy.Equals(input.TimeoutPolicy)
                ) && 
                (
                    this.TimeoutSeconds == input.TimeoutSeconds ||
                    this.TimeoutSeconds.Equals(input.TimeoutSeconds)
                ) && 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    input.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
                ) && 
                (
                    this.InputTemplate == input.InputTemplate ||
                    this.InputTemplate != null &&
                    input.InputTemplate != null &&
                    this.InputTemplate.SequenceEqual(input.InputTemplate)
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
                if (this.OwnerApp != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerApp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreateTime.GetHashCode();
                hashCode = (hashCode * 59) + this.UpdateTime.GetHashCode();
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.UpdatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedBy.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                if (this.Tasks != null)
                {
                    hashCode = (hashCode * 59) + this.Tasks.GetHashCode();
                }
                if (this.InputParameters != null)
                {
                    hashCode = (hashCode * 59) + this.InputParameters.GetHashCode();
                }
                if (this.OutputParameters != null)
                {
                    hashCode = (hashCode * 59) + this.OutputParameters.GetHashCode();
                }
                if (this.FailureWorkflow != null)
                {
                    hashCode = (hashCode * 59) + this.FailureWorkflow.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SchemaVersion.GetHashCode();
                hashCode = (hashCode * 59) + this.Restartable.GetHashCode();
                hashCode = (hashCode * 59) + this.WorkflowStatusListenerEnabled.GetHashCode();
                if (this.OwnerEmail != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerEmail.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TimeoutPolicy.GetHashCode();
                hashCode = (hashCode * 59) + this.TimeoutSeconds.GetHashCode();
                if (this.Variables != null)
                {
                    hashCode = (hashCode * 59) + this.Variables.GetHashCode();
                }
                if (this.InputTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.InputTemplate.GetHashCode();
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
            // SchemaVersion (int) maximum
            if (this.SchemaVersion > (int)2)
            {
                yield return new ValidationResult("Invalid value for SchemaVersion, must be a value less than or equal to 2.", new [] { "SchemaVersion" });
            }

            // SchemaVersion (int) minimum
            if (this.SchemaVersion < (int)2)
            {
                yield return new ValidationResult("Invalid value for SchemaVersion, must be a value greater than or equal to 2.", new [] { "SchemaVersion" });
            }

            yield break;
        }
    }

}
