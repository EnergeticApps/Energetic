using System;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace System
{
    public static class UriExtensions
    {
        /// <summary>
        /// Concatenates two URI components into a single URI. Ensures that there is one (and only one) slash "/" between them.
        /// It is the equivalent of <see cref="IO.Path.Combine"/> but for URIs.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static Uri Append(this Uri uri, params string[] paths)
        {
            return new Uri(paths.Aggregate(uri.AbsoluteUri,
                (current, path) => $"{current.TrimEnd('/')}/{path.TrimStart('/')}"));
        }

        /// <summary>
        /// Adds a parameter value to the Query String without naming the parameter. E.g. http://example.com/api/?someValue
        /// </summary>
        /// <param name="url">The url</param>
        /// <param name="paramValue">The unnamed value to add.</param>
        /// <returns>Url with added parameter.</returns>
        public static Uri AddKeylessParameter(this Uri url, string paramValue)
        {
            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query[null] = paramValue;
            uriBuilder.Query = query.ToString();

            return uriBuilder.Uri;
        }

        /// <summary>
        /// Adds the specified parameter to the Query String.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="paramName">Name of the parameter to add.</param>
        /// <param name="paramValue">Value for the parameter to add.</param>
        /// <returns>Url with added parameter.</returns>
        public static Uri AddParameter(this Uri url, string paramName, string paramValue)
        {
            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query[paramName] = paramValue;
            uriBuilder.Query = query.ToString();

            return uriBuilder.Uri;
        }

        /// <summary>
        /// Adds an OData "$count" paramater to the querystring with the specified value
        /// </summary>
        /// <param name="url">The instance of <see cref="System.Uri" /> pointing to an OData API endpoint</param>
        /// <param name="value">True to request a count from the API endpoint, otherwise false</param>
        /// <returns>Url with "$count" parameter.</returns>
        public static Uri AddODataCountParameter(this Uri url, bool value)
        {
            return url.AddParameter("$count", value.ToString());
        }

        /// <summary>
        /// Adds an OData "$skip" paramater to the querystring with the specified value
        /// </summary>
        /// <param name="url">The instance of <see cref="System.Uri" /> pointing to an OData API endpoint</param>
        /// <param name="skip">The number of records to request that the API endpoint skips</param>
        /// <returns>Url with "$skip" parameter and specified value.</returns>
        public static Uri AddODataSkipParameter(this Uri url, int skip)
        {
            return url.AddParameter("$skip", skip.ToString());
        }

        /// <summary>
        /// Adds an OData "$top" paramater to the querystring with the specified value
        /// </summary>
        /// <param name="url">The instance of <see cref="System.Uri" /> pointing to an OData API endpoint</param>
        /// <param name="top">The number of records to request that the API endpoint returns</param>
        /// <returns>Url with "$top" parameter and specified value.</returns>
        public static Uri AddODataTopParameter(this Uri url, int top)
        {
            return url.AddParameter("$skip", top.ToString());
        }

        /// <summary>
        /// Adds an OData "$orderby" paramater to the querystring with the specified value
        /// </summary>
        /// <param name="url">The instance of <see cref="System.Uri" /> pointing to an OData API endpoint</param>
        /// <param name="orderByProperty">The property of the data transfer object (DTO) on which
        /// you would like the API endpoint to sort.</param>
        /// <typeparam name="TDto">The type of the data transfer object (DTO) being requested from
        /// the API endpoint.</typeparam>
        /// <typeparam name="TProperty">The type of the property on the data transfer object (DTO)
        /// on which we are requesting the API endpoint sort.</typeparam>
        /// <returns>Url with "$orderby" parameter and specified value.</returns>
        public static Uri AddODataOrderByParameter<TDto, TProperty>(this Uri url, Expression<Func<TDto, TProperty>> orderByProperty)
        {
            return url.AddParameter("$orderby", orderByProperty.Name);
        }

        /// <summary>
        /// Adds an OData "$select" paramater to the querystring with the specified value
        /// </summary>
        /// <param name="url">The instance of <see cref="System.Uri" /> pointing to an OData API endpoint</param>
        /// <param name="selectProperty">The property of the data transfer object (DTO) that you would like
        /// the API endpoint to return.</param>
        /// <typeparam name="TDto">The type of the data transfer object (DTO) being requested from
        /// the API endpoint.</typeparam>
        /// <typeparam name="TProperty">The type of the property on the data transfer object (DTO)
        /// that we would like the API endpoint return.</typeparam>
        /// <returns>Url with "$select" parameter and specified value.</returns>
        public static Uri AddODataSelectParameter<TDto, TProperty>(this Uri url, Expression<Func<TDto, TProperty>> selectProperty)
        {
            return url.AddParameter("$select", selectProperty.Name);
        }
    }
}
