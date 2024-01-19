## Chapter 1: Introduction to WinUI

WinUI is a set of open source controls and libraries that Windows developers can leverage in their **Universal Windows Platform (UWP)** and Win32 applications. UWP developers use the Windows **software development kit (SDK)** to build their applications and are required to select a target SDK version in a project's properties. By extracting the UWP controls and **user interface (UI)** components from the Windows SDK and releasing them as a set of open source libraries under the name WinUI, Microsoft is able to release versions at a faster cadence than Windows itself (as Windows SDK versions are linked to those of Windows). This separation also enables the controls to be used on older versions of Windows 10. While building UWP and Win32 applications with WinUIis the current recommendation, it is important to learn where WinUI and UWP fit in the larger Windows development landscape.

In this book, you will learn how to build applications for Windows withe WinUI 3.0 libraries. Throughtout the course of the book, we will build a real-world application using recommended patterns and practices for Windows application development.

Before we start building our WinUI app, it's important to have a good foundation in Windows client development, the different types of **Extensible Application Markup Language (XAML)** UI markup, and how WinUI compares toother Windows desktop development frameworks. Therefore, in this first chapter, you will start by learning some background on UWP and WinUI.

- What UWP is and why Microsoft created yet another application framework
- How XAML can be leveraged to create great UIs on many device sizes and families
- Why WinUI was created and how it relates to UWP
- Where WinUI fits in the Windows developer landscape
- What WinUI 3.0 brings to the table

Don't worry! It won't take very long to cover the background stuff, and it will help provide some context as you start building your WinUI app. In the next chapter, you will get your hands on some code when you create your first WinUI project.

## Technical requirements

To follow along with the examples in this chapter, the following software is required:

- Windows 10 version 1803 or newer. You can find your version of Windows in Settings | About.
- Visual Studio 2019 version 16.9 or newer with the following workloads: .NET Desktop Development and UWP Development.
- WinUI 3.0 project templates -- at the time of this writing, the templates can be downloaded from Visual Studio Marketplace at https://marketplace.visualstudio.com/items?itemName=Microsoft-WinUI.WinUIProjectTemplates. After WinUI 3.0 is released, the templates will likely be included with Visual Studio.

> The source code for this chapter is available on GitHub at this URL: https://github.com/PacktPublishing/-Learn-WinUI-3.0/tree/master/Chapter01.

### *NOTE*

*The WinUI 3.0 site on Microsof Docs has up-to-date guidance on setting up a developer workstation for WinUI development: https://docs.microsoft.com/en-us/uwp/toolkits/winui3/*.

## Before UWP - Windows 8 XAML applications

Before UWP applications were launched with Windows 10 in 2015, there were XAML applications for Windows 8 and 8.1. The XAML syntax and many of the **application programming interfaces (APIs)** were the same, and they were Microsoft's next step in an attempt to achieve universal app development acros desktop, mobile, and other platforms (Xbox, mixed reality, and so on). A XAML app could be written for Windows 8 and Windows Phone. These projects would generate separates sets of binaries that could be installed on a PC or a Windows Phone.

These apps had many other limitations that modern UWP apps do not. For instance, they only  ran fullscreen, as shown in the following screenshot:

Figure 1.1 -- Windows 8 fullscreen app (sourced from Stack Overflow; reproduced under CC BY-SA 4.0 - https://creativecommons.org/licenses/by-sa/4.0/)

Many other early restrictions on Windows 8 apps have been lessened or completely removed in UWP app development. Figure 1.2, which follows, documents these changes:

| | Windows 8 XAML App | Windows 10 UWP App |
|-|--------------------|--------------------|
| Window Type | Full Screen Only | Resizable Window |
| Device Type | Runs on PC only  | Multiple Windows 10 device types |
| Number of Instances | 1 | 1 (default) or Multiple |
| Console App Supported | No | Yes |
| File System Access | Sandboxed - local storage only | Sandboxed by default, App can request additional access to user folders and removable devices |