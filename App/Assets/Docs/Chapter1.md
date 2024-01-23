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

First and foremost, today's UWP apps can run in resizable windows, just like any other Windows desktop application. The trade-off is that developers now need to test for and handle the resizing of their app to almost any size. The dynamic nature of XAML can handle much of the resizing very well, but below a certain minimum size, scroll bars will need to be employed.

For end users, one of the benefits of using UWP apps is the inherent security they provide due to the limited access of apps to the PC's filesystem. By default, each app can only access its own local storage. In 2018, the Windows developer team announced a new feature for UWP developers. By adding some app configuration declaring which additoinal types of access the app requires, applications can request access to additional parts of the filesystem. Among them are the following:

- User libraries, including Documents, Pictures, Music, and Videos
- Downloads
- Removable devices

### *NOTE*

*There are additional filesystem permissions that can be requested. See the Microsoft documentation for an entire list: https://docs.microsoft.com/en-us/windows/uwp/files/file-access-permissions.*

Any additional permissions requested will be declared on the app's listing on the Windows Store.

Some less common scenarios are now available to UWP apps on Windows 10. Developers can add some configuration and startup code to enable multiple instances of their app to launch. While it would seem that the point of a UWP ap is the XAML UI, it is now possible to create a UWP console app. The app will run at the command line and have access to Universal C runtime calls. Developers who want to get startted with console apps can find project templates on Visual Studio Marketplace, at https://marketplace.visualstudio.com/items?itemName=AndrewWhitechapelMSFT.ConsoleAppUniversal.

## UWP backward compatibility

No UWP app is compatible with any version of Windows before Windows 10. Beyond this, each UWP app must declare a **Target Version** and a **Minimum Version** of Windows with which it is compatible. The target version is your recommended version, which will enable all of an app's features and functionality. The minimum versin is, unsurprisingly, the minimum version of Windows that users must have to be able to install an app from the Windows Store.

Visual Studio will prompt you to select these versions when creating a new UWP project. If the two are the same, it keeps things simple. You will have all of the APIs of that SDK version available to the app. If the target version is greater than the minimum version, you need to add some conditional code to light up the features of any versions greater than the minimum. The app must still be useful to users running the minimum version; otherwise, it is advisable to increase the minimum. If any of the newer APIs or controls are fundamental to the app, it is also recommended that the minimum version be increased to one where those are available.

### *NOTE*

*Fore more information on writing the conditional or version adaptive code, see the Microsoft documentation here: https://docs.microsoft.com/en-us/windows/uwp/debug-test-perf/version-adaptive-code*.

If you are creating .NET libraries that will be referenced by your UWP project and you would like to share them across other platforms, perhaps by a Xamarin mobile app, a .NET Standard version should be targeted by the shared library project. The most common .NET standard version today is .NET Standard 2.0. To reference a .NET Standard 2.0 project from a UWP project, the target version of the UWP project should be 16299 or later.

The primary benefit of WinUI over UWP is that it lessens the dependency of Windows apps on a particular version of Windows. Instead, the controls, styles, and APIs are maintained outside of the Windows SDK. As of this writing, the minimum version required for a WinUI 3.0 app is 17134 or higher, and the target version must be set to 18362 or higher. Chec k the latest WinUI documentation for the current minimum requirements.

The hope for WinUI is to bring a greater number of controls and features to more supported versions of Windows 10 as the project matures.

# What is XAML?

**XAML** is based on **Extensible Markup Language (XML)**. This would seem like a great thing as XML is a felxible markup language familiar to most developers. It is indeed flexible and powerful, but is has some drawbacks.

The primary problem with Microsoft implementations of XAML is that there have been so many variations of the XAML language created for different development platforms over the years. Currently, UWP, **Windows Presentation Foundation (WPF)**, and Xamarin.Forms applications all use XAML as their UI markup language. <span style="border-bottom: 1px dashed black">However, each of these uses a different XAML implementation or schema, and the markup cannot be shared across the platforms.</span> In the past, Windows 8, Sliverlight, and Windows Phone apps also had other different XAML schemas.

