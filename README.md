# VCard

This Package enables you to create virtual contact cards(VCF).

You can easily create VCards with single or multiple Phone numbers and Emails in a single contact without much hazzle..

Installing this package:
Add this nuget package to your project..
```
dotnet add package VCard --version 2.0.0
```

Create a new Contact:
Add the following namespaces to your project.
```C#
using VCard.Models;
using VCard.Helpers;
```

Code to create a new contact:
```C#
Contact contact = new Contact
{
    FirstName = "Satvik",
    LastName = "Rajnarayanan",
    Addresses = new System.Collections.Generic.List<Address>()
    {
        new Address{Description="Example home address", Type="Home" }
    },
    Phones = new System.Collections.Generic.List<Phone>()
    {
        new Phone{Number="0000000000", Type="Home"}
    },
    Email = new System.Collections.Generic.List<Email>()
    {
        { new Email(){ Mail="youremail", Type="Home"} }
    },
    FormattedName = "Satvik",
    Organization = "Nuget",
    Title = "Satvik"
};
```
To get the vcard use the following command:
```C#
CardHelper.CreateVCard(contact);
```

This returns the VCard as a string which could be used to save it in your system..
```C#
string contents = FileHelper.CreateVCard(contact);
File.WriteAllText("FileName.vcf", contents);
```
Please make sure that you use the file extention as vcf..
