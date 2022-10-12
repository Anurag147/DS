
int[] data = new int[] { 10, 20, 25,25,25,30, 32, 32, 35, 37};

Console.WriteLine(SearchIterative(data, 25));
Console.WriteLine(SearchRecursive(data, 0, data.Length-1, 32));
Console.WriteLine(FindFirstOccurence(data, 25));
Console.WriteLine(FindLastOccurence(data,25));
Console.WriteLine(FindTotalOccurences(data, 25));

int[] binaryData = new int[] { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1 };
Console.WriteLine(CountOne(binaryData));
Console.WriteLine(SquareRoot(17));

int[] rotatedArray = new int[] {100,200,300,40,50,60,80,90};
Console.WriteLine(SearchInRotatedArray(rotatedArray,300));
Console.WriteLine(IsPair(data,0,data.Length-1,50));
Console.ReadLine();

int SearchIterative(int[] data, int x)
{
    int low = 0;
    int high = data.Length - 1;

    while (low <= high)
    {
        int mid = (low + high) / 2;
        if (data[mid] == x)
            return mid;
        if (data[mid]<x)
            low = mid+1;
        if (data[mid]>x)
            high = mid-1;
    }
    return -1;
}
int SearchRecursive(int[] data, int low, int high, int x)
{
    if (low <= high)
    {
        int mid = (low + high) / 2;
        if (data[mid] == x)
        {
            return mid;
        }
        else if (data[mid] > x)
        {
            return SearchRecursive(data, low, mid - 1, x);
        }
        else
        {
            return SearchRecursive(data, mid + 1, high, x);
        }
    }
    return -1;
}
int FindFirstOccurence(int[] data, int x)
{
    int low = 0, high = data.Length - 1;

    while (low <= high)
    {
        int mid = (low + high) / 2;

        if (data[mid] > x)
            high = mid - 1;
        if (data[mid]<x)
            low=mid+1;

        if (data[mid] == x)
        {
            if (mid == 0)
                return mid;
            if (data[mid] == data[mid-1])
                high = mid-1;
            else
                return mid;
        }
    }
    return -1;
}
int FindLastOccurence(int[] data, int x)
{
    int low = 0, high = data.Length - 1;

    while (low <= high)
    {
        int mid = (low + high) / 2;

        if (data[mid] > x)
            high = mid - 1;
        if (data[mid] < x)
            low = mid + 1;

        if (data[mid] == x)
        {
            if (mid == data.Length-1)
                return mid;
            if (data[mid] == data[mid +1])
                low = mid + 1;
            else
                return mid;
        }
    }
    return -1;
}
int FindTotalOccurences(int[] data, int x)
{
    int first = FindFirstOccurence(data,x);
    if (first == -1)
        return 0;
    int last = FindLastOccurence(data,x);
    return last - first+1;
}
int CountOne(int[] binaryData)
{
    int low = 0, high = binaryData.Length - 1;

    while (low <= high)
    {
        int mid = (low + high) / 2;

        if (binaryData[mid] == 0)
            low = mid + 1;
        else
        {
            if(mid!=0 && binaryData[mid-1]==1)
            {
                high = mid - 1;
            }
            else
            {
                return binaryData.Length-mid;
            }
        }
       
    }
    return 0;
}
int SquareRoot(int number)
{
    int low = 1, high = number, answer=-1;
    while (low <= high)
    {
        int mid = (low + high) / 2;
        if (mid * mid > number)
        {
            high = mid - 1;
        }
        else
        {
            low=mid + 1;
            answer = mid;
        }
    }

    return answer;
}
int SearchInRotatedArray(int[] rotatedArray, int x)
{
    int low = 0, high = rotatedArray.Length - 1;

    while (low <= high)
    {
        int mid = (low + high) / 2;

        //See if the array is sorted on left side
        if (rotatedArray[mid] == x)
            return mid;

        if (rotatedArray[low] < rotatedArray[mid])
        {
            //This is a left sorted part
            if (x >= rotatedArray[low] && x < rotatedArray[mid])
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        else
        {
            //Now go the right sub array
            //This is a right sorted part
            if (x <= rotatedArray[high] && x > rotatedArray[mid])
            {
                low = mid + 1;
            }
            else
            {
                high=mid - 1;
            }
        }
    }
    return -1;
}
//Find a pair using two pointer approach
bool IsPair(int[] data, int low, int high, int number)
{
    while (low < high)
    {
        if (data[low] + data[high] == number)
            return true;
        else if (data[low] + data[high] > number)
            high--;
        else
            low++;
    }
    return false;
}