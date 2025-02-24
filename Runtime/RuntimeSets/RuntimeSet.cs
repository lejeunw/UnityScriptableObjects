﻿using System.Collections.Generic;
using UnityEngine;

namespace UnityScriptableObjects.Runtime.RuntimeSets
{
  public class RuntimeSet<T> : ScriptableObject
  {

    List<T> items = new List<T>();
    public List<T> Items => items;

    public void Add(T t)
    {
      items.Add(t);
    }

    public void Remove(T t)
    {
      items.Remove(t);
    }

  }
}