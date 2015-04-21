ScriptCS...created by Glenn Block et al

-- Introduction
What are we talking about ?

	- Write C# apps with a text editor, nuget and the power of Roslyn! 
	- C# : A language that has grown over time into a language that we love
	- Nuget : Package management for .net because you can't make your application in a silo
	- Roslyn : The new compiler service from Microsoft which is Open Source.
	- Text Editor : Use whatever you want, sublime already has a plugin but the cli can be hoooked anywhere

* Everything is still typed and you get to try things out iteratively without using VS.
* Roslyn is available as nuget package which means that we can get in there and do useful things with it.

* Open Source, XPlat ...things that make us believe that it is going to solve a lot of problems.
* Really nice CLI experience and what more there is a REPL there as well.
* Significantly lighter experience which is a welcome change.

-- Installing

* Chocolatey is your new best friend. It's like apt-get but for windows.
* Helps install and automate all the things.
* Runtime can be .net or mono.

-- Under the hood

* Roslyn compiles the code in memory, everthing is wrapped up in a class
* That's why we don't have namespaces in the scripts
* Get your favourite package from nuget.
* Modularise your scripts as you would any other piece of code.

-- Up & Running

* REPL ..good to be able to try out a lot of things here
	* REPL demo 
		- Store in local variables
		- compute directly
* Tighter feedback loop your code
* Try Out : Multiline code
* Move things to a script if you want to do some more
	* HelloWorld.csx demo

* Reference assemblies from the GAC
	* Demo #r for System.Net.Http

* Load other scriptcs using #load
* Loading is done recursively
	* Demo #load is recursive

-- Package Management & Nuget 

* Manages Nuget packages for you using the nuget api, there is no need to have the nuget binary
* You can take your already available packages in packages.config from an existing project and just drop it in there
* You can distribute scripts with just the script and the packages.config which makes distribution a breeze.
* Awesome for sharing utilities in OSS mode.
	* Demo - CsvHelper

-- Script Packs

* Frameworks are not designed to be scriptable.
* Scriptpacks remove the boiler plate and provide the using and the assemblies by default
* Makes them scriptable
* Somethings may get a little hairy as most of them aren't designed to accept in memory assemblies
	* Demo Nancy Script Pack..hosting an API
	* Demo Talk to Redis or whatever you want 

-- Use Cases and Demos
	
*  Demo Ocokit and creating CLI utilities to improve your productivity 
*  Demo Fluent Automation
*  Demo PVC Build Systems & Improving feedback
*  Demo ConfigR ...as a way of managing configuration

-- SVM

* Installation and use
* Must have in our toolkit 

-- Community 

* Receptive team
* Prompt reply to Github issues and always available on Jabbr
* Strong community which makes it easier to get into