If you have never worked with XAML before, you're probably ready to see an example of some UI markup. The following XAML is a fragment that defines a **Grid** containing several other of the basic WinUI controls (you can downloaded the code for this chapter from GitHub here: https://github.com/PacktPublishing/-Learn-WinUI-3.0/tree/master/Chapter01):

```XAML
<Grid Width="400" Height="250" Padding="2"
    HorizontalAlignment="Center"
    VerticalAlignment="Center">
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="Auto"/>
        <ColumnDefinition Width="*"/>
    </Grid.ColumnDefinitions>

    <TextBlock Grid.Row="0" Grid.Column="0"
        Text="Name:"
        Margin="0,0,2,0"
        VerticalAlignment="Center"/>
    <TextBlock Grid.Row="0" Grid.Column="1"
        Text=""/>
    <Button Grid.Row="1" Grid.Column="1" Margin="0,4,0,0"
        HorizontalAlignment="Right"
        VerticalAlignment="Top"
        Content="Submit"/>
</Grid>
```

Let's break down the XAML here. The top level of a UWP window is **Page**. UWP app naviagtion is page-based, and this top-level navigation happens within a root **Frame** container in the **App.xaml** file in the project. You will learn more about page navigation in *Chapter 4, Advanced MVVM Concepts*. A **Page** must contain only one child, usualy some type of layout panel such as a **Grid**, or **StackPanel**. By default, a **Grid** is inserted as that child. We will discuss other types of panels that serve as a good parent container in the next chapter. I made a few modifications to the **Grid**.

**Height** and **Width** properties provide a static size fr the example, and **HorizontalAlignment** and **VerticalAlignment** properties will center the **Grid** on the **Page**. Fixed sizes are uncommon at this level of the XAML and limit the flexibility of the layout, but they illustrate some of the available attributes.

A **Grid** is a layout panel that allows developers to define rows and columns to arrange its elements. The rows and columns can have their sizes defined as fixed, relative to each other, or auto-sized based on their contents. For more information, you can reada the Microsoft Docs article *Responsive layouts with XAML*: https://docs.microsoft.com/en-us/windows/uwp/design/layout/layouts-with-xaml.

The **Grid.RowDefinitions** block defines the number and behavior of the grid's rows. Out grid will have two rows. The first one has **Height="Auto"**, which means it will resize itself to fit its contents, provided enough space is available. The second row has **Height="*"**, which means the rest of the grid's vertical space will be allocated to this row. If multiple rows have their height defined like this, they will evenly split the available space. We will discuss additional sizing options in the next chapter.

The **Grid.ColumnDefinitions** block does for the grid's columns what **RowDefinitions** did for the rows. Our grid has two columns defined. The first **ColumnDefinition** has its **Height** set to **Auto**, and the second has **Height="*"**.

**TextBlock** defines a alabel in the first **Grid.Row** and **Grid.Column**. When working with XAML, all indexes are 0-based. In this case, the first **Row** and **Column** are both at positon **0**. The **Text** property conveniently defines the text to display, and the **VerticalAlignment** in this case will vertically center the text for us. The default **VerticalAlignment** for a **TextBlock** is **Top**. The **Margin** property adds some padding around the outside of the control. A margin with the same amount of padding on all sides can be set as a single numeric value. In our case, we only want to add a couple of pixels to the right side of the control to separate it from **TextBox**. The format for entering these numeric value is **"&lt;LEFT&gt;,&lt;TOP&gt;,&lt;RIGHT&gt;,&lt;BOTTOM&gt;"**, or **"0,0,2,0"** here.

The **TextBox** is a text entry field defined in the second column of the rid's first row.

Finally, we've added a **Button** control to the second column of the grid's second row. A few pixels for top margin are added to separate it from the controls above. The **VerticalAligment** is set to **Top** (the default is **Center**) and **HorizontalAlignment** is set to **Right** (the default is **Center**). To set the text of the **Button**, you don't use the **Text** property like we did with the **TextBlock**, as you might think. In fact, there is not **Text** property. The **Content** property of the **Button** is used here. **Content** is a special property that we will discuss in more detail in the next chapter. For now, just know that a **Content** property can contain any other control: text, an **Image**, or even a **Grid** control containing multiple other children. The possibilities are virtually endless.

