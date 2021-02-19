#include <iostream>

extern "C" __declspec(dllexport) void Hello();

void Hello()
{
    std::cout << "Hello guys";
}

extern "C"
{
    __declspec(dllexport) int __stdcall GetCubeSize() {
        static int cubeSize = 100;
        return cubeSize += 10;
    }
}