#include "pch.h"
#include "CppUnitTest.h"
#include "../EgzaminConsole/Main.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace ConsoleAppTest1
{
	TEST_CLASS(ConsoleAppTest1)
	{
	public:
		
		TEST_METHOD(ValidInput_Collection)
		{
			std::vector<int> v = { 140, 230, 260, 240, 270, 200, 170, 150, 210, 220 };
			Assert::AreEqual(520, findTime(v, 3));
		}
		TEST_METHOD(ValidInput_SmallCollection)
		{
			std::vector<int> v = { 140, 230, 260, 270, 200, 170, 150, 210};
			Assert::AreEqual(520, findTime(v, 3));
		}
		TEST_METHOD(ValidInput_LargeCollection)
		{
			std::vector<int> v = { 140, 230, 260, 240, 270, 200, 170, 150, 210, 220, 260, 280 };
			Assert::AreEqual(520, findTime(v, 3));
		}

		TEST_METHOD(ValidInput_SmallMeasurement)
		{
			std::vector<int> v = { 140, 230, 260, 240, 270, 200, 170, 150, 210, 220 };
			Assert::AreEqual(320, findTime(v, 2));
		}
		TEST_METHOD(ValidInput_LargeMeasurement)
		{
			std::vector<int> v = { 140, 230, 260, 240, 270, 200, 170, 150, 210, 220, 200, 180, 250};
			Assert::AreEqual(950, findTime(v, 5));
		}

	};
}
