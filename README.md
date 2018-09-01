# unstable-rest-api

Intentionally unstable REST API (Azure Function)

This API returns fake data ([Lorem Ipsum](https://en.wikipedia.org/wiki/Lorem_ipsum)) but with a twist. It is unstable in order to aid in the design/testing of API error handling code.

The API currently returns these HTTP status codes:

* 200 OK - The API was successful and returns the lorem ipsum text
* 202 Accepted
* 400 Bad Request
* 500 Internal Server Error

Probability of each HTTP status code:

| HTTP Status Code          | Body                             | Probability |
|---------------------------|----------------------------------|-------------|
| 200 OK                    | JSON containing lorem ipsum text | 60%         |
| 202 Accepted              | NA                               | 20%         |
| 400 Bad Request           | NA                               | 15%         |
| 500 Internal Server Error | NA                               | 5%          |

There is a 50/50 chance the API will either responsd immediately or take anywhere up to 5 seconds.
