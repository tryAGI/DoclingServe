
#nullable enable

namespace DoclingServe
{
    public sealed partial class DoclingServeClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingAuthorization(
 )
        {

            Authorizations.Clear();
            Authorizations.Add(new global::DoclingServe.EndPointAuthorization
            {
                Type = "",
                Location = "",
                Name = "",
                Value = "",
            });
        }
    }
}