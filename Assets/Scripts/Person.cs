using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Person", menuName = "ScriptableObjects/Person", order = 1)]
public class Person : ScriptableObject
{
    public string name;
    public int age;
    public string birthday;
    public bool ash_ketchum;
}
