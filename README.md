pew—Project Euler WPF client
============================

Pew is a Microsoft Windows Presentation Foundation program that allows its user to browse [Project Euler](https://projecteuler.net) problems.


Dependencies
============

Development
-----------

Get the [EditorConfig Language Service](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.EditorConfig) extension for Visual Studio.


Work
====

-	Figure out what are the locations of the problems
	-	GET projecteuler.net
		-	Is there a link there to get all the problems?
		-	Are the links to the problems paged?
-	Figure out how to get the title of a problem
-	Figure out how to get the text of a problem
-	Should I somehow cache the problems (links, numbers, titles, text, ...)?
	-	Is there a Last-Modified or ETag header?
	-	Should I try to update a cached entry each time it's accessed?
-	Online vs offline mode?
	-	Cache updates off in offline mode
-	Authenticated online mode
	-	Goal: Submit solutions.
	-	How does logging into projecteuler.net work? Cookies? 🤢
-	Offer coding environment?
	-	Editing
	-	Profiling
	-	Language support
-	Or (instead of coding environment) offer program runner
	-	TextBox that takes a command line.
	-	Add a second FlowDocument to capture output
		-	Format text using monospace typeface
		-	Use a second one so that scrolling its output doesn't scroll the problem out of view.


Notes
=====

-	The coding environment work really makes this seem like it would be best suited to a Visual Studio Code extension.
-	Could also look, instead, to make a simpler, command-line-based tool for problem retrieval and solution submission.
	-	This would allow, potentiallly, for the widest integration with other tools. Specifically, I would like Acme support.
	-	This could be written in two parts, a linkable object and an executable.
		-	Use the executable for Acme integration.
		-	Use the linkable object for ... every other integration?
-	The "program runner" idea has another name: shell. Do we really want a shell in this thing?
	-	It could offer some slightly fancy stuff, like timing for all commands run.
	-	Would definitely need to figure out how to stop the execution of long-running programs.


Strangeness
===========

-	A warning in PewHomePage.xaml about "XmlDataProvider cannot contain direct content" prompted the addition of the System.Xml reference.
-	The xmlns="" wart on the Problems element in PewHomePage is necessary.
	XML, XPath, and XML namespaces are ... frustrating.


References
==========

-	HasSelectedItemConverter, https://stackoverflow.com/a/39180875

—Charles Moss, 2019 May
