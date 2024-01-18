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