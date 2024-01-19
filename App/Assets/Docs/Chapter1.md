# Section 1: Introduction to WinUI and Windows Applications

WinUI 3.0 is Microsoft's new UI framework for Windows developers. This section will start by exploring the recent history of XAML and Windows UI frameworks and introduce readers to WinUI. hroughout the chapters of this section, you will learn about WinUI concepts by building a simple project from scratch, adding controls and features by following design patterns and best practices. These patterns and practices include the **Model-View-ViewModel (MVVM)** design pattern, unit testing WinUI projects, and using **dependency injection (DI)** to inject service dependencies into the application components.

This section includes the following chapters:

- *Chapter 1, Introduction to WinUI*
- *Chapter 2, Configuring the Development Environment and Creating the Project*
- *Chapter 3, MVVM for Maintainability and Testability*
- *Chapter 4, Advanced MVVM Concepts*
- *Chapter 5, Exploring WinUI Controls*
- *Chapter 6, Leveraging Data and Services*

<!--

    Page Break

-->

# Chapter 1: Introduction to WinUI

WinUI is a set of open source controls and libraries that Windows developers can leverage in their **Universal Windows Platform (UWP)** and Win32 applications. UWP developers use the Windows **software development kit (SDK)** to build their applications and are required to select a target SDK version in a project's properties. By extracting the UWP controls and **user interface (UI)** components from the Windows SDK and releasing them as a set of open source libraries under the name WinUI, Microsoft is able to release versions at a faster cadence than Windows itself (as Windows SDK versions are linked to those of Windows). This separation also enables the controls to be used on older versions of Windows 10. While building UWP and Win32 applications with WinUIis the current recommendation, it is important to learn where WinUI and UWP fit in the larger Windows development landscape.

In this book, you will learn how to build applications for Windows withe WinUI 3.0 libraries. Throughtout the course of the book, we will build a real-world application using recommended patterns and practices for Windows application development.

Before we start building our WinUI app, it's important to have a good foundation in Windows client development, the different types of **Extensible Application Markup Language (XAML)** UI markup, and how WinUI compares toother Windows desktop development frameworks. Therefore, in this first chapter, you will start by learning some background on UWP and WinUI.

- What UWP is and why Microsoft created yet another application framework
- How XAML can be leveraged to create great UIs on many device sizes and families
- Why WinUI was created and how it relates to UWP
- Where WinUI fits in the Windows developer landscape
- What WinUI 3.0 brings to the table

Don't worry! It won't take very long to cover the background stuff, and it will help provide some context as you start building your WinUI app. In the next chapter, you will get your hands on some code when you create your first WinUI project.

# Technical requirements

To follow along with the examples in this chapter, the following software is required:

- Windows 10 version 1803 or newer. You can find your version of Windows in Settings | About.
- Visual Studio 2019 version 16.9 or newer with the following workloads: .NET Desktop Development and UWP Development.
- WinUI 3.0 project templates -- at the time of this writing, the templates can be downloaded from Visual Studio Marketplace at https://marketplace.visualstudio.com/items?itemName=Microsoft-WinUI.WinUIProjectTemplates. After WinUI 3.0 is released, the templates will likely be included with Visual Studio.

> The source code for this chapter is available on GitHub at this URL: https://github.com/PacktPublishing/-Learn-WinUI-3.0/tree/master/Chapter01.

#### *NOTE*

*The WinUI 3.0 site on Microsof Docs has up-to-date guidance on setting up a developer workstation for WinUI development: https://docs.microsoft.com/en-us/uwp/toolkits/winui3/*.

# Before UWP - Windows 8 XAML applications

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

## Windows application UI design

The term *Metro Style* was used to define the design and layout of Windows 8 apps. Metro Style apps were designed to be usable with touch input, mouse and keyboard, or a stylus. Microsoft's introduction of the first Windows Phone was a driving factor for Metro Style design. Metro Style later became Modern UI design, with the introduction of Surface devices. Aspects of Metro live on today, in UWP apps and Windows 10.

