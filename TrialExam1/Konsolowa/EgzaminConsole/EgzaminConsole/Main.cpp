#include <iostream>
#include <stdexcept>
#include <vector>
#include "Main.h"

void validateInput(std::istream& input) {
	if (!input) {
		throw std::invalid_argument("Podano nieprawid³owe dane! Oczekiwano liczby.");
	}
}

int findTime(const std::vector<int>& collection, int n)
{
	if (collection.size() < n) {
		throw std::invalid_argument("Zbyt ma³o danych, aby znaleŸæ najlepszy czas na tym odcinku.");
	}

	int bestTime = 0;

	for (size_t i = 0; i < n; i++)
	{
		bestTime += collection[i];
	}
	
	int currentSum = bestTime;

	for (int i = n; i < collection.size()-1; ++i)
	{
		currentSum = currentSum - collection[i - n] + collection[i];
		if (currentSum < bestTime)
		{
			bestTime = currentSum;
		}
	}
	return bestTime;
}

int main()
{
	try
	{
		std::setlocale(LC_ALL, "pl_PL");

		std::vector<int> timesOnKM;
		int distance, distanceMeasurement;

		std::cout << "Ile kilemetrow przebieg³eœ: \n";
		std::cin >> distance;
		validateInput(std::cin);
		std::cout << "Podaj czasy na ka¿dym kilometrze: \n";

		for (int i = 0; i < distance; i++)
		{
			int a;
			std::cin >> a;
			validateInput(std::cin);
			timesOnKM.push_back(a);
		}

		std::cout << "Podaj w jakiej wielkoœci najlepszego odcinka szukasz (w km): \n";
		std::cin >> distanceMeasurement;
		validateInput(std::cin);

		std::cout << "Najlepszt czas na " << distanceMeasurement << "km odcinku wynosi: " << findTime(timesOnKM, distanceMeasurement) << "\n";
	}
	catch (const std::exception& e)
	{
		std::cerr << e.what() << "\n";
	}
	
	return 0;
}