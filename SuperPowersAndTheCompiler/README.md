# Super-powers and the Compiler

## About the Talk
Try to imagine how powerful would it be if programmers could look at their code through the eyes of their compilers. If they could automatically analyze their code, improve it, change it, cover it with tests, etc. This would definitely be a super-power! Until recently, this super-power was at disposal only to rare ones who mastered the difficult skill of compiler development. Roslyn - C# and VB.NET Compiler-as-a-Service - gives this super-power to every .NET developer.

In the beginning of the talk we discuss compilers in general. How do they work? What makes them so complex to develop?

Then we introduce Roslyn and discuss how and why it "changed the game" for .NET developers. We present few concrete projects built on top of Roslyn and move toward examples of potential usage of Roslyn in our own projects. In particular, we discuss how to utilize Roslyn to increase code quality of our own projects.

The talk was given at:
- [.NET Stammtisch Linz (Linz, Austria on February 20th, 2018)](https://www.meetup.com/NET-Stammtisch-Linz/events/247045584/)
- [Dot Net Developers NCR Chapter (New Delhi, India on December 2nd, 2017)](https://www.meetup.com/Dot-Net-Developers-NCR-Chapter/events/245193299/)
- [ASP.NET Workshop Dublin (Dublin, Ireland on August 14th, 2017)](https://www.meetup.com/ASP-NET-Workshop-Dublin/events/242376742/)
- [Microsoft Developer User Group Rijeka (Rijeka, Croatia on May 30th, 2017)](https://www.meetup.com/Microsoft-Developer-User-Group-Rijeka/events/239938651/)

## Code Samples
The [Awesome Roslyn](https://github.com/ironcev/awesome-roslyn) list is the best starting point to learn more about Roslyn. It is a curated list of awesome Roslyn books, tutorials, open source projects, analyzers, code fixes, and refactorings.

The code samples used in the talk are already available in several other repositories.

The samples with C# contextual keywords can be found in [the code snippets of the blog post "Await Async as Async"](https://github.com/ironcev/HumbleXamples/tree/master/AwaitAsyncAsAsync).

The examples of the Roslyn's Syntax API usage can be found in the [the reworked examples from the book "Source Code Analytics With Roslyn and JavaScript Data Visualization"](https://github.com/ironcev/source-code-analytics-with-roslyn-and-javascript-data-visualization).

The diagnostics and code fix example, the `MustInvoke`, can be found in the [Jason's Bock sample code for his book ".NET Development Using the Compiler API"](https://github.com/JasonBock/CompilerAPIBook/tree/master/Chapter%202/MustInvoke).

The details on the *Sharpen* project can be found on its homepage: [http://sharpen.rocks](http://sharpen.rocks).