Live Tiles were born with Metro Style. These tiles on the user's Windows 8 home screen and Windows 10 Start menu can update to display live updates to users without having to open the app. Most of Microsoft's own apps for Windows support Live Tiles. The Weather app can show live updates to current weather conditions on the tile, based on the user's current location. You will explore Live Tiles further in *Chapter 5, Exploring WinUI Controls and libraries*.

## Windows Runtime (WinRT)

Another term that has its roots in Windows 8 app development is WinRT. The letters RT became a source of great confusion. WinRT was short for Windows Runtime, the underlying APIs used by Windows XAML apps. There was also a version of Windows 8 called Windows RT that supported **Advanced RISC Machines (ARM)** processors. The first Surface PC was the Surface RT, which ran the Windows 8 RT operating system.

Although WinRT can still be used today to define the WinRT APIs consumed by UWP apps, you will not see te term as often. We will also avoid using WinRT in this book and instead refer to the APIs as the UWP or Windows APIs.

## User backlash and the path forward to Windows 10

While Microsoft pushed hard to win over users with Modern UI design, an new app model, Surface PCs, and Windows 8 and 8.1, the idea of a fullscreen, touch-first app experience and a deemphasized Windows desktop was never embraced by customers. It turns out that Windows users really like the start menu experience that used for years with Windows XP and Windows 7.

The next step in Windows app development was a big one&mdash;so big, in fact, that Microsoft decided to skip a number in their versioning, jumping straight from Windows 8.1 to Windows 10.

# Windows 10 and UWP application development

While taking a leap forward with the launch of Windows 10, Microsoft also blended the best of what worked in previous versions of Windows. They brought back the start menu, but its contents look an awful lot like the Windows 8 home screen experience. In addition to an alphabetized list of all installed apps, there is a resizable area for pinned app tiles. In fact, when runing Windows in Tablet Mode, the start menu can tranform into the Windows 8-style home screen experience for better usability on a touchscreen.

When Microsoft launched Windows 10, they also introduced UWP applications to Windows developers. While UWP apps have their roots in the XAML apps of Windows 8, there are some key differences that give developers some major advantages when building apps for the platform.

A key advantage is in the Universal aspect of these apps. Microsoft builds versions of Windows 10 to run on different deveice families, listed as follows:

- Desktop (PC)
- Xbox
- Mobile (Windows Phone)
- HoloLens
- IoT
- IoT Headless
- Team (Surface Hub)

UWP developers can build apps to target any of these devices. There is a single base set of Windows APIs shared across all these targets, and specialized SDKs available for the device-specific APIs of some families&mdash;for instance, you can create a project that creats apps for Desktop, Xbox, and Team families.

Because the UWP XAML for building the app's UI is the same, the learning curve for cross-device development is lowered and code reusability is very high.The nature of XAML provides a UI flexibility to adapt to differnt device sizes and aspect ratios.

## Language choice with UWP development

While the underlying UWP APIs were written in C++, UWP developers can choose from a number of programming languages when building apps for Windows. UWP projects can be created with any of these popular languages:

- C#
- C++
- F#
- Visual Basic .NET (VB.NET)
- JavaScript

You may be surprised to see JavaScript on the list. During the Windows 8.x days, developers could create JavaScript apps with APIs known as WinJS apps. Today, Microsoft has created a branch of React Native for Windows developers, known as React Native for Windows. These JavaScript client apps have ful access to the same Windows APIs as other UWP apps and can be packaged and deployed through the Windows Store.

### *NOTE*

*React Native for Windows is an open source project hosted by Microsoft on GitHub at https://github.com/Microsoft/react-native-windows.*

WHile many of the UWP apps developed for Windows 10 by Microsot are created with C++, most other developers choose C#. We will also use C# when building our app throughout the course of this book.

## Lifting app restrictions

As discussed earlier, apps built for Windows 8 had a number of restrictions that have been either removed or relaxed with UWP.

First and fremest