# Zone.Epi.BlankLoginBackground
Change the Episerver CMS login screen background to a basic blank background.

![Demo-Image](https://raw.githubusercontent.com/zone/Zone.Epi.BlankLoginBackground/master/img/Login_Usage.PNG)

## Installation
You can install the package using NuGet with `Install-Package Zone.Epi.BlankLoginBackground`. For release info check the [Episerver feed package details](https://nuget.episerver.com/package/?id=Zone.Epi.BlankLoginBackground).

## Usage
No configuration is needed, simply install the package. If you would like to use a different image replace the image located in `/Static/Images/CMS/login-background.jpg` with a new image using the same name and format.

If you require more options and customization see [this post](http://jondjones.com/learn-episerver-cms/episerver-developers-guide/episerver-customizing-episervers-ui/how-to-change-the-image-and-logo-on-the-log-in-page-in-episerver-9).

## Updating the package
Simply run `dotnet pack` in the root directory.