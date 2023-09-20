using Microsoft.Kiota.Abstractions.Serialization;

namespace Qwips.Core.PointerClientSdk.ErrorHandling
{
    public static class PointerErrorHandler
    {
        public static Dictionary<string, ParsableFactory<IParsable>> GenericErrorResponse = new Dictionary<string, ParsableFactory<IParsable>> {
                { "4XX", Pointer4XXJsonErrorResponse.CreateFromDiscriminatorValue }
            };
    }
}
