# VCard

This Package enables you to create contact cards..

This is a type of file ending with ".vcf"

You can easily create such files using this package..

Installing this package:
Add this nuget package to your project..
Nuget page: https://www.nuget.org/packages/VCard/

Create a new Contact:
Add the following namespaces to your project..
VCard.Models
VCard.Helpers

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
    Email = "someone@examplemail.com",
    FormattedName = "Satvik",
    Organization = "Nuget",
    Title = "Satvik"
};
```
To get the vcard use the following command:
```C#
FileHelper.CreateVCard(contact);
```

The following command will return a string..
So we can get it using the following command:

```C#
string contents = FileHelper.CreateVCard(contact);
```

Now we can use the string to create the physical file..
```C#
string contents = FileHelper.CreateVCard(contact);
File.WriteAllText("FileName.vcf", contents);
```
Please make sure that you use the file extention as vcf..

#Support
All I have ever asked is to be active by submitting bugs, features and downloading this package..