Here is the UI that gets rendered by the receding markup:

(A SAMPLE IMAGE)
<!-- SAMPLE -->
Figure 1.3 &mdash; WinUI XAML renderd

This is a very simple example to give you a first taste of what can be crated with XAML. As we move ahead, you will learn how powerful the language can be.

## Creating an adaptive UI for any device

In the previous example, the **Grid** had fixed **Height** and **Width** properties. I mentioned that setting fixed sizes can limit a UI's flexibility. Let's remove the fixed size properties and use the alignment properties to guide the UI elements, to render how he want them to at different sizes and aspect ratios, as follows:

```XAML
<Grid VerticalAlignment="Top" HorizontalAlignment="Stretch" Padding="2">
```

The rest of the markup remains unchanged. The result is a **TextBox** that resizes to fit the width of the window, and the **Button** remains anchored to the right oof the window as it resizes. See the window resizesd a couple of different ways here:

(A SAMPLE IMAGE)
Figure 1.4 &mdash; Resized windows

If you were using this app on a tablet PC, the contents would resize themselves to fit in the available space. That is the power of XAML's adaptive nature. When building a UI, you will usually want to choose relative and adaptive properties such as alignment to fixed sizes and positions.

It's this adaptive layout that makes XAML work so well on mobile devices with Xamarin, and this is why WPF developers have loved using it since its launch with Windows Vista.

## Powerful data binding

Another reason why UWP and other XAML-based frameworks are so popular is the ease and power of their data-binding capabilities. Nearly all properties on UWP controls can be data-bound. The source of the data can be an object or a list of objects on the data source. In most cases, that source will be a **ViewModel** class. Let's have a very quick look at using UWP's **Binding** syntax for data binding to a property on a **ViewModel** class, as follows:

1. First, we will create a simple **MainViewModel** class with a **Name** property, like this:

```csharp
public class MainViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public MainViewModel()
    {
        _name = "Bob Jones";
    }
    
    private string _name;
    public string Name
    {
        get { return _name; }
        set
        {
            if (_name == value) return;
            _name = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
        }
    }
}
```

The **MainViewModel** class implements an interface called **INotifyPropertyChanged**. This interface is key to the UI receiving updates when data-bound properties have changed. This interface implementation is typically wrapped either by a **Model-View-ViewModel (MVVM)** framework, such as Prism or MvvmCross, or with your own **ViewModelBase** class. For now, we will directly invoke a **PropertyChanged** event inside the **Name** property's setter. We will learn more about **ViewModels** and the **INotifyPropertyChanged** interface in *Chapter 3, MVVM for Maintainability and Testability*.

2. The next step is to create an instance of the **MainViewModel** class and set it as the **ViewModel** for our **MainPage**. This happens in the code-behind fiel for the page, **MainPage.xaml.cs**, as illustrated in the following code snippet:

```csharp
public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        this.ViewModel = new MainViewModel(); // add
    }
    public MainViewModel ViewModel { get; set; } // add
}
```

We have added a **ViewModel** property to the **MainPage** and set it to a new instance of our **MainViewModel** class in the constructor.

### *TIP*

*Any code added to a page's constructor should be added after the call to **InitializeComponent()**.*

3. Now, it's time to add the data -binding code to the XAML markup for the **TextBox**, as follows:

```XAML
<TextBox 
    Grid.Row="0" 
    Grid.Column="1" 
    Text="{x:Bind Path=ViewModel.Name, Mode=TwoWay}">
```

Some markup has been added to set the **Text** property using the **x.Bind** markup extension. The data-binding **Path** is set to the **Name** property on the **ViewModel**, which has been assigned in the code-behind file in the preceding *Step 2*. By setting the data-binding mode to **TwoWay**, updates in the **ViewModel** will display in the UI, and any updates by the user in the UI will also be persisted in the **Name** property of the **MainViewModel** class. Now, running the app will automatically populate the name that was set in the constructor of the **ViewModel**, as illustrated in the following screenshot:

