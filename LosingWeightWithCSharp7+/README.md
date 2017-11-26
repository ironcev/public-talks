# Losing Weight With C# 7+

## About the Talk

C# 7.0 and 7.1 bring new features that can make our code leaner and more readable. In the talk we analyze various examples taken from production code to get an idea on how much "weight" a typical existing code could lose. Beside showing real-life examples, to demonstrate the features we also use the sample code provided here. On top of that the talk discuss performance and potential performance problems that the new features could cause, as well as how the features work "under the hood".

The talk was given at:

- [Microsoft Developer User Group Graz (on October 25th, 2017)](https://www.meetup.com/MicrosoftDeveloperGraz/events/243975926/)
- [Microsoft Developer User Group Zagreb (on November 22nd, 2017)](https://www.meetup.com/devugzg/events/244521212/)

## How to Use the Samples

Each new language feature has a dedicated folder within the [Snippets](Snippets) project. Each folder contains a `Before.cs` and `After.cs` file that demonstrate the code before and after applying the feature, respectively. Each folder contains as well a `CompareXYZ.cs` file. The code in that file can be pasted into [SharpLab](https://sharplab.io). That way we can quickly see how the compiler implements the feature, compared to the original code replaced by the feature.