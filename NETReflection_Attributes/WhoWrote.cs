using System;

namespace NETReflection_Attributes.myCustomAttributes
{
    [System.AttributeUsage(System.AttributeTargets.Class |
                            System.AttributeTargets.Property |
                            System.AttributeTargets.Method |
                            System.AttributeTargets.Constructor)
    ]
    public class WhoWrote : System.Attribute
    {
        public string usrName;
        public double version;

        public WhoWrote(string usrName, double version = 1.0)
        {
            this.usrName = usrName;
            this.version = version;
        }
    }
}