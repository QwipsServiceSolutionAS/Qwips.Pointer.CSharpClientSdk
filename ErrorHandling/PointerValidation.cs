using Microsoft.Kiota.Abstractions.Serialization;

namespace Qwips.Core.PointerClientSdk.ErrorHandling
{
    public class PointerValidation : IParsable
    {
        public string? Source { get; set; }
        public IEnumerable<string>? Keys { get; set; }
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>> {
                {"source", n => { Source = n.GetStringValue(); } },
                {"keys", n => { Keys = n.GetCollectionOfPrimitiveValues<string>(); } },
            };
        }

        public static PointerValidation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PointerValidation();
        }
        public void Serialize(ISerializationWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
