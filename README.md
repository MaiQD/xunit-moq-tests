# xUnit-MOQ-learn

## XUnit.Net
### What is XUnit.Net
- Unit testing tool
- Free and Open Source
- Written by the inventor of NUnit 2
- Is use to test C#, F#, and VB.Net
- Can be used to test .Net Framework apps
- Can be used to test .Net Core apps
### Features of XUnit.Net
- Supports multiple platforms
- Supports parallel test execution
- Supports Data Driven tests
- Is designed to be extensible
- Easy to install via NuGet packages
- Is the default unit testing tool in VS for .Net Core
### Keywords
- Fact: Test with no input
### Phases of Unit Testing
- Arrange: create an instance of test subject (load data, read config, gen test data)
- Act: Run code
- Assert: compare output with expected value
### Data Driven tests in XUnits
|					| Sharedable	| Need Developers  |
| -------			| ---			| --- |
| Inline Attribute	| No			| Yes |
| Property/Method	| Yes			| Yes |
| Custom Attribute	| Yes			| Yes |
| External Data		| Yes			| No  |

### Mocking
- Add tests to a well designed application. YOu can make changes
- Add tests to lagacy code
- Test driven development (TDD)