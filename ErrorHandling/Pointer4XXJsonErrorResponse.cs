using Microsoft.Kiota.Abstractions.Serialization;

namespace Qwips.Core.PointerClientSdk.ErrorHandling
{
    public class Pointer4XXJsonErrorResponse : Exception, IParsable
    {
        public string? Content { get; set; }
        public override string Message => Content ?? "No error message available";
        public PointerValidation? Validation { get; set; }
        public string? Error { get; private set; }
        public int? StatusCode { get; private set; }

        public static Pointer4XXJsonErrorResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Pointer4XXJsonErrorResponse();
        }
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>> {
                {"message", n => { Content = n.GetStringValue(); } },
                {"statusCode", n => { StatusCode = n.GetIntValue(); } },
                {"validation", n => { Validation = n.GetObjectValue<PointerValidation>(PointerValidation.CreateFromDiscriminatorValue); } },
                {"error", n => { Error = n.GetStringValue(); } },
            };
        }

        public void Serialize(ISerializationWriter writer)
        {
            throw new NotImplementedException();
        }


    }
}
