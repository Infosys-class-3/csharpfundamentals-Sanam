public class Method
{
    internal string GetData(string fname, string lastname,string address)
    {
        string Out =$"{fname} {lastname} \nAddress: {address}";
        return Out;
    }  

    internal DateTime GetCreatedDateTime()
    {
        return DateTime.Now;
    }

    internal string GetDetails(string firstname,string lastname,string faculty, string height)
    {
        string Out=$"Name: {firstname}  \nlastname:{lastname} \nfaculty:{faculty} \nheight:{height}";
        return Out;
    }
}

