// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// A dataset table
    /// </summary>
    public partial class Table
    {
        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        public Table() { }

        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        public Table(string name, IList<Column> columns, IList<Row> rows = default(IList<Row>))
        {
            Name = name;
            Columns = columns;
            Rows = rows;
        }

        /// <summary>
        /// The table name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The column schema for this table
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public IList<Column> Columns { get; set; }

        /// <summary>
        /// The data rows within this tabe
        /// </summary>
        [JsonProperty(PropertyName = "rows")]
        public IList<Row> Rows { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Columns == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Columns");
            }
            if (this.Name != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.Name, "^[\\x09\\x0A\\x0D\\x20\\x23\\x2D\\x30-\\x39\\x40-\\x5A\\x5E-\\x5F\\x61-\\x7A\\x7E-\\uD7FF\\uE000-\\uFFFD\\u10000-\\u10FFFF]{1,100}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Name", "^[\\x09\\x0A\\x0D\\x20\\x23\\x2D\\x30-\\x39\\x40-\\x5A\\x5E-\\x5F\\x61-\\x7A\\x7E-\\uD7FF\\uE000-\\uFFFD\\u10000-\\u10FFFF]{1,100}$");
                }
            }
            if (this.Columns != null)
            {
                foreach (var element in this.Columns)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
