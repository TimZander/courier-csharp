/*
 * Courier API Reference
 *
 * The Courier REST API.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@courier.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Com.Courier.Client.OpenAPIDateConverter;

namespace Com.Courier.Model
{
    /// <summary>
    /// MessageOutputItemContent
    /// </summary>
    [DataContract(Name = "MessageOutputItem_content")]
    public partial class MessageOutputItemContent : IEquatable<MessageOutputItemContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageOutputItemContent" /> class.
        /// </summary>
        /// <param name="html">The html content of the rendered message.</param>
        /// <param name="title">The title of the rendered message.</param>
        /// <param name="body">The body of the rendered message.</param>
        /// <param name="subject">The subject of the rendered message.</param>
        /// <param name="text">The text of the rendered message.</param>
        /// <param name="blocks">The blocks of the rendered message.</param>
        public MessageOutputItemContent(string html = default(string), string title = default(string), string body = default(string), string subject = default(string), string text = default(string), List<Object> blocks = default(List<Object>))
        {
            this.Html = html;
            this.Title = title;
            this.Body = body;
            this.Subject = subject;
            this.Text = text;
            this.Blocks = blocks;
        }

        /// <summary>
        /// The html content of the rendered message
        /// </summary>
        /// <value>The html content of the rendered message</value>
        [DataMember(Name = "html", EmitDefaultValue = false)]
        public string Html { get; set; }

        /// <summary>
        /// The title of the rendered message
        /// </summary>
        /// <value>The title of the rendered message</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The body of the rendered message
        /// </summary>
        /// <value>The body of the rendered message</value>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// The subject of the rendered message
        /// </summary>
        /// <value>The subject of the rendered message</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// The text of the rendered message
        /// </summary>
        /// <value>The text of the rendered message</value>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// The blocks of the rendered message
        /// </summary>
        /// <value>The blocks of the rendered message</value>
        [DataMember(Name = "blocks", EmitDefaultValue = false)]
        public List<Object> Blocks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageOutputItemContent {\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MessageOutputItemContent);
        }

        /// <summary>
        /// Returns true if MessageOutputItemContent instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageOutputItemContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageOutputItemContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Html == input.Html ||
                    (this.Html != null &&
                    this.Html.Equals(input.Html))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Blocks == input.Blocks ||
                    this.Blocks != null &&
                    input.Blocks != null &&
                    this.Blocks.SequenceEqual(input.Blocks)
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
                if (this.Html != null)
                    hashCode = hashCode * 59 + this.Html.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Blocks != null)
                    hashCode = hashCode * 59 + this.Blocks.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}