#include <iostream>
#include <conio.h>
using namespace std;

int* Count(unsigned N, unsigned M, int T, int** numbers)
{
	int mul = 1;
	int counter = 0;
	for (unsigned i{}; i < N; i++)
	{
		for (unsigned j{}; j < M; j++)
		{
			if (numbers[i][j] < T) {
				mul *= numbers[i][j];
				counter++;
			}
		}
		cout << endl;
	}
	int* result{ new int[4]{counter, mul} };
	return result;
}

void main()
{
	unsigned N;
	unsigned M;
	cout << "N,M = ";
	cin >> N >> M;

	// Инициализация массива
	int** numbers{ new int* [N] {} };
	for (unsigned i{}; i < N; i++)
	{
		numbers[i] = new int[M] {};
	}

	// Заполнение массива
	for (unsigned i{}; i < N; i++)
	{
		cout << "Enter data for " << (i + 1) << " row" << endl;
		for (unsigned j{}; j < M; j++)
		{
			cout << (j + 1) << " column: ";
			cin >> numbers[i][j];
		}
	}

	// Запрос T
	int T;
	cout << "T = ";
	cin >> T;

	// Подсчёт и вывод результата
	int* result = Count(N, M, T, numbers);
	cout << "amount of numbers < T = " << result[0] << "\n";
	cout << "result of multiplying numbers < T = " << result[1] << "\n";
}