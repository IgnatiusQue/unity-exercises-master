using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Person
{
    public int Age { get; set; }
    public string Name { get; set; }

    public Person(int age, string name)
    {
        Age = age;
        Name = name;
    }

    public int DateOfBirth()
    {
        return 2013 - Age;
    }
}

