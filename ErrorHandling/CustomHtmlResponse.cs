using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Xml;

namespace Qwips.Core.PointerClientSdk.ErrorHandling
{

    /// <summary>
    /// The <see cref="IParseNodeFactory"/> implementation for text/plain content types
    /// </summary>
    public class HtmlParseNodeFactory : IParseNodeFactory
    {
        /// <inheritdoc />
        public string ValidContentType => "text/html";
        /// <inheritdoc />
        public IParseNode GetRootParseNode(string contentType, Stream content)
        {
            if (string.IsNullOrEmpty(contentType))
                throw new ArgumentNullException(nameof(contentType));
            else if (!ValidContentType.Equals(contentType, StringComparison.OrdinalIgnoreCase))
                throw new ArgumentOutOfRangeException($"expected a {ValidContentType} content type");

            _ = content ?? throw new ArgumentNullException(nameof(content));
            using var reader = new StreamReader(content);
            var stringContent = reader.ReadToEnd();
            return new HtmlParseNode(stringContent);
        }
    }
    public class HtmlParseNode : IParseNode
    {
        internal const string NoStructuredDataMessage = "text does not support structured data";
        private readonly string? Text;
        /// <summary>
        /// Initializes a new instance of the <see cref="TextParseNode"/> class.
        /// </summary>
        /// <param name="text">The text value.</param>
        public HtmlParseNode(string? text)
        {
            Text = text?.Trim('"');
        }
        /// <inheritdoc />
        public Action<IParsable>? OnBeforeAssignFieldValues { get; set; }
        /// <inheritdoc />
        public Action<IParsable>? OnAfterAssignFieldValues { get; set; }
        /// <inheritdoc />
        public bool? GetBoolValue() => bool.TryParse(Text, out var result) ? result : null;
        /// <inheritdoc />
        public byte[]? GetByteArrayValue() => string.IsNullOrEmpty(Text) ? null : Convert.FromBase64String(Text);
        /// <inheritdoc />
        public byte? GetByteValue() => byte.TryParse(Text, out var result) ? result : null;
        /// <inheritdoc />
        public IParseNode GetChildNode(string identifier) => throw new InvalidOperationException(NoStructuredDataMessage);
        /// <inheritdoc />
        public IEnumerable<T> GetCollectionOfObjectValues<T>(ParsableFactory<T> factory) where T : IParsable => throw new InvalidOperationException(NoStructuredDataMessage);
        /// <inheritdoc />
        public IEnumerable<T> GetCollectionOfPrimitiveValues<T>() => throw new InvalidOperationException(NoStructuredDataMessage);
        /// <inheritdoc />
        public DateTimeOffset? GetDateTimeOffsetValue() => DateTimeOffset.TryParse(Text, out var result) ? result : null;
        /// <inheritdoc />
        public Date? GetDateValue() => DateTime.TryParse(Text, out var result) ? new Date(result) : null;
        /// <inheritdoc />
        public decimal? GetDecimalValue() => decimal.TryParse(Text, out var result) ? result : null;
        /// <inheritdoc />
        public double? GetDoubleValue() => double.TryParse(Text, out var result) ? result : null;
        /// <inheritdoc />
        public float? GetFloatValue() => float.TryParse(Text, out var result) ? result : null;
        /// <inheritdoc />
        public Guid? GetGuidValue() => Guid.TryParse(Text, out var result) ? result : null;
        /// <inheritdoc />
        public int? GetIntValue() => int.TryParse(Text, out var result) ? result : null;
        /// <inheritdoc />
        public long? GetLongValue() => long.TryParse(Text, out var result) ? result : null;
        /// <inheritdoc />
        public T GetObjectValue<T>(ParsableFactory<T> factory) where T : IParsable
        {
            var item = factory(this);
            OnBeforeAssignFieldValues?.Invoke(item);
            AssignFieldValues(item);
            OnAfterAssignFieldValues?.Invoke(item);
            return item;
        }

        private void AssignFieldValues<T>(T item) where T : IParsable
        {
            if (string.IsNullOrEmpty(Text)) return;
            IDictionary<string, object>? itemAdditionalData = null;
            if (item is IAdditionalDataHolder holder)
            {
                holder.AdditionalData ??= new Dictionary<string, object>();
                itemAdditionalData = holder.AdditionalData;
            }
            //When targeting maccatalyst, new keyword for hiding an existing member is not being respected, returning only id and odata type
            //the below line fixes the issue
            var fieldDeserializers = (IDictionary<string, Action<IParseNode>>)item.GetType().GetMethod("GetFieldDeserializers").Invoke(item, null);
            var fieldDeserializer = fieldDeserializers["Content"];
            fieldDeserializer.Invoke(new HtmlParseNode(Text)
            {
                OnBeforeAssignFieldValues = OnBeforeAssignFieldValues,
                OnAfterAssignFieldValues = OnAfterAssignFieldValues
            });

        }

        /// <inheritdoc />
        public sbyte? GetSbyteValue() => sbyte.TryParse(Text, out var result) ? result : null;
        /// <inheritdoc />
        public string? GetStringValue() => Text;
        /// <inheritdoc />
        public TimeSpan? GetTimeSpanValue() => string.IsNullOrEmpty(Text) ? null : XmlConvert.ToTimeSpan(Text);
        /// <inheritdoc />
        public Time? GetTimeValue() => DateTime.TryParse(Text, out var result) ? new Time(result) : null;
        /// <inheritdoc />
        IEnumerable<T?> IParseNode.GetCollectionOfEnumValues<T>() => throw new InvalidOperationException(NoStructuredDataMessage);
        /// <inheritdoc />
        T? IParseNode.GetEnumValue<T>() => Enum.TryParse<T>(Text, true, out var result) ? result : null;
    }
}
