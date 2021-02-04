#include <iostream>

extern "C" __declspec(dllexport) void Hello();

void Hello()
{
    std::cout << "Hello guys";
}

extern "C"
{
    __declspec(dllexport) int __stdcall mixed_mode_addition(int a, int b) {
        return a + b;
    }
}