(A SAMPLE IMAGE)
ここまでの注意。つまり、ViewModelは、View側のコンストラクタでnewしておくデータストレージだが、XAMLで特殊な設定をしておくと、画面側の操作で変更した値が即座に保管されたり、他の場所で操作されたデータが即座に画面上に反映されたりするというのがViewModelの特徴のようだ。それを実現しているのが、**INotifyPropertyChanged**、というキーワードなのだと思われる。

4. To illustrate data binding to another property on another UI element on the page, we will first modify the grid to add a name, as follows:

```XAML
<Grid x:Name="ParentGrid"
    VerticalAlignment="Top" HorizontalAlignment="Stretch" Padding="2">
```

5. Now add another **RowDefinition** to the **Grid** to fit the new UI element in the page:

```XAML
<Grid.RowDefinitions>
    <RowDefinition Height="Auto"/>
    <RowDefinition Height="Auto"/> <- Add this!
    <RowDefinition Height="*"/>
</Grid.RowDefinitions>
```

6. Next, add a **TextBlock** element and use the **Binding** markup extension to bind its **Text** property to the **ActualWidth** of the **ElementName** set to **ParentGrid**. We are also adding a **TextBlock** to label this as the **ActualWidth**:

```XAML
<TextBlock Grid.Row="1" Grid.Column="0"
    Text="Actual Width:" Margin="0,0,2,0" VerticalAlignment="Center"/>
<TextBlock Grid.Row="1" Grid.Column="1"
    Text="{Binding ElementName=ParentGrid, Path=ActualWidth}"/>
```

7. Next, update the **Submit Button** to apear in **Grid.Row** 2.

8. Now the new **TextBlock** control displays the width of the **ParentGrid** when the page is loaded. Note that it will not update the value if upi resize the window. The **ActualWidth** property does not raise a property change notification. This is documented in the **FrameworkElement.ActualWidth** docs: https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.frameworkelement.actualwidth:

(A SAMPLE IMAGE)
Figure 1.6 &mdash; Data binding to another element

This **Submit** button does not function yet. You will learn how to work with **Events** and **Commands** with MVVM in *Chapter 5, Exploring WinUI Controls and Libraries*.

## Styling your UI with XAML

When working with XAML, styles can be defined and applied at almost any scope, global to the application in **App.xaml**, in the current **Page** inside a **Page.Resources** declaration, or inside any level or nested control on the page. The **Style** property specifies a **TargetType** property, which is the data type of the elements to be targeted by the style. It can optionally have a **Key** propoerty defined as a unique identifier, similar to a class identifier in **Cascading Style Sheets (CSS)**. That **Key** property can be used to apply the style to only selected elements of that type. Only one **Key** property can be assigned to an element, unlike with CSS classes.

In the next example, we will modify the page to define a **Style** property for all buttons on the page, as follows:

1. Start by moving the **Submit** button to be nested inside a **StackPanel** element. A **StackPanel** element stacks all child elements in a horizontal or vertical orientation, with vertical being the default orientaion. Some of the button's properties will need to be moved to the **StackPanel** element, as it is now the direct child of the **Grid**. After adding a second button to the **StackPanel** element to act as a **Cancel** button, the code for the **StackPanel** and **Button** elements should look like this:

```XAML
<StackPanel Grid.Row="1" Grid.Column="1"
    Margin="0,4,0,0" HorizontalAlignment="Right" VerticalAlignment="Top" Orientation="Horizontal">
    <Button Content="Submit" Margin="0,0,4,0"/>
    <Button Content="Cancel"/>
</StackPanel>
```

A new margin has been added to the first button to add some space between the elements.

2. Next, we will add a **Style** block to the **Page.Resource** section to style the buttons. Because no **Key** is assigned to the **Style** block, it will apply to all **Button** elements that do not have their styles overridden in an inner scope. This is known as an *implicit style*. The code for this is shown here:

```XAML
<Page.Resources>
    <Style TargetType="Button">
        <Setter Property="BorderThickness" Value="2"/>
        <Setter Property="Foreground" Value="LightGray"/>
        <Setter Property="BorderBrush" Value="GhostWhite"/>
        <Setter Property="Background" Value="DarkBlue"/>
    </Style>
</Page.Resources>
```

