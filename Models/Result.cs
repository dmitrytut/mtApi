using System.Collections.Generic;    

public class Result
{
    public KeyValuePair<string, string> Setting {get; private set;}
    
    public Result(string key, string value)
    {
        Setting = new KeyValuePair<string, string>(key, value);
    }
}