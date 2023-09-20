using Microsoft.Kiota.Abstractions.Serialization;

namespace Qwips.Core.PointerClientSdk.ErrorHandling
{
    public class Pointer4XXHtmlErrorResponse : Exception, IParsable
    {
        public string? Content { get; set; }
        public override string Message => Content ?? "No error message available";

        public static Pointer4XXHtmlErrorResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Pointer4XXHtmlErrorResponse();
        }
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>> {
                {"Content", n => { Content = n.GetStringValue(); } },
            };
        }

        public void Serialize(ISerializationWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
