# SampleWork

A .NET solution containing sample projects that demonstrate various C# concepts, including algorithm implementations, ASP.NET Core Web APIs with OpenAPI, and Application Insights integration.

## Projects

### longestsubstring

A .NET 9.0 console application showcasing common C# features and algorithm implementations:

- **Longest substring without repeating characters** — sliding window approach
- **Merge sorted arrays** in place
- **Remove duplicates** from a sorted array
- **Remove element** from an array
- **Generics** and **delegates/events**

### sampleopenapi

A .NET 9.0 ASP.NET Core Web API demonstrating OpenAPI (Swagger) integration:

- Weather forecast endpoint
- Personalized greeting endpoint
- OpenAPI document customization with contact metadata

### AppForAppInsights

A .NET 8.0 ASP.NET Core MVC application with Azure Application Insights telemetry.

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) (for `longestsubstring` and `sampleopenapi`)
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) (for `AppForAppInsights`)

## Getting Started

Clone the repository and restore dependencies:

```bash
git clone https://github.com/malli-org/samplework.git
cd samplework
dotnet restore
```

### Build the entire solution

```bash
dotnet build
```

### Run individual projects

```bash
# Console app
dotnet run --project longestsubstring

# OpenAPI web app
dotnet run --project sampleopenapi

# Application Insights MVC app
dotnet run --project AppForAppInsights
```

## License

This project is licensed under the GNU Affero General Public License v3.0. See [LICENSE.txt](LICENSE.txt) for details.