
#nullable enable

namespace DoclingServe
{
    public sealed partial class DoclingServeClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingAuthorization(
 )
        {

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::DoclingServe.EndPointAuthorization
            {
                Type = "",
                SchemeId = "APIKeyAuth",
                Location = "",
                Name = "",
                Value = "",
            });
        }
    }
}