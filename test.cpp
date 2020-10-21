#include <iostream>
#include <cstdio>
using namespace std;

int main()
{
    int a, arr[1000001] = {0}, b;
    scanf("%d", &a);
    while (a--)
    {
        scanf("%d", &b);
        // count the number of times a
        //element appeared in input
        arr[b]++;
    }
    for (int i = 0; i < 1000001; i++)
    {
        // print every element number of
        //times it appeared
        while (arr[i] > 0)
        {
            printf("%d\n", i);
            arr[i]--;
        }
    }
    return 0;
}