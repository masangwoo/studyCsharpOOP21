using System;
using System.Reflection;
using System.Reflection.Metadata;

namespace DynCreationTestApp
{
    class Profile
    { 
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public void Print() { Console.WriteLine($"{Name}, {PhoneNumber}"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //일반적인 객체생성 방식
            Profile profile1 = new Profile();
            profile1.Name = "박찬호";
            profile1.PhoneNumber = "010-9975-5511";
            profile1.Print();

            //리플렉션 객체생성
            Type type = typeof(Profile);
            object profile2 = Activator.CreateInstance(type);
            PropertyInfo name = type.GetProperty("Name");
            PropertyInfo phonenumber = type.GetProperty("PhoneNumber");
            name.SetValue(profile2, "류현진", null);
            phonenumber.SetValue(profile2, "010-9999-9999", null);

            MethodInfo print = type.GetMethod("print");
            print.Invoke(profile2, null);
        }
    }
}
