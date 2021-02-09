#include <iostream>

extern "C" __declspec(dllexport) void Hello();

void Hello()
{
    std::cout << "Hello guys";
}