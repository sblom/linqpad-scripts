<Query Kind="Statements" />

var list = new SortedList<int,string>(Comparer<int>.Create((a,b) => a == b ? -1 : a - b));

list.Add(1,"First one");
list.Add(2,"First two");
list.Add(1,"Second one");

list.Dump();