3. Now, when you run the app, you will see that the new style has been applied to both the **Submit** and **Cancel** buttons without adding any styling directly to each control, as illustrated in the following screenshot:

(A SAMPLE IMAGE)
Figure 1.7 &mdash; Styled buttons

If we moved the **Style** block to the **Application.Resources** section, the definedd style would get applied to every button in the entire app unless the developer had individually overriden some of the properties in the style. For instance, if the **Submit** button had a Background property set to **DarkGreen**, only the **Cancel** button would appear as dark blue.

We will spend more time on styles and design in *Chapter 7, Windows Fluent UI Design*.

## Separating presentation from business logic

We looked briefly at the MVVM pattern in the earlier section on data binding. MVVM is key to the separation of presentation logic from business logic in UWP application development. The XAML elements only need to know that there is a property with a particular name somewhere in its data context. The **ViewModel** classes have no knowledge of the **View** (our XAML file).

This separation provides several benefits. First, **ViewModels** can be unit tested independently of the UI. If any UWP elements are referenced by the system under test, the UI thread is needed. This will cause tests to fail when they're running on background threads locally or on a **Continuous Integration (CI)** server. See *Chapter 3, MVVM for Maintainability and Testability* for more information on unit testing WinUI applications.

The next benefit of **View/ViewModel** separation is that businesses with dedicated **user experience (UX)** experts will sometimes work on designing the XAML markup for an app while other developers are building the **ViewModels**. When it is time to sync up the two, the developer can add in the necessary data-binding properties to the XAML, or perhaps the UX designer and developer have already agreed upon the names of the properties in the shared data context. Visual Studio includes another tool geared toward designers in this workflow, called Blend for Visual Studio. Blend was first released by Microsoft in 2006 as Microsoft Expression Blend, as a tool for designers to create UIs for WPF. Support was later added for other XAML languages such as Silverlight and UWP. Blend is still included with the UWP development workload when installing Visual Studio. 

A final benefit we will discuss here is that a good separation of concerns between any layers of your application will always lead to better maintainability. If there are multiple components involved in a single responsibility or if logic is duplicated in multiple places, this leads to buggy code and unreliable applications. Follow good design patterns, and you will save yourself a lot of work down the road.

Now that you have a good understanding of the history of UWP applications, it's time to look at WinUI: what it is, and why it was created.

# What is WinUI?

The WinUI library is a set of controls and UI components that have been extracted from the Windows SDK. After this separation, many controls have been enhanced and others have been added. The libraries have been made available as open source on GitHub and are maintained by Microsoft and the Windows developer community.

So, if these WinUI libraries came from UWP libraries in the Windows SDK, you may be wondering why you should choose WinUI as your UI framework instead of UWP. UWP has been around since the launch of Windows 10 and is quite robust and stable. There are actually several very good reasons to consider WinUI.

Choosing WinUI brings with it all the benefits of open source. **Open source software (OSS)** is typically very reliable. When software is developed in the open by an active developer community, issues are found and resolved quickly. In fact, if you find an issue with an open source package, you can fix it yourself and submit a pull request to have the fix made available to the rest of the community. Open source projects can iterate quickly without having to remain in sync with product groups in a large enterprise such as the Windows team. Windows releases feature updates on a regular cadence now, but this is still less frequent than with a typical control library.

The best reason to use WinUI is its backward compatibility. When using a UWP control, the features and fixes in a specific version of the control cannot be deployed in apps to older versions of Windows. With WinUI, so long as you are targeting the minimum version of Windows supported by WinUI as a whole, you can use those new controls and features in multiple Windows versions. Controls not previously available to UWP developers on one version of Windows are now available there as WinUI controls.

For instance, Microsoft did not introduce the Fluent UI design to Windows until the Fall 2017 release (version *16299*). However, WinUI controls can be included in apps targeting a minimum Windows version of 10.0.15063.0, the Spring 2017 release. The controls in WinUI support Fluent UI styles. WinUI adds controls and other features that are not available at all in UWP and the Windows SDK.

## The first WinUI release

