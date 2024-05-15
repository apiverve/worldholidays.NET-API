World Holidays API
============

World Holidays is a simple tool for getting the holidays of the world. It returns the holidays of the world for each day of the year.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [World Holidays API](https://apiverve.com/marketplace/api/worldholidays)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.WorldHolidays
```

Using the Package Manager:
```
nuget install APIVerve.API.WorldHolidays
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.WorldHolidays
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.WorldHolidays".
5. Click on the APIVerve.API.WorldHolidays package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the worldholidays API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The World Holidays API documentation is found here: [https://docs.apiverve.com/api/worldholidays](https://docs.apiverve.com/api/worldholidays).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
World Holidays API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new WorldHolidaysAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new worldholidaysQueryOptions {
  country = "US",
  year = 2024
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "country": "US",
    "year": "2024",
    "holidays": [
      {
        "date": "2024-01-01 00:00:00",
        "start": "2024-01-01T05:00:00Z",
        "end": "2024-01-02T05:00:00Z",
        "name": "New Year's Day",
        "type": "public"
      },
      {
        "date": "2024-01-15 00:00:00",
        "start": "2024-01-15T05:00:00Z",
        "end": "2024-01-16T05:00:00Z",
        "name": "Martin Luther King Jr. Day",
        "type": "public"
      },
      {
        "date": "2024-02-14 00:00:00",
        "start": "2024-02-14T05:00:00Z",
        "end": "2024-02-15T05:00:00Z",
        "name": "Valentine's Day",
        "type": "observance"
      },
      {
        "date": "2024-02-19 00:00:00",
        "start": "2024-02-19T05:00:00Z",
        "end": "2024-02-20T05:00:00Z",
        "name": "Washington's Birthday",
        "type": "public"
      },
      {
        "date": "2024-03-17 00:00:00",
        "start": "2024-03-17T04:00:00Z",
        "end": "2024-03-18T04:00:00Z",
        "name": "St. Patrick's Day",
        "type": "observance"
      },
      {
        "date": "2024-03-31 00:00:00",
        "start": "2024-03-31T04:00:00Z",
        "end": "2024-04-01T04:00:00Z",
        "name": "Easter Sunday",
        "type": "observance"
      },
      {
        "date": "2024-04-15 00:00:00",
        "start": "2024-04-15T04:00:00Z",
        "end": "2024-04-16T04:00:00Z",
        "name": "Tax Day",
        "type": "observance"
      },
      {
        "date": "2024-04-24 00:00:00",
        "start": "2024-04-24T04:00:00Z",
        "end": "2024-04-25T04:00:00Z",
        "name": "Administrative Professionals Day",
        "type": "observance"
      },
      {
        "date": "2024-05-12 00:00:00",
        "start": "2024-05-12T04:00:00Z",
        "end": "2024-05-13T04:00:00Z",
        "name": "Mother's Day",
        "type": "observance"
      },
      {
        "date": "2024-05-27 00:00:00",
        "start": "2024-05-27T04:00:00Z",
        "end": "2024-05-28T04:00:00Z",
        "name": "Memorial Day",
        "type": "public"
      },
      {
        "date": "2024-06-16 00:00:00",
        "start": "2024-06-16T04:00:00Z",
        "end": "2024-06-17T04:00:00Z",
        "name": "Father's Day",
        "type": "observance"
      },
      {
        "date": "2024-06-19 00:00:00",
        "start": "2024-06-19T04:00:00Z",
        "end": "2024-06-20T04:00:00Z",
        "name": "Juneteenth",
        "type": "public"
      },
      {
        "date": "2024-07-04 00:00:00",
        "start": "2024-07-04T04:00:00Z",
        "end": "2024-07-05T04:00:00Z",
        "name": "Independence Day",
        "type": "public"
      },
      {
        "date": "2024-09-02 00:00:00",
        "start": "2024-09-02T04:00:00Z",
        "end": "2024-09-03T04:00:00Z",
        "name": "Labor Day",
        "type": "public"
      },
      {
        "date": "2024-10-14 00:00:00",
        "start": "2024-10-14T04:00:00Z",
        "end": "2024-10-15T04:00:00Z",
        "name": "Columbus Day",
        "type": "public"
      },
      {
        "date": "2024-10-31 18:00:00",
        "start": "2024-10-31T22:00:00Z",
        "end": "2024-11-01T04:00:00Z",
        "name": "Halloween",
        "type": "observance"
      },
      {
        "date": "2024-11-05 00:00:00",
        "start": "2024-11-05T05:00:00Z",
        "end": "2024-11-06T05:00:00Z",
        "name": "Election Day",
        "type": "observance"
      },
      {
        "date": "2024-11-11 00:00:00",
        "start": "2024-11-11T05:00:00Z",
        "end": "2024-11-12T05:00:00Z",
        "name": "Veterans Day",
        "type": "public"
      },
      {
        "date": "2024-11-28 00:00:00",
        "start": "2024-11-28T05:00:00Z",
        "end": "2024-11-29T05:00:00Z",
        "name": "Thanksgiving Day",
        "type": "public"
      },
      {
        "date": "2024-11-29 00:00:00",
        "start": "2024-11-29T05:00:00Z",
        "end": "2024-11-30T05:00:00Z",
        "name": "Day after Thanksgiving Day",
        "type": "observance"
      },
      {
        "date": "2024-12-24 00:00:00",
        "start": "2024-12-24T05:00:00Z",
        "end": "2024-12-25T05:00:00Z",
        "name": "Christmas Eve",
        "type": "optional"
      },
      {
        "date": "2024-12-25 00:00:00",
        "start": "2024-12-25T05:00:00Z",
        "end": "2024-12-26T05:00:00Z",
        "name": "Christmas Day",
        "type": "public"
      },
      {
        "date": "2024-12-31 00:00:00",
        "start": "2024-12-31T05:00:00Z",
        "end": "2025-01-01T05:00:00Z",
        "name": "New Year's Eve",
        "type": "observance"
      }
    ]
  }
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.