# unstable-rest-api

Intentionally unstable REST API (Azure Function)

http://unstable-rest-api.azurewebsites.net/api/lorem

----

This API returns fake data ([Lorem Ipsum](https://en.wikipedia.org/wiki/Lorem_ipsum)) but with a twist. It is unstable in order to aid in the design/testing of API error handling code.

The API currently returns these HTTP status codes:

| HTTP Status Code          | Body                             | Probability |
|---------------------------|----------------------------------|-------------|
| 200 OK                    | JSON containing lorem ipsum text | 60%         |
| 202 Accepted              | NA                               | 20%         |
| 400 Bad Request           | NA                               | 15%         |
| 500 Internal Server Error | NA                               | 5%          |

There is a 50/50 chance the API will either respond right away or will wait before responding.