The first version of WinUI was released in July 2018 as a preview release for Windows developers. It was released as the following two NuGet packages:

- **Microsoft.UI.Xaml**: The WinUI controls and Fluent UI styles.
- **Microsoft.UI.Xaml.Core.Direct**: Components for middleware developers to access the **XamlDirect** API.

3 months later, WinUI 2.0 was released. Despite the version number, it was the first production release of WinUI. The release included more than 20 controls and brushes. A few notable controls included the follwing:

- **TreeView**: A staple of any UI library.
- **ColorPicker**: A rich visual color picker with a color spectrum.
- **DropDownButton**: A button with the ability to open a menu.
- **PersonPicture**: An image control for displaying an avatar. It has the ability to fall back to displaying initials or a generic placeholder image.
- **RatingControl**: Allows users to enter star rating for items.

Let's add a few of these controls to our WinUI project and see how they look. Chaange the contents of the **StackPanel** to look like this:

```XAML
<StackPanel Grid.Row="1" Grid.Column="1" Margin="0,4,0,0"
    HorizontalAlignment="Right"
    VerticalAlignment="Top"
    Orientation="Horizontal">
    <PersonPicture Initials="MS" Margin="0,0,8,0"/>
    <DropDownButton Content="Submit" Margin="0,0,4,0">
        <DropDownButton.Flyout>
            <MenuFlyout. Placement="Bottom">
                <MenuFlyoutItem Text="Submit + Print"/>
                <MenuFlyoutItem Text="Submit + Email"/>
            </MenuFlyout>
        </DropDownButton.Flyout>
    </DropDownButton>
    <Button Content="Cancel"/>
</StackPanel>
```

A **PersonPicture** control with the initials **MS** has been added as the first item in the **StackPanel**, and the first of the two buttons has been replaced by a **DropDownButton** control. The **Submit DropDownButton** control has **FlyoutMenu** serving as a drop-down list, and there are two **MenuFlyoutMenuItem** elements. Now, users can simply click the **Submit** button, or they can select **Submit + Print** or **Submit + Email** from the drop-down list.

### *NOTE*

***DropDownButton** is only available in Windows 10 version 1809 and later. If you use this control in a production application, you should set this as your minimum version for the project.*

This is how the new window appears with the **DropDownButton** menu shown:

(A SAMPLE IMAGE)
Figure 1.8 &mdash; Adding a PersonPicture and DropDownButton control

We're only scratching the surface of what the first release can do for Windows developers. Don't worry, as we will dive much deeper in the chapters ahead. Let's briefly look at what was added in subsequent versions leading to WinUI 3.0.

## The road to WinUI 3.0

There have been five additonal minor releases of WinUI following v2.0, in addition to many increental bug fixes and prerelease versions.

### WinUI 2.1

The WinUI 2.1 release brought a number of new controls and features to the library. There are some highlights:

- **TeachingTip**: Think of **TeachingTip** as a rich, context-sensitive tooltip. It is linked to another element on the page and displays informative details about the target element to help guide users with non-instrusive content as needed.

- **AnimatedVisualPlayer**: This hosts Loiite animations. Lottie files are a popular animation format created in **Adobe After Effects** used by designers across Windows, the web, and mobile platforms. There are libraries available to host Lottie animations for most modern development frameworks.<br/>
<i style="font-size:1.3em">NOTE</i><br/>
*Get more information about Lottie files on their website at https://airbnb.design/lottie/ and check out this great repository of Lottie animation files: https://lottiefiles.com/

- **CompactDensity**: Adding this resource dictionary to your app can provide the ability to switch between *Compact* and *Normal* display modes. **CompactDensity** will reduce the spacing within and between elements on the page, providing up to 33% more visible content to users. This Fluent UI design concept was introduced to developers at Microsoft's Build 2018 conference.

### WinUI 2.2

This release brought many enhancements to existing features. However, this single new control added to the library is one that many Windows developers will find useful.

The **TabView** control creates a familiar tabbed user experience on the screen. Each tab can host a page in your WinUI project.

#### WinUI 2.2 enhancements

A few of the notable updated controls and libraries in version 2.2 are listed here:

