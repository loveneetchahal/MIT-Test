//static int equivalentArrays(int[] a1, int[] a2)
//{
//    Dictionary<int, int> dic1 = new Dictionary<int, int>();
//    Dictionary<int, int> dic2 = new Dictionary<int, int>();

//    foreach (int num in a1)
//    {
//        if (!dic1.ContainsKey(num))
//            dic1[num] = 0;
//        dic1[num]++;
//    }

//    foreach (int num in a2)
//    {
//        if (!dic2.ContainsKey(num))
//            dic2[num] = 0;
//        dic2[num]++;
//    }

//    foreach (var pair in dic1)
//    {
//        if (!dic2.ContainsKey(pair.Key))
//            return 0;
//    }

//    foreach (var pair in dic2)
//    {
//        if (!dic1.ContainsKey(pair.Key))
//            return 0;
//    }

//    return 1;
//}

//Console.WriteLine(equivalentArrays([0, 2, 1, 2], [3, 1, 2, 0]));

//static int isStepped(int[] a)
//{
//    if (a.Length < 3) return 0;

//    for (int i = 0; i < a.Length - 1; i++)
//    {
//        if (a[i] > a[i + 1]) return 0;
//    }

//    Dictionary<int, int> dicvalues = new Dictionary<int, int>();
//    foreach (int num in a)
//    {
//        if (!dicvalues.ContainsKey(num))
//            dicvalues[num] = 0;
//        dicvalues[num]++;
//    }

//    foreach (var count in dicvalues.Values)
//    {
//        if (count < 3) return 0;
//    }

//    return 1;
//}

//Console.WriteLine(isStepped([1, 1, 1, 5, 5, 5, 5, 8, 8, 8]));

static int isOneTwoOneArray(int[] a)
{
    if (a == null || a.Length < 3) return 0;
     
    if (a[0] != 1) return 0;
     
    int firstOnesCount = 0;
    int i = 0;
    while (i < a.Length && a[i] == 1)
    {
        firstOnesCount++;
        i++;
    }
     
    bool foundTwo = false;
    while (i < a.Length && a[i] == 2)
    {
        foundTwo = true;
        i++;
    }
    if (!foundTwo) return 0;

    int endOnesCount = 0;
    while (i < a.Length && a[i] == 1)
    {
        endOnesCount++;
        i++;
    }

    if (i != a.Length || firstOnesCount != endOnesCount)
        return 0;

    return 1;
}

Console.WriteLine(isOneTwoOneArray([1, 1, 2, 2, 2, 1, 1]));