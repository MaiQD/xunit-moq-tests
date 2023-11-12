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
	- What is Legacy Code? -> Legacy code has many dependencies, des not follow SOLID principles and is hard to test
	- Why wring tests for legacy code? -> To make sure when we change or expand the code we do not introduce bugs
	- Should tests be added to the entire project? -> No!
	- Sprout Methods:
		- Used when an existing (legacy) method needs to be expanded
		- Collects the added code into (a) new method(s)
		- Tests are written for the added methods(s)
		- Test driven development can be applied
- Test driven development (TDD)