- **NavigationView**: The **NavigationView** control was enhanced to allow the back button to remain visible when the panel is collapsed. Other visual updates maximize the viewable content of the control.
- **Visual Styles**: Many of the WinUI visual styles were updated, including **CornerRadius**, **BorderThickness**, **CheckBox**, and **RadioButton**. The updates all make the WinUI visuals more consistent and in line with Fluent UI design guidelines.

### WinUI 2.3

In the WinUI 2.3 release, the **ProgressBar** received some updates, and a couple of new controls were added to the library.

There are now two modes available when creting a **Progress Bar** in a WinUI application: **Determinate** and **Interminate**. A determinate progress bar has a known amont of the task to complete and a known current state of the task. An interminate control indicates that a task is ongoing without a known completion time. Its purpose to similar to that of a busy indicator.

#### New controls in WinUI 2.3

The following are a few new controls in this update:

- **NumberBox**: A **NumberBox** control is an input editor that makes it easy to support numeric formatting, up/down incrementing buttons, and inline mathematic calculations. It is a seemingly simnple but practical and powerful control.

- **RadioButtons**: You might be thinking: *Radio buttons have always been available. How is this a new control?* **RadioButton** is actually a control that groups a set of **RadioButton** (*singular*) controls, making it easier to work with them as a single unit.

### WinUI 2.4

When it was released in May 2020, two new features were made available in WinUI 2.4: a **RadialGradientBrush** visual and a **ProgressRing** control.

The brush is similar in use to the **RadialGradientBrsuh** used by WPF developers. It makes it easy to add a gradient to a visual element that radiates out from a central point.

The **ProgrssRing** control, as it sounds, recreates progress bar functionarlity in a circular format. The control is available with a determinate state and an indeterminate state in versin 2.4. An indeterminate **ProgressRing** control displays a repeating animation and is the default state of the control.

Several controls were updated in version 2.4. The **TabView** control was updated to provide more control over how tabs are rendered, including **Compact**, **Equal**, and **Size to Content** modes. **TextBox** controls received a *dark mode* enhancement to keep the content area of the control dark, with white text by default. Finally, the **NavigationView** control was updated with hierarchical navigation, with **Left**, **Top**, and **LeftCompact** modes.

### WinUI 2.5

WinUI 2.5 was released in December 2020 and included a new **InfoBar** control. Several control enhancements and bug fixes were also included in the release.

The **InfoBar** control provides a way to display importatnt status messages to users. The control can display an alert or information icon, an status message, and a link or button allowing users to take action on a message. There is also an option to display a close button to the right of the message. By default, the control includes an icon, message, and close button. Microsoft Docs provides usage guidelines for this new control: https://docs.microsoft.com/en-us/windows/uwp/design/controls-and-patterns/infobar.

Several updates are also available in version 2.5. The **ProgressRing** control received enhancements to the determinate state of the control. The **NavigationView** control was updated to provide customizable **FooterMenuItems**. In previous versions of the **NavigationView** control, the footer area could be shown or hidden but not customized.

We've seen what was available to UWP developers in WinUI 2.x. Now, let's see what youget with WinUI 3.0.

# What's new in WinUI 3.0?

Unlike WinUI 2.0 and the incremental versions that followed, WinUI 3.0 is a major update featuring more than new and improved controls and libraries to use with UWP and .NET 5 apps. In fact, the primary goal of WinUI 3.0 was not to add new controls and features beyond its current UWP counterparts. For version 3.0, the team has made WinUI a complete UI framework that can sit atop the UWP or Win32 application platforms.

### Goodbye UWP?

So, what is happening to UWP? Will my UWP apps stop working?

As previously mentioned, the plan for the UWP UI libraries is to keep providing important security updates, but they will not receive any new features going forward. All new features and updates will be developed for WinUI. New WinUI projects will support all types of Windows UI client. For existing Win32 applications, developers can incrementally upgrade parts of an application to WinUI with the **Xaml Islands** interop control. New applications will developed in WinUI with either .NET Core, written in C# or VB, or with native C++. These clients will sit on top of either the Win32 platform or UWP